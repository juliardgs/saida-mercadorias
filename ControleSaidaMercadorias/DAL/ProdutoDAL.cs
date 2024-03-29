﻿using ControleSaidaMercadorias.Models;
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
            command.CommandText = "insert into produto (nome, precoCusto, precoVenda) output INSERTED.ID values (@nome, @precoCusto, @precoVenda)";
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@precoCusto", produto.PrecoCusto);
            command.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
            int idProdComposto = (int)command.ExecuteScalar(); //executa o insert e pega o id do produto composto que foi inserido
            
            if (produto.ItemProduto != null) //se não for nulo é produto composto
            {
                command.CommandText = "insert into produto_tem_produtos (idSimples, idComposto, quantidade) values (@idSimples, @idComposto, @quantidadePS)";
                command.Parameters.Add("@idSimples", SqlDbType.Int);
                command.Parameters.Add("@idComposto", SqlDbType.Int);
                command.Parameters.Add("@quantidadePS", SqlDbType.Int);

                foreach (Produto item in produto.ItemProduto)
                {
                    command.Parameters["@idSimples"].Value = item.Id;
                    command.Parameters["@idComposto"].Value = idProdComposto;
                    command.Parameters["@quantidadePS"].Value =  item.Quantidade;
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        public void AlterarProduto(Produto produto, bool composto = false)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "update produto set nome = @nome, precoCusto = @precoCusto, precoVenda = @precoVenda where id = @id";
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@precoCusto", produto.PrecoCusto);
            command.Parameters.AddWithValue("@precoVenda", produto.PrecoVenda);
            command.Parameters.AddWithValue("@id", produto.Id);

            command.ExecuteNonQuery();

            if (composto)
            {
                /*
                 * primeiro apaga
                 * depois faz uma inclusão das coisas novas
                 */

                command.CommandText = "delete from produto_tem_produtos where idComposto = @idComposto";
                command.Parameters.AddWithValue("@idComposto", produto.Id);
                command.ExecuteNonQuery();

                command.CommandText = "insert into produto_tem_produtos (idSimples, idComposto, quantidade) values (@idSimples, @idComposto, @quantidadePS)";

                command.Parameters.Add("@idSimples", SqlDbType.Int);
                command.Parameters.Add("@idComposto2", SqlDbType.Int);
                command.Parameters.Add("@quantidadePS", SqlDbType.Int);


                foreach (Produto item in produto.ItemProduto)
                {
                    command.Parameters["@idSimples"].Value = item.Id;
                    command.Parameters["@idComposto2"].Value = produto.Id;
                    command.Parameters["@quantidadePS"].Value = item.Quantidade;
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
        }

        public List<DataTable> BuscarProduto(string nome, bool composto = false)
        {
            connection.Open();
            var command = connection.CreateCommand();
            var command2 = connection.CreateCommand();
            var command3 = connection.CreateCommand();
            command.CommandText = "select id as ID, nome as 'PRODUTO', precoCusto as 'PREÇO DE CUSTO'," + //query só retorna produtos simples
                "precoVenda as 'PREÇO DE VENDA' from produto left join produto_tem_produtos " +
                "on produto.id = produto_tem_produtos.idComposto where lower(nome) like @nome and produto_tem_produtos.idComposto is null" +
                " and produto.deleted is null";
            command.Parameters.AddWithValue("@nome", "%" + nome.ToLower() + "%");

            command2.CommandText = "select distinct id as ID, nome as 'PRODUTO', precoCusto as 'PREÇO DE CUSTO'," + //query só retorna produtos compostos
                "precoVenda as 'PREÇO DE VENDA' from produto inner join produto_tem_produtos " +
                "on produto.id = produto_tem_produtos.idComposto where lower(nome) like @nome " +
                "and produto.deleted is null";
            command2.Parameters.AddWithValue("@nome", "%" + nome.ToLower() + "%");

            command3.CommandText = "select id as ID, nome as PRODUTO, precoCusto as 'PREÇO DE CUSTO', " +
                "precoVenda as 'PREÇO DE VENDA' from produto where deleted is null;"; //lista todos os tipos de produto que não foram excluídos logicamente

            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader = command2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(reader);
            reader = command3.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Load(reader);
            List<DataTable> listaDt = new List<DataTable>();
            listaDt.Add(dt);
            listaDt.Add(dt2);
            listaDt.Add(dt3);
            connection.Close();
            return listaDt;
        }

        public DataTable ListarItensProdComposto(int idComposto)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "select produto_tem_produtos.idSimples as ID, produto.nome as PRODUTO, produto_tem_produtos.quantidade as QUANTIDADE, produto.precoCusto as 'PREÇO DE CUSTO'," +
                " produto.precoVenda as 'PREÇO DE VENDA' from produto join produto_tem_produtos on produto.id = produto_tem_produtos.idSimples where idComposto = @idComposto";
            command.Parameters.AddWithValue("@idComposto", idComposto);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            return dt;
        }

        public void RemoverProduto(int idProduto, bool composto = false)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "select * from produto_tem_produtos where idComposto = @idProduto or idSimples = @idProduto;";
            command.Parameters.Add("@idProduto", SqlDbType.Int);
            command.Parameters["@idProduto"].Value = idProduto;

            SqlDataReader reader = command.ExecuteReader();
            bool resultado = reader.Read();
            connection.Close();

            connection.Open();
            command.CommandText = "select * from requisicao_tem_produtos where idProduto = @idProd";
            command.Parameters.Add("@idProd", SqlDbType.Int);
            command.Parameters["@idProd"].Value = idProduto;

            SqlDataReader reader2 = command.ExecuteReader();
            bool resultado2 = reader2.Read();
            connection.Close();

            connection.Open();

            command.Parameters.Add("@idProduto2", SqlDbType.Int);

            command.Parameters["@idProduto2"].Value = idProduto;

            if (resultado || resultado2) //se tiver registros, faz uma exclusão lógica
            {
                if (composto)
                {
                    command.CommandText = "update produto_tem_produtos set deleted = 1 where idComposto = @idProduto2 or idSimples = @idProduto2;";
                    command.ExecuteNonQuery();
                }
                command.CommandText = "update produto set deleted = 1 where id = @idProduto2";
                command.ExecuteNonQuery();
            }
            else //se não tiver, exclui do bd
            {
                if (composto)
                {
                    command.CommandText = "delete from produto_tem_produtos where idComposto = @idProduto2 or idSimples = @idProduto2";
                    command.ExecuteNonQuery();
                }
                command.CommandText = "delete from produto where id = @idProduto2";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

    }
}
