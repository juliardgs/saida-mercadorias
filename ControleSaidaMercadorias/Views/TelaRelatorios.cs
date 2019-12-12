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
    public partial class TelaRelatorios : UserControl
    {
        RelatorioDAL dal = new RelatorioDAL();
        public TelaRelatorios()
        {
            InitializeComponent();
        }

        private void relatorioReqBtn_Click(object sender, EventArgs e)
        {
            if(dataInicioDtp.Value != null && dataFimDtp.Value != null && (relatorioReqRb.Checked || relatorioEstoqueRb.Checked))
            {
                if (relatorioReqRb.Checked)
                {
                    relatorioReqDgv.DataSource = dal.Relatorios(dataInicioDtp.Value, dataFimDtp.Value, 1);
                }
                if (relatorioEstoqueRb.Checked)
                {
                    relatorioReqDgv.DataSource = dal.Relatorios(dataInicioDtp.Value, dataFimDtp.Value, 2);
                }
                CalcularTotalReq();
            }
            else
            {
                MessageBox.Show("É necessario preencher todos os campos com valores válidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (relatorioReqDgv.Rows.Count > 0)
            {
                exportarBtn.Enabled = true;
            }
        }

        private void CalcularTotalReq()
        {
            double totalCusto = 0;
            double totalVenda = 0;

            foreach (DataGridViewRow linha in relatorioReqDgv.Rows)
            {
                totalCusto += Convert.ToDouble(linha.Cells[2].Value);
                totalVenda += Convert.ToDouble(linha.Cells[3].Value);
            }
            totalCustoTxt.Text = totalCusto.ToString();
            totalVendaTxt.Text = totalVenda.ToString();
        }

        private void LimparControles()
        {
            dataInicioDtp.Value = DateTime.Now;
            dataFimDtp.Value = DateTime.Now;
            relatorioReqDgv.DataSource = null;
            totalCustoTxt.Text = "";
            totalVendaTxt.Text = "";
            relatorioEstoqueRb.Checked = false;
            relatorioReqRb.Checked = false;
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            LimparControles();
        }
    }
}
