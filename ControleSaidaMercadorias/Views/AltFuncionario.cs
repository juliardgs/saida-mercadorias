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
    public partial class AltFuncionario : Form
    {
        private FuncionarioDAL dal = new FuncionarioDAL();
        private Funcionario funcionario;
        private TelaFuncionarios telaFuncionarios;
        public AltFuncionario()
        {
            InitializeComponent();
        }

        public AltFuncionario(Funcionario func, TelaFuncionarios telaFunc)
        {
            InitializeComponent();
            funcionario = func;
            telaFuncionarios = telaFunc;
            nomeTxt.Text = func.Nome;
            dataNascDtp.Value = func.DataNascimento;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(nomeTxt.Text.Trim() != string.Empty && dataNascDtp.Value != null)
            {
                dal.AlterarFuncionario(new Funcionario()
                {
                    Id = funcionario.Id,
                    Nome = nomeTxt.Text,
                    DataNascimento = dataNascDtp.Value
                });
                MessageBox.Show("Funcionário alterado com sucesso!", "Alterar Funcionário");
                telaFuncionarios.buscarBtn.PerformClick();
                this.Close();
            }
            else
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
