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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void funcionariosBtn_Click(object sender, EventArgs e)
        {
            EsconderTelas();
            telaFuncionarios1.Show();
        }

        private void EsconderTelas()
        {
            telaFuncionarios1.Hide();
            telaProdutos1.Hide();
            telaRequisicoes1.Hide();
            telaRelatorios1.Hide();
        }

        private void produtosBtn_Click(object sender, EventArgs e)
        {
            EsconderTelas();
            telaProdutos1.Show();
        }

        private void requisicoesBtn_Click(object sender, EventArgs e)
        {
            EsconderTelas();
            telaRequisicoes1.Show();
        }

        private void relatoriosBtn_Click(object sender, EventArgs e)
        {
            EsconderTelas();
            telaRelatorios1.Show();
        }
    }
}
