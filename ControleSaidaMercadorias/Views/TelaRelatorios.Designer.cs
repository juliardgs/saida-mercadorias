namespace ControleSaidaMercadorias.Views
{
    partial class TelaRelatorios
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.relatoriosTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.relatorioReqPanel = new System.Windows.Forms.Panel();
            this.relatorioReqDgv = new System.Windows.Forms.DataGridView();
            this.datasPanel = new System.Windows.Forms.Panel();
            this.relatorioReqBtn = new System.Windows.Forms.Button();
            this.dataInicioDtp = new System.Windows.Forms.DateTimePicker();
            this.dataFimDtp = new System.Windows.Forms.DateTimePicker();
            this.dataFimLbl = new System.Windows.Forms.Label();
            this.dataInicioLbl = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.totalCustoLbl = new System.Windows.Forms.Label();
            this.totalCustoTxt = new System.Windows.Forms.TextBox();
            this.totalVendaTxt = new System.Windows.Forms.TextBox();
            this.totalVendaLbl = new System.Windows.Forms.Label();
            this.exportarBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.relatoriosTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.relatorioReqPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioReqDgv)).BeginInit();
            this.datasPanel.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // relatoriosTab
            // 
            this.relatoriosTab.Controls.Add(this.tabPage1);
            this.relatoriosTab.Controls.Add(this.tabPage2);
            this.relatoriosTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relatoriosTab.Location = new System.Drawing.Point(0, 0);
            this.relatoriosTab.Name = "relatoriosTab";
            this.relatoriosTab.SelectedIndex = 0;
            this.relatoriosTab.Size = new System.Drawing.Size(849, 512);
            this.relatoriosTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel);
            this.tabPage1.Controls.Add(this.relatorioReqPanel);
            this.tabPage1.Controls.Add(this.datasPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Relatório de Requisições";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Relatório de Saídas do Estoque";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // relatorioReqPanel
            // 
            this.relatorioReqPanel.Controls.Add(this.relatorioReqDgv);
            this.relatorioReqPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.relatorioReqPanel.Location = new System.Drawing.Point(3, 57);
            this.relatorioReqPanel.Name = "relatorioReqPanel";
            this.relatorioReqPanel.Size = new System.Drawing.Size(835, 287);
            this.relatorioReqPanel.TabIndex = 5;
            // 
            // relatorioReqDgv
            // 
            this.relatorioReqDgv.AllowUserToAddRows = false;
            this.relatorioReqDgv.AllowUserToDeleteRows = false;
            this.relatorioReqDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relatorioReqDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relatorioReqDgv.Location = new System.Drawing.Point(0, 0);
            this.relatorioReqDgv.MultiSelect = false;
            this.relatorioReqDgv.Name = "relatorioReqDgv";
            this.relatorioReqDgv.ReadOnly = true;
            this.relatorioReqDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.relatorioReqDgv.Size = new System.Drawing.Size(835, 287);
            this.relatorioReqDgv.TabIndex = 0;
            // 
            // datasPanel
            // 
            this.datasPanel.Controls.Add(this.relatorioReqBtn);
            this.datasPanel.Controls.Add(this.dataInicioDtp);
            this.datasPanel.Controls.Add(this.dataFimDtp);
            this.datasPanel.Controls.Add(this.dataFimLbl);
            this.datasPanel.Controls.Add(this.dataInicioLbl);
            this.datasPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.datasPanel.Location = new System.Drawing.Point(3, 3);
            this.datasPanel.Name = "datasPanel";
            this.datasPanel.Size = new System.Drawing.Size(835, 54);
            this.datasPanel.TabIndex = 4;
            // 
            // relatorioReqBtn
            // 
            this.relatorioReqBtn.Location = new System.Drawing.Point(661, 12);
            this.relatorioReqBtn.Name = "relatorioReqBtn";
            this.relatorioReqBtn.Size = new System.Drawing.Size(143, 23);
            this.relatorioReqBtn.TabIndex = 4;
            this.relatorioReqBtn.Text = "GERAR RELATÓRIO";
            this.relatorioReqBtn.UseVisualStyleBackColor = true;
            this.relatorioReqBtn.Click += new System.EventHandler(this.relatorioReqBtn_Click);
            // 
            // dataInicioDtp
            // 
            this.dataInicioDtp.Location = new System.Drawing.Point(84, 12);
            this.dataInicioDtp.Name = "dataInicioDtp";
            this.dataInicioDtp.Size = new System.Drawing.Size(228, 20);
            this.dataInicioDtp.TabIndex = 3;
            // 
            // dataFimDtp
            // 
            this.dataFimDtp.Location = new System.Drawing.Point(414, 12);
            this.dataFimDtp.Name = "dataFimDtp";
            this.dataFimDtp.Size = new System.Drawing.Size(226, 20);
            this.dataFimDtp.TabIndex = 2;
            // 
            // dataFimLbl
            // 
            this.dataFimLbl.AutoSize = true;
            this.dataFimLbl.Location = new System.Drawing.Point(350, 18);
            this.dataFimLbl.Name = "dataFimLbl";
            this.dataFimLbl.Size = new System.Drawing.Size(58, 13);
            this.dataFimLbl.TabIndex = 1;
            this.dataFimLbl.Text = "Data Final:";
            // 
            // dataInicioLbl
            // 
            this.dataInicioLbl.AutoSize = true;
            this.dataInicioLbl.Location = new System.Drawing.Point(15, 18);
            this.dataInicioLbl.Name = "dataInicioLbl";
            this.dataInicioLbl.Size = new System.Drawing.Size(63, 13);
            this.dataInicioLbl.TabIndex = 0;
            this.dataInicioLbl.Text = "Data Inicial:";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.limparBtn);
            this.panel.Controls.Add(this.exportarBtn);
            this.panel.Controls.Add(this.totalVendaTxt);
            this.panel.Controls.Add(this.totalVendaLbl);
            this.panel.Controls.Add(this.totalCustoTxt);
            this.panel.Controls.Add(this.totalCustoLbl);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(3, 344);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(835, 65);
            this.panel.TabIndex = 6;
            // 
            // totalCustoLbl
            // 
            this.totalCustoLbl.AutoSize = true;
            this.totalCustoLbl.Location = new System.Drawing.Point(15, 24);
            this.totalCustoLbl.Name = "totalCustoLbl";
            this.totalCustoLbl.Size = new System.Drawing.Size(64, 13);
            this.totalCustoLbl.TabIndex = 0;
            this.totalCustoLbl.Text = "Total Custo:";
            // 
            // totalCustoTxt
            // 
            this.totalCustoTxt.Enabled = false;
            this.totalCustoTxt.Location = new System.Drawing.Point(84, 21);
            this.totalCustoTxt.Name = "totalCustoTxt";
            this.totalCustoTxt.Size = new System.Drawing.Size(67, 20);
            this.totalCustoTxt.TabIndex = 1;
            // 
            // totalVendaTxt
            // 
            this.totalVendaTxt.Enabled = false;
            this.totalVendaTxt.Location = new System.Drawing.Point(254, 21);
            this.totalVendaTxt.Name = "totalVendaTxt";
            this.totalVendaTxt.Size = new System.Drawing.Size(67, 20);
            this.totalVendaTxt.TabIndex = 3;
            // 
            // totalVendaLbl
            // 
            this.totalVendaLbl.AutoSize = true;
            this.totalVendaLbl.Location = new System.Drawing.Point(185, 24);
            this.totalVendaLbl.Name = "totalVendaLbl";
            this.totalVendaLbl.Size = new System.Drawing.Size(68, 13);
            this.totalVendaLbl.TabIndex = 2;
            this.totalVendaLbl.Text = "Total Venda:";
            // 
            // exportarBtn
            // 
            this.exportarBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exportarBtn.Enabled = false;
            this.exportarBtn.Location = new System.Drawing.Point(720, 0);
            this.exportarBtn.Name = "exportarBtn";
            this.exportarBtn.Size = new System.Drawing.Size(115, 65);
            this.exportarBtn.TabIndex = 4;
            this.exportarBtn.Text = "EXPORTAR EXCEL";
            this.exportarBtn.UseVisualStyleBackColor = true;
            // 
            // limparBtn
            // 
            this.limparBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.limparBtn.Location = new System.Drawing.Point(601, 0);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(119, 65);
            this.limparBtn.TabIndex = 5;
            this.limparBtn.Text = "LIMPAR";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 65);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(601, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(720, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "EXPORTAR EXCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(254, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Venda:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(84, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Custo:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 287);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(835, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 54);
            this.panel3.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(661, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "GERAR RELATÓRIO";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(414, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Inicial:";
            // 
            // TelaRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.relatoriosTab);
            this.Name = "TelaRelatorios";
            this.Size = new System.Drawing.Size(849, 512);
            this.relatoriosTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.relatorioReqPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioReqDgv)).EndInit();
            this.datasPanel.ResumeLayout(false);
            this.datasPanel.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl relatoriosTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel relatorioReqPanel;
        private System.Windows.Forms.DataGridView relatorioReqDgv;
        private System.Windows.Forms.Panel datasPanel;
        private System.Windows.Forms.Button relatorioReqBtn;
        private System.Windows.Forms.DateTimePicker dataInicioDtp;
        private System.Windows.Forms.DateTimePicker dataFimDtp;
        private System.Windows.Forms.Label dataFimLbl;
        private System.Windows.Forms.Label dataInicioLbl;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox totalCustoTxt;
        private System.Windows.Forms.Label totalCustoLbl;
        private System.Windows.Forms.TextBox totalVendaTxt;
        private System.Windows.Forms.Label totalVendaLbl;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button exportarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
