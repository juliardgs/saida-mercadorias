namespace ControleSaidaMercadorias.Views
{
    partial class AltRequisicao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoReqPanel = new System.Windows.Forms.Panel();
            this.funcLbl = new System.Windows.Forms.Label();
            this.funcReqCb = new System.Windows.Forms.ComboBox();
            this.dataLbl = new System.Windows.Forms.Label();
            this.dataReqDtp = new System.Windows.Forms.DateTimePicker();
            this.itensReqPanel = new System.Windows.Forms.Panel();
            this.itensReqDgv = new System.Windows.Forms.DataGridView();
            this.addExcPanel = new System.Windows.Forms.Panel();
            this.addProdBtn = new System.Windows.Forms.Button();
            this.excProdBtn = new System.Windows.Forms.Button();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.salvarBtnPanel = new System.Windows.Forms.Panel();
            this.precoCustoTotalLbl = new System.Windows.Forms.Label();
            this.precoCustoTotalTxt = new System.Windows.Forms.TextBox();
            this.infoReqPanel.SuspendLayout();
            this.itensReqPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensReqDgv)).BeginInit();
            this.addExcPanel.SuspendLayout();
            this.salvarBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoReqPanel
            // 
            this.infoReqPanel.Controls.Add(this.dataReqDtp);
            this.infoReqPanel.Controls.Add(this.dataLbl);
            this.infoReqPanel.Controls.Add(this.funcReqCb);
            this.infoReqPanel.Controls.Add(this.funcLbl);
            this.infoReqPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoReqPanel.Location = new System.Drawing.Point(0, 0);
            this.infoReqPanel.Name = "infoReqPanel";
            this.infoReqPanel.Size = new System.Drawing.Size(597, 76);
            this.infoReqPanel.TabIndex = 0;
            // 
            // funcLbl
            // 
            this.funcLbl.AutoSize = true;
            this.funcLbl.Location = new System.Drawing.Point(12, 18);
            this.funcLbl.Name = "funcLbl";
            this.funcLbl.Size = new System.Drawing.Size(130, 13);
            this.funcLbl.TabIndex = 0;
            this.funcLbl.Text = "Funcionário Responsável:";
            // 
            // funcReqCb
            // 
            this.funcReqCb.FormattingEnabled = true;
            this.funcReqCb.Location = new System.Drawing.Point(148, 15);
            this.funcReqCb.Name = "funcReqCb";
            this.funcReqCb.Size = new System.Drawing.Size(300, 21);
            this.funcReqCb.TabIndex = 1;
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Location = new System.Drawing.Point(12, 44);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(33, 13);
            this.dataLbl.TabIndex = 2;
            this.dataLbl.Text = "Data:";
            // 
            // dataReqDtp
            // 
            this.dataReqDtp.Location = new System.Drawing.Point(51, 42);
            this.dataReqDtp.Name = "dataReqDtp";
            this.dataReqDtp.Size = new System.Drawing.Size(200, 20);
            this.dataReqDtp.TabIndex = 3;
            // 
            // itensReqPanel
            // 
            this.itensReqPanel.Controls.Add(this.itensReqDgv);
            this.itensReqPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.itensReqPanel.Location = new System.Drawing.Point(0, 76);
            this.itensReqPanel.Name = "itensReqPanel";
            this.itensReqPanel.Size = new System.Drawing.Size(597, 228);
            this.itensReqPanel.TabIndex = 1;
            // 
            // itensReqDgv
            // 
            this.itensReqDgv.AllowUserToAddRows = false;
            this.itensReqDgv.AllowUserToDeleteRows = false;
            this.itensReqDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensReqDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itensReqDgv.Location = new System.Drawing.Point(0, 0);
            this.itensReqDgv.MultiSelect = false;
            this.itensReqDgv.Name = "itensReqDgv";
            this.itensReqDgv.ReadOnly = true;
            this.itensReqDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itensReqDgv.Size = new System.Drawing.Size(597, 228);
            this.itensReqDgv.TabIndex = 0;
            this.itensReqDgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.itensReqDgv_RowsAdded);
            this.itensReqDgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.itensReqDgv_RowsRemoved);
            // 
            // addExcPanel
            // 
            this.addExcPanel.Controls.Add(this.precoCustoTotalTxt);
            this.addExcPanel.Controls.Add(this.precoCustoTotalLbl);
            this.addExcPanel.Controls.Add(this.excProdBtn);
            this.addExcPanel.Controls.Add(this.addProdBtn);
            this.addExcPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addExcPanel.Location = new System.Drawing.Point(0, 304);
            this.addExcPanel.Name = "addExcPanel";
            this.addExcPanel.Size = new System.Drawing.Size(597, 48);
            this.addExcPanel.TabIndex = 2;
            // 
            // addProdBtn
            // 
            this.addProdBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addProdBtn.Location = new System.Drawing.Point(457, 0);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.Size = new System.Drawing.Size(140, 48);
            this.addProdBtn.TabIndex = 0;
            this.addProdBtn.Text = "ADICIONAR PRODUTO\r\n";
            this.addProdBtn.UseVisualStyleBackColor = true;
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // excProdBtn
            // 
            this.excProdBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.excProdBtn.Location = new System.Drawing.Point(327, 0);
            this.excProdBtn.Name = "excProdBtn";
            this.excProdBtn.Size = new System.Drawing.Size(130, 48);
            this.excProdBtn.TabIndex = 1;
            this.excProdBtn.Text = "EXCLUIR PRODUTO";
            this.excProdBtn.UseVisualStyleBackColor = true;
            // 
            // salvarBtn
            // 
            this.salvarBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.salvarBtn.Location = new System.Drawing.Point(0, 0);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 58);
            this.salvarBtn.TabIndex = 1;
            this.salvarBtn.Text = "SALVAR";
            this.salvarBtn.UseVisualStyleBackColor = true;
            // 
            // salvarBtnPanel
            // 
            this.salvarBtnPanel.Controls.Add(this.salvarBtn);
            this.salvarBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.salvarBtnPanel.Location = new System.Drawing.Point(0, 352);
            this.salvarBtnPanel.Name = "salvarBtnPanel";
            this.salvarBtnPanel.Size = new System.Drawing.Size(597, 58);
            this.salvarBtnPanel.TabIndex = 3;
            // 
            // precoCustoTotalLbl
            // 
            this.precoCustoTotalLbl.AutoSize = true;
            this.precoCustoTotalLbl.Location = new System.Drawing.Point(12, 18);
            this.precoCustoTotalLbl.Name = "precoCustoTotalLbl";
            this.precoCustoTotalLbl.Size = new System.Drawing.Size(110, 13);
            this.precoCustoTotalLbl.TabIndex = 3;
            this.precoCustoTotalLbl.Text = "Preço de Custo Total:";
            // 
            // precoCustoTotalTxt
            // 
            this.precoCustoTotalTxt.Enabled = false;
            this.precoCustoTotalTxt.Location = new System.Drawing.Point(128, 15);
            this.precoCustoTotalTxt.Name = "precoCustoTotalTxt";
            this.precoCustoTotalTxt.Size = new System.Drawing.Size(54, 20);
            this.precoCustoTotalTxt.TabIndex = 4;
            // 
            // AltRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 422);
            this.Controls.Add(this.salvarBtnPanel);
            this.Controls.Add(this.addExcPanel);
            this.Controls.Add(this.itensReqPanel);
            this.Controls.Add(this.infoReqPanel);
            this.Name = "AltRequisicao";
            this.Text = "Alterar Requisição";
            this.infoReqPanel.ResumeLayout(false);
            this.infoReqPanel.PerformLayout();
            this.itensReqPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itensReqDgv)).EndInit();
            this.addExcPanel.ResumeLayout(false);
            this.addExcPanel.PerformLayout();
            this.salvarBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoReqPanel;
        private System.Windows.Forms.DateTimePicker dataReqDtp;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.ComboBox funcReqCb;
        private System.Windows.Forms.Label funcLbl;
        private System.Windows.Forms.Panel itensReqPanel;
        public System.Windows.Forms.DataGridView itensReqDgv;
        private System.Windows.Forms.Panel addExcPanel;
        private System.Windows.Forms.Button excProdBtn;
        private System.Windows.Forms.Button addProdBtn;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.TextBox precoCustoTotalTxt;
        private System.Windows.Forms.Label precoCustoTotalLbl;
        private System.Windows.Forms.Panel salvarBtnPanel;
    }
}