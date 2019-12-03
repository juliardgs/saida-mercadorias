using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSaidaMercadorias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void funcionariosBtn_Click(object sender, EventArgs e)
        {
            menuFuncionarios.Visible = true;
        }

        private void telaFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void produtosBtn_Click(object sender, EventArgs e)
        {
            telaProdutos.Visible = true;
            telaFuncionarios.Visible = false;
        }

        private void menuFuncionarios_Load(object sender, EventArgs e)
        {

        }
    }
}
