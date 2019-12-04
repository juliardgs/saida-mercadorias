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

namespace ControleSaidaMercadorias.Views
{
    public partial class TelaFuncionarios : UserControl
    {
        private FuncionarioDAL dal = new FuncionarioDAL();
        public TelaFuncionarios()
        {
            InitializeComponent();
        }

        void LimparControles()
        {
            nomeTxt.Text = "";
            dataNascDtp.Value = DateTime.Now;
            nomeTxt.Focus();
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            //checar se as informações são válidas
            //chamar o método que cadastra
            if(nomeTxt.Text != "" && nomeTxt != null)
            {
                dal.IncluirFuncionario(new Funcionario()
                {
                    Nome = nomeTxt.Text,
                    DataNascimento = dataNascDtp.Value,
                });
                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro Funcionário");
            }
        }

        private void listagemTab_Click(object sender, EventArgs e)
        {

        }
    }
}
