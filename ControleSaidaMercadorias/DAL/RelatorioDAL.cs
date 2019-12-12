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
    class RelatorioDAL
    {
        private SqlConnection connection = DBConnection.DB_Connection;
        
        public DataTable Relatorios(DateTime inicio, DateTime fim, int tipo)
        {
            connection.Open();
            var command = connection.CreateCommand();
            if(tipo == 1)
            {
                command.CommandText = "select produto.nome as PRODUTO, sum(requisicao_tem_produtos.quantidade) " +
                "as 'QTDE REQUISITADA', (produto.precoCusto * sum(requisicao_tem_produtos.quantidade)) " +
                "as 'PREÇO DE CUSTO TOTAL', (produto.precoVenda * sum(requisicao_tem_produtos.quantidade)) " +
                "as 'PREÇO DE VENDA TOTAL' from produto join " +
                "requisicao_tem_produtos on produto.id = requisicao_tem_produtos.idProduto join requisicao " +
                "on requisicao.id = requisicao_tem_produtos.idRequisicao " +
                "where requisicao.dataReq >= @dataInicio and requisicao.dataReq <= @dataFim " +
                "group by produto.id, produto.nome, produto.precoCusto, produto.precoVenda order by produto.nome;";
            }
            else
            {
                command.CommandText = "select produto.nome as PRODUTO, sum(requisicao_tem_produtos.quantidade) " +
                    "as 'QTDE REQUISITADA', (produto.precoCusto * sum(requisicao_tem_produtos.quantidade)) " +
                    "as 'PREÇO DE CUSTO TOTAL', (produto.precoVenda * sum(requisicao_tem_produtos.quantidade)) " +
                    "as 'PREÇO DE VENDA TOTAL' from produto_tem_produtos join produto " +
                    "on produto.id = produto_tem_produtos.idSimples join requisicao_tem_produtos " +
                    "on produto.id = requisicao_tem_produtos.idProduto join requisicao on " +
                    "requisicao.id = requisicao_tem_produtos.idRequisicao " +
                    "where requisicao.dataReq >= @dataInicio and requisicao.dataReq <= @dataFim " +
                    "group by produto.id, produto.nome, produto.precoCusto, produto.precoVenda " +
                    "order by produto.nome;";
            }

            command.Parameters.AddWithValue("@dataInicio", inicio);
            command.Parameters.AddWithValue("@dataFim", fim);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            return dt;
        }
    }
}
