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
    public partial class AltRequisicao : Form
    {
        private TelaRequisicoes telaRequisicoes;
        private RequisicaoDAL dal = new RequisicaoDAL();

        public AltRequisicao()
        {
            InitializeComponent();
        }

        public AltRequisicao(TelaRequisicoes telaReq, Requisicao req)
        {
            InitializeComponent();
            telaRequisicoes = telaReq;
            telaRequisicoes.CarregarFuncionarios(funcReqCb);
            funcReqCb.SelectedValue = req.IdFuncionario;
            dataReqDtp.Value = req.Data;
            itensReqDgv.DataSource = dal.BuscarItensReq(req.Id);
            precoCustoTotalTxt.Text = req.PrecoCustoTotal.ToString();
        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
