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
            command.CommandText = "select id + ' ' + nome as ID_NOME, id from funcionario;";
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

    }
}
