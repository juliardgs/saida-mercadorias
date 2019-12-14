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
        private Funcionario funcionarioSelecionado;
        public TelaFuncionarios()
        {
            InitializeComponent();
        }

        #region ABA CADASTRAR FUNCIONÁRIOS
        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            if (nomeTxt.Text.Trim() != string.Empty)
            {
                dal.IncluirFuncionario(new Funcionario()
                {
                    Nome = nomeTxt.Text,
                    DataNascimento = dataNascDtp.Value,
                });
                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro Funcionário");
                LimparControles();
            }
            else
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void LimparControles()
        {
            nomeTxt.Text = "";
            dataNascDtp.Value = DateTime.Now;
            nomeTxt.Focus();
        }
        #endregion


        #region ABA LISTAR FUNCIONÁRIOS

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            funcDgv.DataSource = dal.BuscarFuncionario(buscarTxt.Text);
        }

        private void funcDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;
            if (funcDgv.CurrentRow.Index < 0)
            {
                excluirBtn.Enabled = false;
            }
            else
            {
                alterarBtn.Enabled = true;
                excluirBtn.Enabled = true;
                funcionarioSelecionado = new Funcionario()
                {
                    Id = Convert.ToInt32(funcDgv.Rows[e.RowIndex].Cells[0].Value),
                    Nome = funcDgv.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    DataNascimento = Convert.ToDateTime(funcDgv.Rows[e.RowIndex].Cells[2].Value)
                };
            }
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            if(funcionarioSelecionado != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o funcinário?", "Excluir Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    dal.RemoverFuncionario(funcionarioSelecionado.Id);
                    if (buscarBtn.Text != string.Empty)
                    {
                        buscarBtn.PerformClick();
                    }
                    MessageBox.Show("Funcionário excluído com sucesso!", "Excluir Funcionário");
                }
            }
            
        }

        private void alterarBtn_Click(object sender, EventArgs e)
        {
            AltFuncionario altFuncionario = new AltFuncionario(funcionarioSelecionado, this);
            altFuncionario.Show();
        }
        #endregion
    }
}
