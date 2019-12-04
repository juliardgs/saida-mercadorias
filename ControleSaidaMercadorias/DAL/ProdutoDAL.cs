using ControleSaidaMercadorias.Models;
using ControleSaidaMercadorias.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSaidaMercadorias.DAL
{
    class ProdutoDAL
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        void IncluirProdutoSimples(Produto produto)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "insert into produto (nome, quantidade, precoCusto, precoVenda) values (@nome, @quantidade, @precoCusto, @precoVenda)";
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@precoCusto", produto.PrecoCusto);
            command.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
            command.ExecuteNonQuery();
            connection.Close();
        }

        void IncluirProdutoComposto(Produto produto)
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "insert into produto (nome, precoCusto, precoVenda) output INSERTED.ID values (@nome, @precoCusto, @precoVenda)";
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@precoCusto", produto.PrecoCusto);
            command.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
            command.ExecuteNonQuery();
            int idProdComposto = (int)command.ExecuteScalar(); //pega o id do produto composto que foi inserido

            command.CommandText = "insert into produto_tem_produtos (idProdutoSimples, idProdutoComposto) values (@idProdutoSimples, @idProdutoComposto)"; //verificar o nome das colunas

            foreach (Produto item in produto.ItemProduto)
            {
                command.Parameters.AddWithValue("@idProdutoSimples", item.Id);
                command.Parameters.AddWithValue("@idProdutoComposto", idProdComposto);
                command.ExecuteNonQuery();
            }
    
            connection.Close();
        }

        void AlterarProduto(Produto produto)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "update produto set nome = @nome, quantidade = @quantidade, precoCusto = @precoCusto, precoVenda = @precoVenda where id = @id";
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@precoCusto", produto.PrecoCusto);
            command.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
            command.Parameters.AddWithValue("@id", produto.Id);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
