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
            string[] linha = { prodSelecionado.Id.ToString(), prodSelecionado.Nome, prodSelecionado.Quantidade.ToString(), prodSelecionado.PrecoCusto.ToString(), prodSelecionado.PrecoVenda.ToString() };
            var item = new ListViewItem(linha);
            telaProdutos.listaProdSimplesLv.Items.Add(item);
            this.Close();
        }

        private void buscarProdutoBtn_Click(object sender, EventArgs e)
        {
            DataTable dados = dal.BuscarProduto(buscarProdutoTxt.Text);
            buscaProdutoDgv.DataSource = dados;
        }

        private void buscaProdutoDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addProdutoBtn.Enabled = true;
            prodSelecionado = new Produto()
            {
                Id = Convert.ToInt32(buscaProdutoDgv.Rows[e.RowIndex].Cells[0].Value),
                Nome = buscaProdutoDgv.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Quantidade = 10,
                PrecoCusto = Convert.ToDouble(buscaProdutoDgv.Rows[e.RowIndex].Cells[2].Value, CultureInfo.InvariantCulture),
                PrecoVenda = Convert.ToDouble(buscaProdutoDgv.Rows[e.RowIndex].Cells[3].Value, CultureInfo.InvariantCulture),
            };
                
        }
    }
}
