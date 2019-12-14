using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleSaidaMercadorias.Models;
using ControleSaidaMercadorias.Services;

namespace ControleSaidaMercadorias.DAL
{
    class FuncionarioDAL
    {
        private SqlConnection connection = DBConnection.DB_Connection;
        public void IncluirFuncionario(Funcionario funcionario)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "insert into funcionario (nome, dataNascimento) values (@nome, @dataNascimento)";
            command.Parameters.AddWithValue("@nome", funcionario.Nome);
            command.Parameters.AddWithValue("@dataNascimento", funcionario.DataNascimento);
            command.ExecuteNonQuery();
            connection.Close();
        }


        public DataTable CarregarFuncionarios()
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "select cast(id as varchar) + ' - ' + nome as ID_NOME, id from funcionario where deleted is null;";
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

        public DataTable BuscarFuncionario(string nome)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "select id as ID, nome as NOME, dataNascimento as 'DATA DE NASCIMENTO' from funcionario where nome like @nome and deleted is null;";
            command.Parameters.AddWithValue("@nome", "%" + nome + "%");
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

        public void RemoverFuncionario(int idFuncionario)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "select * from requisicao where idFuncionario = @idFuncionario";
            command.Parameters.Add("@idFuncionario", SqlDbType.Int);
            command.Parameters["@idFuncionario"].Value = idFuncionario;

            SqlDataReader reader = command.ExecuteReader();
            bool resultado = reader.Read();
            connection.Close();

            connection.Open();

            command.Parameters.Add("@idFuncionario2", SqlDbType.Int);

            command.Parameters["@idFuncionario2"].Value = idFuncionario;

            if (resultado) //se tiver registros, faz uma exclusão lógica
            {
                command.CommandText = "update funcionario set deleted = 1 where id = @idFuncionario2";
                command.ExecuteNonQuery();
            }
            else //se não tiver, exclui do bd
            {
                command.CommandText = "delete from funcionario where id = @idFuncionario2";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void AlterarFuncionario(Funcionario funcionario)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "update funcionario set nome = @nome, dataNascimento = @dataNascimento where id = @idFuncionario";
            command.Parameters.AddWithValue("@nome", funcionario.Nome);
            command.Parameters.AddWithValue("@dataNascimento", funcionario.DataNascimento);
            command.Parameters.AddWithValue("@idFuncionario", funcionario.Id);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
