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
        public AltProduto(TelaProdutos telaProdutos, Produto produto)
        {
            InitializeComponent();
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
    }
}
