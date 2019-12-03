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
    public partial class MenuFuncionarios : UserControl
    {
        public MenuFuncionarios()
        {
            InitializeComponent();
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            //checar se as informações são válidas
            //chamar o método que cadastra
            MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro Funcionário");
        }
    }
}
