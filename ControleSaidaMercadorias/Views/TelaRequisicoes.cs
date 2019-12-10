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

        private void TelaRequisicoes_Load(object sender, EventArgs e)
        {
            funReqCb.DataSource = dal.CarregarFuncionarios();
            funReqCb.DisplayMember = "ID_NOME";
            funReqCb.ValueMember = "id";
        }
    }
}
