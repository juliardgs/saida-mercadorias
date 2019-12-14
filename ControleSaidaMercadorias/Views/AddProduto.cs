using ControleSaidaMercadorias.DAL;
using ControleSaidaMercadorias.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSaidaMercadorias.Views
{
    public partial class AddProduto : Form
    {
        private ProdutoDAL dal = new ProdutoDAL();
        private Produto prodSelecionado;
        private TelaProdutos telaProdutos;
        private TelaRequisicoes telaRequisicoes;
        private AltProduto altProduto;
        private AltRequisicao altRequisicao;

        public AddProduto()
        {
            InitializeComponent();
        }

        public AddProduto(TelaProdutos telaProd)
        {
            InitializeComponent();
            telaProdutos = telaProd;
        }

        public AddProduto(AltProduto altProd)
        {
            InitializeComponent();
            altProduto = altProd;
        }

        public AddProduto(TelaRequisicoes telaReq)
        {
            InitializeComponent();
            telaRequisicoes = telaReq;
            this.Text = "Adicionar Produtos";
        }

        public AddProduto(AltRequisicao altReq)
        {
            InitializeComponent();
            altRequisicao = altReq;
            this.Text = "Adicionar Produtos";
        }

        
        private bool ProdAdd(DataGridView data, int idProd) //checa se tem já tem o id q a pessoa tá adicionando no dgv, para não haver conflito na hora de salvar
        {
            bool resultado = false;
            foreach(DataGridViewRow linha in data.Rows)
            {
                if (Convert.ToInt32(linha.Cells[0].Value) == idProd)
                    resultado = true;
            }
            return resultado;
        }

        private void addProdutoBtn_Click(object sender, EventArgs e)
        {
            if(qtdeTxt.Text.Trim() == string.Empty || Convert.ToInt32(qtdeTxt.Text) == 0)
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                qtdeTxt.Focus();
            }
            else
            {
                int qtde = Convert.ToInt32(qtdeTxt.Text);
                if(telaProdutos != null)
                {
                    if(ProdAdd(telaProdutos.listaProdSimplesDgv, prodSelecionado.Id))
                    {
                        MessageBox.Show("Não é possível adicionar o produto mais de uma vez.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        telaProdutos.listaProdSimplesDgv.Rows.Add(prodSelecionado.Id, prodSelecionado.Nome, qtdeTxt.Text, prodSelecionado.PrecoCusto * qtde, prodSelecionado.PrecoVenda * qtde);

                }
                if (altProduto != null)
                {
                    if (ProdAdd(altProduto.listaProdSimplesDgv, prodSelecionado.Id))
                    {
                        MessageBox.Show("Não é possível adicionar o produto mais de uma vez.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataRow linha = ((DataTable)altProduto.listaProdSimplesDgv.DataSource).NewRow();
                        linha[0] = prodSelecionado.Id;
                        linha[1] = prodSelecionado.Nome;
                        linha[2] = qtde;
                        linha[3] = prodSelecionado.PrecoCusto * qtde;
                        linha[4] = prodSelecionado.PrecoVenda * qtde;
                        ((DataTable)altProduto.listaProdSimplesDgv.DataSource).Rows.Add(linha);
                    }
                }
                if (telaRequisicoes != null)
                {
                    if (ProdAdd(telaRequisicoes.itensReqDgv, prodSelecionado.Id))
                    {
                        MessageBox.Show("Não é possível adicionar o produto mais de uma vez.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        telaRequisicoes.itensReqDgv.Rows.Add(prodSelecionado.Id, prodSelecionado.Nome, qtdeTxt.Text, prodSelecionado.PrecoCusto, prodSelecionado.PrecoCusto * qtde);
                }
                if(altRequisicao != null)
                {
                    if (ProdAdd(altRequisicao.itensReqDgv, prodSelecionado.Id))
                    {
                        MessageBox.Show("Não é possível adicionar o produto mais de uma vez.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DataRow linha = ((DataTable)altRequisicao.itensReqDgv.DataSource).NewRow();
                        linha[0] = prodSelecionado.Id;
                        linha[1] = prodSelecionado.Nome;
                        linha[2] = qtde;
                        linha[3] = prodSelecionado.PrecoCusto;
                        linha[4] = prodSelecionado.PrecoCusto * qtde;
                        ((DataTable)altRequisicao.itensReqDgv.DataSource).Rows.Add(linha);
                    }
                    
                }
                this.Close();
            }
        }

        private void buscarProdutoBtn_Click(object sender, EventArgs e)
        {
            if(telaRequisicoes != null || altRequisicao != null)
            {
                buscaProdutoDgv.DataSource = dal.BuscarProduto(buscarProdutoTxt.Text)[2];
            }
            if(telaProdutos != null || altProduto != null)
            {
                buscaProdutoDgv.DataSource = dal.BuscarProduto(buscarProdutoTxt.Text)[0];
            }
        }

        private void buscaProdutoDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;

            if (buscaProdutoDgv.CurrentRow.Index < 0)
            {
                addProdutoBtn.Enabled = false;
            }
            else
            {
                addProdutoBtn.Enabled = true;
                prodSelecionado = new Produto()
                {
                    Id = Convert.ToInt32(buscaProdutoDgv.Rows[e.RowIndex].Cells[0].Value),
                    Nome = buscaProdutoDgv.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    PrecoCusto = Convert.ToDouble(buscaProdutoDgv.Rows[e.RowIndex].Cells[2].Value),
                    PrecoVenda = Convert.ToDouble(buscaProdutoDgv.Rows[e.RowIndex].Cells[3].Value),
                };
            }
        }

        private void qtdeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            buscarProdutoTxt.Text = "";
            qtdeTxt.Text = "";
            buscaProdutoDgv.DataSource = null;
        }
    }
}
