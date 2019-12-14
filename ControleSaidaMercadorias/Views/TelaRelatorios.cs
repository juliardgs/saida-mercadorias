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
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

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

        private void exportarBtn_Click(object sender, EventArgs e) //abre uma planilha no excel mostrando os dados do datagridview
        {
            if (relatorioReqDgv.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < relatorioReqDgv.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = relatorioReqDgv.Columns[i - 1].HeaderText;
                    }
                    
                    for (int i = 0; i < relatorioReqDgv.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < relatorioReqDgv.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = relatorioReqDgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    XcelApp.Cells[relatorioReqDgv.Rows.Count + 3, 1] = "Total Custo:";
                    XcelApp.Cells[relatorioReqDgv.Rows.Count + 3, 2] = totalCustoTxt.Text;

                    XcelApp.Cells[relatorioReqDgv.Rows.Count + 4, 1] = "Total Venda:";
                    XcelApp.Cells[relatorioReqDgv.Rows.Count + 4, 2] = totalVendaTxt.Text;

                    XcelApp.Columns.AutoFit();
                    
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }
    }
}
