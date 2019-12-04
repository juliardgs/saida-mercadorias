using System;
using System.Collections.Generic;
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


    }
}
