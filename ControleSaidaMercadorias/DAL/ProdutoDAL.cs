using ControleSaidaMercadorias.Models;
using ControleSaidaMercadorias.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleSaidaMercadorias.DAL
{
    class ProdutoDAL
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void IncluirProduto(Produto produto)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "insert into produto (nome, quantidade, precoCusto, precoVenda) output INSERTED.ID values (@nome, @quantidade, @precoCusto, @precoVenda)";
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            command.Parameters.AddWithValue("@precoCusto", produto.PrecoCusto);
            command.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
            command.ExecuteNonQuery();

            if (produto.ItemProduto != null) //se não for nulo é produto composto
            {
                int idProdComposto = (int)command.ExecuteScalar(); //pega o id do produto composto que foi inserido
                command.CommandText = "insert into produto_tem_produtos (idSimples, idComposto, quantidade) values (@idSimples, @idComposto, @quantidadePS)";

                foreach (Produto item in produto.ItemProduto)
                {
                    command.Parameters.AddWithValue("@idSimples", item.Id);
                    command.Parameters.AddWithValue("@idComposto", idProdComposto);
                    command.Parameters.AddWithValue("@quantidadePS", item.Quantidade);
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        public void AlterarProduto(Produto produto, bool composto = false)
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

        public List<DataTable> BuscarProduto(string nome, bool composto = false)
        {
            connection.Open();
            var command = connection.CreateCommand();
            var command2 = connection.CreateCommand();
            command.CommandText = "select id as ID, nome as 'NOME', precoCusto as 'PREÇO DE CUSTO'," + //query só retorna produtos simples
                "precoVenda as 'PREÇO DE VENDA', produto.quantidade as 'ESTOQUE' from produto left join produto_tem_produtos " +
                "on produto.id = produto_tem_produtos.idComposto where lower(nome) like @nome and produto_tem_produtos.idComposto is null";
            command.Parameters.AddWithValue("@nome", "%" + nome.ToLower() + "%");

            command2.CommandText = "select id as ID, nome as 'NOME', precoCusto as 'PREÇO DE CUSTO'," + //query só retorna produtos compostos
                "precoVenda as 'PREÇO DE VENDA' from produto inner join produto_tem_produtos " +
                "on produto.id = produto_tem_produtos.idComposto where lower(nome) like @nome";
            command2.Parameters.AddWithValue("@nome", "%" + nome.ToLower() + "%");

            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader = command2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(reader);
            List<DataTable> listaDt = new List<DataTable>();
            listaDt.Add(dt);
            listaDt.Add(dt2);
            connection.Close();
            return listaDt;
        }
    }
}
