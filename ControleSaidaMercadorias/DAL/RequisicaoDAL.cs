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
    class RequisicaoDAL
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void IncluirRequisicao(Requisicao requisicao)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "insert into requisicao (dataReq, idFuncionario, precoCustoTotal) output INSERTED.ID values (@dataReq, @idFuncionario, @precoCustoTotal)";
            command.Parameters.AddWithValue("@dataReq", requisicao.Data);
            command.Parameters.AddWithValue("@idFuncionario", requisicao.IdFuncionario);
            command.Parameters.AddWithValue("@precoCustoTotal", requisicao.PrecoCustoTotal);
            int idReq = (int)command.ExecuteScalar(); //executa o insert e pega o id do produto composto que foi inserido

            
            command.CommandText = "insert into requisicao_tem_produtos (idRequisicao, idProduto, quantidade) values (@idRequisicao, @idProduto, @quantidade)";
            command.Parameters.Add("@idRequisicao", SqlDbType.Int);
            command.Parameters.Add("@idProduto", SqlDbType.Int);
            command.Parameters.Add("@quantidade", SqlDbType.Int);

            foreach (Produto item in requisicao.ItensReq)
            {
                command.Parameters["@idRequisicao"].Value = idReq;
                command.Parameters["@idProduto"].Value = item.Id;
                command.Parameters["@quantidade"].Value = item.Quantidade;
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public DataTable BuscarRequisicao(int idFuncionario)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "select id as 'ID REQUISIÇÃO', idFuncionario as 'ID FUNCIONARIO', dataReq as 'DATA DA REQUISIÇÃO', precoCustoTotal as 'PREÇO DE CUSTO TOTAL'" +
                "from requisicao where idFuncionario = @idFuncionario";
            command.Parameters.AddWithValue("@idFuncionario", idFuncionario);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            return dt;
        }
        public DataTable BuscarItensReq(int idReq)
        {
            connection.Open();
            var command = connection.CreateCommand();
        
            command.CommandText = "select produto.id as ID, produto.nome as NOME, " +
                "requisicao_tem_produtos.quantidade as QUANTIDADE, produto.precoCusto as 'PREÇO DE CUSTO UNITÁRIO', " +
                "produto.precoCusto* requisicao_tem_produtos.quantidade as SUBTOTAL from produto join " +
                "requisicao_tem_produtos on produto.id = requisicao_tem_produtos.idProduto " +
                "where requisicao_tem_produtos.idRequisicao = @idRequisicao;";
            command.Parameters.AddWithValue("@idRequisicao", idReq);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            connection.Close();
            return dt;
        }
    }
}
