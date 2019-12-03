using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSaidaMercadorias.Views
{
    public partial class TelaProdutos : UserControl
    {
        public TelaProdutos()
        {
            InitializeComponent();
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
            MessageBox.Show("Produto Composto cadastrado com sucesso!", "Cadastro Produto Composto");
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
    }
}
