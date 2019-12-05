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
        public TelaProdutos()
        {
            InitializeComponent();
        }

        void LimparControles()
        {
            nomeProdSimplesTxt.Text = "";
            precoVendaProdSimplesTxt.Text = "";
            precoCustoProdSimplesTxt.Text = "";
            nomeProdSimplesTxt.Focus();
        }

        private void cadastroProdSimplesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verifica se há algum item na listview
            //verifica se os campos nome e preco de venda estão nulos
            //grava no banco
            //limpa os campos, foco no textbox de nome
        }

        private void buscarProdutosBtn_Click(object sender, EventArgs e)
        {
            //verifica campos
            //busca no banco e retorna no data grid view
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                    PrecoCusto = Convert.ToDouble(precoCustoProdSimplesTxt.Text, CultureInfo.InvariantCulture),
                    PrecoVenda = Convert.ToDouble(precoVendaProdSimplesTxt.Text, CultureInfo.InvariantCulture),
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
    }
}
