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
    public partial class AltProduto : Form
    {
        private TelaProdutos telaProdutos;
        private Produto produto;
        private ProdutoDAL dal = new ProdutoDAL();
        private List<Produto> itens;

        public AltProduto()
        {
            InitializeComponent();
        }
        public AltProduto(TelaProdutos telaProd, Produto prod)
        {
            InitializeComponent();
            telaProdutos = telaProd;
            produto = prod;

            
            if(prod.ItemProduto == null)
            {
                listaProdSimplesPanel.Visible = false;
                addExcBtnPanel.Visible = false;
                qtdeEstoqueTxt.Text = prod.Quantidade.ToString();
            }
            else
            {
                qtdeEstoqueLbl.Visible = false;
                qtdeEstoqueTxt.Visible = false;
                precoCustoTxt.Enabled = false;
                listaProdSimplesPanel.Visible = true;
                addExcBtnPanel.Visible = true;
                listaProdSimplesDgv.DataSource = dal.ListarItensProdComposto(prod.Id);
            }

            nomeTxt.Text = prod.Nome;
            precoCustoTxt.Text = prod.PrecoCusto.ToString();
            precoVendaTxt.Text = prod.PrecoVenda.ToString();
            

        }

        private void precoCustoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                if (precoCustoTxt.Text.Contains(","))
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

        private void precoVendaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';

                if (precoVendaTxt.Text.Contains(","))
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

        private void qtdeEstoqueTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void qtdeProdSimplesTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void addProdSimplesBtn_Click(object sender, EventArgs e)
        {
            AddProduto addProduto = new AddProduto(this);
            addProduto.Show();
        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            if (nomeTxt.Text.Trim() == string.Empty
                    || (precoCustoTxt.Text == string.Empty || Convert.ToInt32(precoCustoTxt.Text) == 0)
                    || (precoVendaTxt.Text == string.Empty || Convert.ToInt32(precoVendaTxt.Text) == 0)
                    || (qtdeEstoqueTxt.Text == string.Empty && qtdeEstoqueTxt.Visible == true)
                    || Convert.ToInt32(qtdeEstoqueTxt.Text) == 0)
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if(produto.ItemProduto == null)
                {
                    dal.AlterarProduto(new Produto()
                    {
                        Id = produto.Id,
                        Nome = nomeTxt.Text,
                        Quantidade = Convert.ToInt32(qtdeEstoqueTxt.Text),
                        PrecoCusto = Convert.ToDouble(precoCustoTxt.Text),
                        PrecoVenda = Convert.ToDouble(precoVendaTxt.Text)
                    });
                    MessageBox.Show("Produto Simples alterado com sucesso!", "Alterar Produto Simples", MessageBoxButtons.OK);
                }
                else
                {
                    if (listaProdSimplesDgv.Rows.Count > 0)
                    {
                        itens = new List<Produto>();
                        foreach (DataGridViewRow linha in listaProdSimplesDgv.Rows)
                        {
                            Produto itemProduto = new Produto()
                            {
                                Id = Convert.ToInt32(linha.Cells[0].Value),
                                Quantidade = Convert.ToInt32(linha.Cells[2].Value)
                            };
                            itens.Add(itemProduto);
                        }

                        dal.AlterarProduto(new Produto()
                        {
                            Id = produto.Id,
                            Nome = nomeTxt.Text,
                            ItemProduto = itens,
                            PrecoCusto = Convert.ToDouble(precoCustoTxt.Text),
                            PrecoVenda = Convert.ToDouble(precoVendaTxt.Text)
                        }, true);
                        MessageBox.Show("Produto Composto alterado com sucesso!", "Alterar Produto Composto", MessageBoxButtons.OK);
                    }
                }
                if (telaProdutos.buscarProdCompostoTxt.Text.Trim() != string.Empty)
                {
                    telaProdutos.buscarProdutosBtn_Click(new object(), new EventArgs());
                }
                this.Close();
            }
        }

        private void listaProdSimplesDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;

            if(listaProdSimplesDgv.CurrentRow.Index < 0)
            {
                excProdSimplesBtn.Enabled = false;
            }
            excProdSimplesBtn.Enabled = true;
        }

        private void CalcularPrecoCusto()
        {
            double precoCusto = 0;
            foreach (DataGridViewRow linha in listaProdSimplesDgv.Rows)
            {
                precoCusto += Convert.ToDouble(linha.Cells[3].Value);
            }
            precoCustoTxt.Text = precoCusto.ToString();
        }

        private void listaProdSimplesDgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularPrecoCusto();
        }

        private void listaProdSimplesDgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularPrecoCusto();
        }
    }
}
