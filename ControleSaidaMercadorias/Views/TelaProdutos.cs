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

        void LimparControles()
        {
            nomeProdSimplesTxt.Text = "";
            precoVendaProdSimplesTxt.Text = "";
            precoCustoProdSimplesTxt.Text = "";
            qtdeProdSimplesTxt.Text = "";
            nomeProdSimplesTxt.Focus();
        }


        private void buscarProdutosBtn_Click(object sender, EventArgs e)
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
            //busca no banco e retorna no data grid view
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

        private void cadastrarProdSimplesBtn_Click(object sender, EventArgs e)
        {
            if(nomeProdSimplesTxt.Text.Trim() == string.Empty 
                || precoCustoProdSimplesTxt.Text == string.Empty
                || precoVendaProdSimplesTxt.Text == string.Empty
                || precoCustoProdSimplesTxt.Text == ","
                || precoVendaProdSimplesTxt.Text == ",")
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dal.IncluirProduto(new Produto() {
                    Nome = nomeProdSimplesTxt.Text,
                    PrecoCusto = Convert.ToDouble(precoCustoProdSimplesTxt.Text),
                    PrecoVenda = Convert.ToDouble(precoVendaProdSimplesTxt.Text),
                    Quantidade = Convert.ToInt32(qtdeProdSimplesTxt.Text),
                });
                MessageBox.Show("Produto Simples cadastrado com sucesso!", "Cadastro Produto Simples");
                LimparControles();
            }
        }

        private void qtdeProdSimplesTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
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

        private void adicionarProdSimplesBtn_Click(object sender, EventArgs e)
        {
            AddProduto addProduto = new AddProduto(this);
            addProduto.Show();
        }

        private void cadastroProdCompostoBtn_Click(object sender, EventArgs e)
        {
            if(listaProdSimplesDgv.Rows.Count == 0
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
                    PrecoCusto = Convert.ToDouble(precoCustoProdCompostoTxt.Text, CultureInfo.InvariantCulture),
                    PrecoVenda = Convert.ToDouble(precoVendaProdCompostoTxt.Text),
                    ItemProduto = itens
                });
                MessageBox.Show("Produto Composto cadastrado com sucesso!", "Cadastro Produto Composto");

            }
        }

        private void listaProdSimplesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;
            if(listaProdSimplesDgv.CurrentRow.Index < 0)
            {
                excluirProdSimplesBtn.Enabled = false;
            }
            else
            {
                excluirProdSimplesBtn.Enabled = true;
                produtoSelecionado = new Produto() //colocar outras propriedades aqui
                {
                    PrecoCusto = Convert.ToDouble(listaProdSimplesDgv.Rows[e.RowIndex].Cells[4].Value, CultureInfo.InvariantCulture),
                };
            }
        }

        private void listaProdSimplesDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularPrecoCusto();
        }

        private void excluirProdSimplesBtn_Click(object sender, EventArgs e)
        {
            if(listaProdSimplesDgv.RowCount > 0)
            {
                listaProdSimplesDgv.Rows.RemoveAt(listaProdSimplesDgv.CurrentRow.Index);
                CalcularPrecoCusto();
            }
            else
            {
                excluirProdSimplesBtn.Enabled = false;
            }
            
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

        private void excluirProdutoBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void buscaProdSimplesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;
            if (buscaProdSimplesDgv.CurrentRow.Index < 0)
            {
                excluirProdutoBtn.Enabled = false;
                alterarProdBtn.Enabled = false;
            }
            else
            {
                excluirProdutoBtn.Enabled = true;
                alterarProdBtn.Enabled = true;
            }


        }

        private void alterarProdBtn_Click(object sender, EventArgs e)
        {
            AltProduto altProduto = new AltProduto(this, produtoSelecionado);
            altProduto.Show();
        }

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
    }
}
