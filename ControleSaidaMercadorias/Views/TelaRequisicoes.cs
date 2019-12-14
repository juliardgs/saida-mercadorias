using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleSaidaMercadorias.DAL;
using ControleSaidaMercadorias.Models;

namespace ControleSaidaMercadorias.Views
{
    public partial class TelaRequisicoes : UserControl
    {
        private FuncionarioDAL funcDal = new FuncionarioDAL();
        private RequisicaoDAL reqDal = new RequisicaoDAL();
        private Requisicao reqSelecionada;
        public TelaRequisicoes()
        {
            InitializeComponent();
        }

        public void CarregarFuncionarios(ComboBox comboBox, bool altReq = false)
        {
            if(comboBox.DataSource == null || altReq == false)
            {
                var dados = funcDal.CarregarFuncionarios();
                comboBox.DataSource = dados;
                comboBox.DisplayMember = "ID_NOME";
                comboBox.ValueMember = "id";
            }
        }

        #region ABA CADASTRAR REQUISIÇÃO
        private void funReqCb_Enter(object sender, EventArgs e)
        {
            CarregarFuncionarios(funReqCb);
        }

        private void itensReqDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;

            if (itensReqDgv.CurrentRow.Index < 0)
            {
                excItemBtn.Enabled = false;
            }
            else
            {
                excItemBtn.Enabled = true;
            }
        }

        public void CalcularPrecoCustoTotal()
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

        private void excItemBtn_Click(object sender, EventArgs e)
        {
            if (itensReqDgv.RowCount > 0)
            {
                itensReqDgv.Rows.RemoveAt(itensReqDgv.CurrentRow.Index);
            }
            else
            {
                excItemBtn.Enabled = false;
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            AddProduto addProduto = new AddProduto(this);
            addProduto.Show();
        }

        private void salvarReqBtn_Click(object sender, EventArgs e)
        {
            if (funReqCb.SelectedIndex == -1
                || itensReqDgv.Rows.Count == 0
                || precoCustoTotalTxt.Text == string.Empty)
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                List<Produto> itens = new List<Produto>();
                foreach (DataGridViewRow linha in itensReqDgv.Rows)
                {
                    Produto itemProduto = new Produto()
                    {
                        Id = Convert.ToInt32(linha.Cells[0].Value),
                        Quantidade = Convert.ToInt32(linha.Cells[2].Value)
                    };
                    itens.Add(itemProduto);
                }

                reqDal.IncluirRequisicao(new Requisicao()
                {
                    IdFuncionario = Convert.ToInt32(funReqCb.SelectedValue),
                    Data = dataReqDtp.Value,
                    PrecoCustoTotal = Convert.ToDouble(precoCustoTotalTxt.Text),
                    ItensReq = itens
                });
                MessageBox.Show("Requisição cadastrada com sucesso!", "Cadastro de Requisições");
                LimparControles();
            }
        }

        private void LimparControles()
        {
            funReqCb.SelectedIndex = -1;
            dataReqDtp.Value = DateTime.Now;
            itensReqDgv.Rows.Clear();
            precoCustoTotalTxt.Text = "";
            excItemBtn.Enabled = false;
        }

        #endregion

        #region ABA LISTAR REQUISIÇÃO
        private void buscaFuncCb_Enter(object sender, EventArgs e)
        {
            CarregarFuncionarios(buscaFuncCb);
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (buscaFuncCb.SelectedIndex == -1)
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                buscaReqDgv.DataSource = reqDal.BuscarRequisicao(Convert.ToInt32(buscaFuncCb.SelectedValue));
            }
        }

        private void buscaReqDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;
            if (buscaReqDgv.CurrentRow.Index < 0)
            {
                excReqBtn.Enabled = false;
            }
            else
            {
                excReqBtn.Enabled = true;
                alterarReqBtn.Enabled = true;
                reqSelecionada = new Requisicao()
                {
                    Id = Convert.ToInt32(buscaReqDgv.Rows[e.RowIndex].Cells[0].Value),
                    IdFuncionario = Convert.ToInt32(buscaReqDgv.Rows[e.RowIndex].Cells[1].Value),
                    Data = Convert.ToDateTime(buscaReqDgv.Rows[e.RowIndex].Cells[2].Value),
                    PrecoCustoTotal = Convert.ToDouble(buscaReqDgv.Rows[e.RowIndex].Cells[3].Value)
                };
            }
        }

        private void alterarReqBtn_Click(object sender, EventArgs e)
        {
            AltRequisicao altRequisicao = new AltRequisicao(this, reqSelecionada);
            altRequisicao.Show();
        }

        private void excReqBtn_Click(object sender, EventArgs e)
        {
            if (buscaReqDgv.CurrentRow.Index < 0)
            {
                excReqBtn.Enabled = false;
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar a requisição?", "Excluir Requisição", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    reqDal.ExcluirRequisicao(reqSelecionada.Id);
                    if (buscaFuncCb.SelectedIndex != -1)
                    {
                        buscarBtn.PerformClick();
                    }
                    MessageBox.Show("Requisição excluída com sucesso!", "Excluir Requisição");
                }

            }
        }
        #endregion

    }
}
