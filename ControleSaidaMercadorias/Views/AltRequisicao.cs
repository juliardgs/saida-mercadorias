using ControleSaidaMercadorias.DAL;
using ControleSaidaMercadorias.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSaidaMercadorias.Views
{
    public partial class AltRequisicao : Form
    {
        private TelaRequisicoes telaRequisicoes;
        private RequisicaoDAL dal = new RequisicaoDAL();
        private Requisicao requisicao = new Requisicao();

        public AltRequisicao()
        {
            InitializeComponent();
        }

        public AltRequisicao(TelaRequisicoes telaReq, Requisicao req)
        {
            InitializeComponent();
            telaRequisicoes = telaReq;
            requisicao = req;
            telaRequisicoes.CarregarFuncionarios(funcReqCb);
            funcReqCb.SelectedValue = req.IdFuncionario;
            dataReqDtp.Value = req.Data;
            itensReqDgv.DataSource = dal.BuscarItensReq(req.Id);
            precoCustoTotalTxt.Text = req.PrecoCustoTotal.ToString();
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            AddProduto addProduto = new AddProduto(this);
            addProduto.Show();
        }

        private void CalcularPrecoCustoTotal()
        {
            double precoCusto = 0;
            foreach (DataGridViewRow linha in itensReqDgv.Rows)
            {
                precoCusto += Convert.ToDouble(linha.Cells[4].Value);
            }
            precoCustoTotalTxt.Text = precoCusto.ToString();
        }

        private void itensReqDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularPrecoCustoTotal();
        }

        private void itensReqDgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularPrecoCustoTotal();
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if(funcReqCb.SelectedIndex == -1
                || itensReqDgv.Rows.Count == 0)
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                requisicao.IdFuncionario = Convert.ToInt32(funcReqCb.SelectedValue);
                requisicao.Data = dataReqDtp.Value;
                requisicao.PrecoCustoTotal = Convert.ToDouble(precoCustoTotalTxt.Text);
                List<Produto> itensReq = new List<Produto>();

                foreach (DataGridViewRow linha in itensReqDgv.Rows)
                {
                    Produto itemProduto = new Produto()
                    {
                        Id = Convert.ToInt32(linha.Cells[0].Value),
                        Quantidade = Convert.ToInt32(linha.Cells[2].Value)
                    };
                    itensReq.Add(itemProduto);
                }

                requisicao.ItensReq = itensReq;
                dal.AlterarRequisicao(requisicao);
                if (telaRequisicoes.buscaFuncCb.SelectedIndex != -1)
                {
                    telaRequisicoes.buscarBtn.PerformClick();
                }
                MessageBox.Show("Requisição alterada com sucesso!", "Alterar Requisição");
                this.Close();
            }

        }

        private void itensReqDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;
            if (itensReqDgv.CurrentRow.Index < 0)
            {
                excProdBtn.Enabled = false;
            }
            else
            {
                excProdBtn.Enabled = true;
            }
        }

        private void excProdBtn_Click(object sender, EventArgs e)
        {
            if (itensReqDgv.RowCount > 0)
            {
                itensReqDgv.Rows.RemoveAt(itensReqDgv.CurrentRow.Index);
            }
            else
            {
                excProdBtn.Enabled = false;
            }
        }
    }
}
