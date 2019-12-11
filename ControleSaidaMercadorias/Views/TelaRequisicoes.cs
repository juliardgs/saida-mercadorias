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

namespace ControleSaidaMercadorias.Views
{
    public partial class TelaRequisicoes : UserControl
    {
        private FuncionarioDAL dal = new FuncionarioDAL();
        public TelaRequisicoes()
        {
            InitializeComponent();
        }

        private void funReqCb_Enter(object sender, EventArgs e)
        {
            //colocar função pra autocompletar
            var dados = dal.CarregarFuncionarios();
            funReqCb.DataSource = dados;
            funReqCb.DisplayMember = "ID_NOME";
            funReqCb.ValueMember = "id";
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            AddProduto addProduto = new AddProduto(this);
            addProduto.Show();
        }
    }
}
