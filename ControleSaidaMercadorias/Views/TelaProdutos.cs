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
using System.Globalization;

namespace ControleSaidaMercadorias.Views
{
    public partial class TelaProdutos : UserControl
    {
        private ProdutoDAL dal = new ProdutoDAL();
        private Produto produtoSelecionado;
        public TelaProdutos()
        {
            InitializeComponent();
        }

        #region ABA CADASTRAR PRODUTO SIMPLES

        void LimparControles()
        {
            nomeProdSimplesTxt.Text = "";
            precoVendaProdSimplesTxt.Text = "";
            precoCustoProdSimplesTxt.Text = "";
            nomeProdSimplesTxt.Focus();
        }

        private void cadastrarProdSimplesBtn_Click(object sender, EventArgs e)
        {
            if (nomeProdSimplesTxt.Text.Trim() == string.Empty
                || precoCustoProdSimplesTxt.Text == string.Empty
                || precoVendaProdSimplesTxt.Text == string.Empty
                || precoCustoProdSimplesTxt.Text == ","
                || precoVendaProdSimplesTxt.Text == ","
                || Convert.ToDouble(precoCustoProdSimplesTxt.Text) == 0
                || Convert.ToDouble(precoVendaProdSimplesTxt.Text) == 0)

            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dal.IncluirProduto(new Produto()
                {
                    Nome = nomeProdSimplesTxt.Text,
                    PrecoCusto = Convert.ToDouble(precoCustoProdSimplesTxt.Text),
                    PrecoVenda = Convert.ToDouble(precoVendaProdSimplesTxt.Text),
                });
                MessageBox.Show("Produto Simples cadastrado com sucesso!", "Cadastro Produto Simples");
                LimparControles();
            }
        }

        private void precoCustoProdSimplesTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                if (precoCustoProdSimplesTxt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            //aceita apenas números, tecla backspace
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void precoVendaProdSimplesTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                if (precoVendaProdSimplesTxt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            //aceita apenas números, tecla backspace
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region ABA CADASTRAR PRODUTO COMPOSTO

        private void precoCustoProdCompostoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                if (precoCustoProdCompostoTxt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            //aceita apenas números, tecla backspace
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void precoVendaProdCompostoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                if (precoVendaProdCompostoTxt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            //aceita apenas números, tecla backspace
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void excluirProdSimplesBtn_Click(object sender, EventArgs e)
        {
            if (listaProdSimplesDgv.RowCount > 0)
            {
                listaProdSimplesDgv.Rows.RemoveAt(listaProdSimplesDgv.CurrentRow.Index);
                CalcularPrecoCusto();
            }
            else
            {
                excluirProdSimplesBtn.Enabled = false;
            }

        }

        private void adicionarProdSimplesBtn_Click(object sender, EventArgs e)
        {
            AddProduto addProduto = new AddProduto(this);
            addProduto.Show();
        }

        private void listaProdSimplesDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularPrecoCusto();
        }

        private void CalcularPrecoCusto()
        {
            double precoCusto = 0;
            foreach (DataGridViewRow linha in listaProdSimplesDgv.Rows)
            {
                precoCusto += Convert.ToDouble(linha.Cells[3].Value);
            }
            precoCustoProdCompostoTxt.Text = precoCusto.ToString();
        }

        private void LimparControlesPC()
        {
            nomeProdCompostoTxt.Text = "";
            precoCustoProdCompostoTxt.Text = "";
            precoVendaProdCompostoTxt.Text = "";
            listaProdSimplesDgv.Rows.Clear();
            excluirProdSimplesBtn.Enabled = false;
        }

        private void listaProdSimplesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;
            if (listaProdSimplesDgv.CurrentRow.Index < 0)
            {
                excluirProdSimplesBtn.Enabled = false;
            }
            else
            {
                excluirProdSimplesBtn.Enabled = true;
                produtoSelecionado = new Produto()
                {
                    PrecoCusto = Convert.ToDouble(listaProdSimplesDgv.Rows[e.RowIndex].Cells[4].Value),
                };
            }
        }

        private void cadastroProdCompostoBtn_Click(object sender, EventArgs e)
        {
            if (listaProdSimplesDgv.Rows.Count == 0
                || nomeProdCompostoTxt.Text == string.Empty
                || precoVendaProdCompostoTxt.Text == string.Empty)
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                List<Produto> itens = new List<Produto>();
                foreach (DataGridViewRow linha in listaProdSimplesDgv.Rows)
                {
                    Produto itemProduto = new Produto()
                    {
                        Id = Convert.ToInt32(linha.Cells[0].Value),
                        Quantidade = Convert.ToInt32(linha.Cells[2].Value)
                    };
                    itens.Add(itemProduto);

                }
                dal.IncluirProduto(new Produto()
                {
                    Nome = nomeProdCompostoTxt.Text,
                    PrecoCusto = Convert.ToDouble(precoCustoProdCompostoTxt.Text),
                    PrecoVenda = Convert.ToDouble(precoVendaProdCompostoTxt.Text),
                    ItemProduto = itens
                });
                MessageBox.Show("Produto Composto cadastrado com sucesso!", "Cadastro Produto Composto");
                LimparControlesPC();
            }
        }
        #endregion

        #region ABA LISTAR PRODUTOS
        public void buscarProdutosBtn_Click(object sender, EventArgs e)
        {
            if(buscarProdCompostoTxt.Text == string.Empty)
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                buscaProdSimplesDgv.DataSource = dal.BuscarProduto(buscarProdCompostoTxt.Text)[0];
                buscaProdCompostoDgv.DataSource = dal.BuscarProduto(buscarProdCompostoTxt.Text)[1];
            }
        }

        private void buscaProdSimplesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;

            if (buscaProdCompostoDgv.SelectedRows.Count > 0)
            {
                buscaProdCompostoDgv.ClearSelection();
            }

            if (buscaProdSimplesDgv.CurrentRow.Index < 0)
            {
                excluirProdutoBtn.Enabled = false;
                alterarProdBtn.Enabled = false;
            }
            else
            {
                excluirProdutoBtn.Enabled = true;
                alterarProdBtn.Enabled = true;

                produtoSelecionado = new Produto()
                {
                    Id = Convert.ToInt32(buscaProdSimplesDgv.Rows[e.RowIndex].Cells[0].Value),
                    Nome = buscaProdSimplesDgv.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    PrecoCusto = Convert.ToDouble(buscaProdSimplesDgv.Rows[e.RowIndex].Cells[2].Value),
                    PrecoVenda = Convert.ToDouble(buscaProdSimplesDgv.Rows[e.RowIndex].Cells[3].Value)
                };
            }
        }

        private void buscaProdCompostoDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;

            if (buscaProdSimplesDgv.SelectedRows.Count > 0)
            {
                buscaProdSimplesDgv.ClearSelection();
            }

            if (buscaProdCompostoDgv.CurrentRow.Index < 0)
            {
                excluirProdutoBtn.Enabled = false;
                alterarProdBtn.Enabled = false;
            }
            else
            {
                excluirProdutoBtn.Enabled = true;
                alterarProdBtn.Enabled = true;

                produtoSelecionado = new Produto()
                {
                    Id = Convert.ToInt32(buscaProdCompostoDgv.Rows[e.RowIndex].Cells[0].Value),
                    Nome = buscaProdCompostoDgv.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    PrecoCusto = Convert.ToDouble(buscaProdCompostoDgv.Rows[e.RowIndex].Cells[2].Value),
                    PrecoVenda = Convert.ToDouble(buscaProdCompostoDgv.Rows[e.RowIndex].Cells[3].Value),
                    ItemProduto = new List<Produto>() //depois ver o q vou passar aqui
                };
            }
        }

        private void excluirProdutoBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o produto?", "Excluir Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                dal.RemoverProduto(produtoSelecionado.Id, produtoSelecionado.ItemProduto == null ? false : true);
                if (buscarProdCompostoTxt.Text != string.Empty)
                {
                    buscarProdutosBtn.PerformClick();
                }
                MessageBox.Show("Produto excluído com sucesso!", "Excluir Produto");
            }
        }

        private void alterarProdBtn_Click(object sender, EventArgs e)
        {
            AltProduto altProduto = new AltProduto(this, produtoSelecionado);
            altProduto.Show();
        }

        #endregion
    }
}
