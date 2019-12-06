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
        private ProdutoDAL dal;

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
                listaProdSimplesDgv.DataSource = dal.
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
            if(produto.ItemProduto == null)
            {
                if(nomeTxt.Text == string.Empty
                    || precoCustoTxt.Text == string.Empty
                    || precoVendaTxt.Text == string.Empty
                    || qtdeEstoqueTxt.Text == string.Empty)
                {
                    MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
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
                    
                    if(telaProdutos.buscarProdCompostoTxt.Text.Trim() != string.Empty)
                    {
                        telaProdutos.buscarProdutosBtn_Click(new object(), new EventArgs()); // ou SubGraphButton_Click.PerformClick()
                    }
                    this.Close();
                }
            }
            else
            {   

            }
        }
    }
}
