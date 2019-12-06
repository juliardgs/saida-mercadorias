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
        AltProduto altProduto;

        public AddProduto(TelaProdutos telaProd)
        {
            InitializeComponent();
            telaProdutos = telaProd;
        }

        public AddProduto(AltProduto altProd)
        {
            InitializeComponent();
            altProduto = altProd;
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
                telaProdutos.listaProdSimplesDgv.Rows.Add(prodSelecionado.Id, prodSelecionado.Nome, qtdeTxt.Text, (prodSelecionado.PrecoCusto * qtde), (prodSelecionado.PrecoVenda * qtde));
                this.Close();
            }
            
        }

        private void buscarProdutoBtn_Click(object sender, EventArgs e)
        {
            buscaProdutoDgv.DataSource = dal.BuscarProduto(buscarProdutoTxt.Text)[0];
        }

        private void buscaProdutoDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) //se clicar no cabeçalho 
                return;

            if (buscaProdutoDgv.CurrentRow.Index < 0)
            {
                addProdutoBtn.Enabled = false;
            }
            else
            {
                addProdutoBtn.Enabled = true;
                prodSelecionado = new Produto()
                {
                    Id = Convert.ToInt32(buscaProdutoDgv.Rows[e.RowIndex].Cells[0].Value),
                    Nome = buscaProdutoDgv.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    PrecoCusto = Convert.ToDouble(buscaProdutoDgv.Rows[e.RowIndex].Cells[2].Value, CultureInfo.InvariantCulture),
                    PrecoVenda = Convert.ToDouble(buscaProdutoDgv.Rows[e.RowIndex].Cells[3].Value, CultureInfo.InvariantCulture),
                };
            }
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
