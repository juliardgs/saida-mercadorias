using ControleSaidaMercadorias.DAL;
using ControleSaidaMercadorias.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleSaidaMercadorias.Views
{
    public partial class AddProduto : Form
    {
        private ProdutoDAL dal = new ProdutoDAL();
        Produto prodSelecionado;
        TelaProdutos telaProdutos;

        public AddProduto(TelaProdutos telaProd)
        {
            InitializeComponent();
            telaProdutos = telaProd;
        }

        private void addProdutoBtn_Click(object sender, EventArgs e)
        {
            if(qtdeTxt.Text == string.Empty)
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                qtdeTxt.Focus();
            }
            else
            {
                int qtde = Convert.ToInt32(qtdeTxt.Text);
                //telaProdutos.listaProdSimplesDgv.Rows.Add(prodSelecionado.Id, prodSelecionado.Nome, qtdeTxt.Text, prodSelecionado.PrecoCusto, prodSelecionado.PrecoVenda);
                telaProdutos.listaProdSimplesDgv.Rows.Add(1, "Produto 1", qtde, (qtde * 2.3), (qtde * 5.7));
                this.Close();
            }
            
        }

        private void buscarProdutoBtn_Click(object sender, EventArgs e)
        {
            DataTable dados = dal.BuscarProduto(buscarProdutoTxt.Text);
            buscaProdutoDgv.DataSource = dados;
        }

        private void buscaProdutoDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //colocar verificação
            //addProdutoBtn.Enabled = true;
            prodSelecionado = new Produto()
            {
                Id = Convert.ToInt32(buscaProdutoDgv.Rows[e.RowIndex].Cells[0].Value),
                Nome = buscaProdutoDgv.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Quantidade = Convert.ToInt32(qtdeTxt.Text),
                PrecoCusto = Convert.ToDouble(buscaProdutoDgv.Rows[e.RowIndex].Cells[2].Value, CultureInfo.InvariantCulture), //hmmmmmmmmmm
                PrecoVenda = Convert.ToDouble(buscaProdutoDgv.Rows[e.RowIndex].Cells[3].Value, CultureInfo.InvariantCulture),
            };
                
        }

        private void qtdeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            buscarProdutoTxt.Text = "";
            qtdeTxt.Text = "";
            buscaProdutoDgv.DataSource = null;
        }
    }
}
