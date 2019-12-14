namespace ControleSaidaMercadorias.Views
{
    partial class AltProduto
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
            this.infoProdPanel = new System.Windows.Forms.Panel();
            this.precoVendaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precoCustoTxt = new System.Windows.Forms.TextBox();
            this.precoCustoLbl = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaProdSimplesPanel = new System.Windows.Forms.Panel();
            this.listaProdSimplesDgv = new System.Windows.Forms.DataGridView();
            this.addExcBtnPanel = new System.Windows.Forms.Panel();
            this.excProdSimplesBtn = new System.Windows.Forms.Button();
            this.addProdSimplesBtn = new System.Windows.Forms.Button();
            this.salvarBtnPanel = new System.Windows.Forms.Panel();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.infoProdPanel.SuspendLayout();
            this.listaProdSimplesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProdSimplesDgv)).BeginInit();
            this.addExcBtnPanel.SuspendLayout();
            this.salvarBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoProdPanel
            // 
            this.infoProdPanel.Controls.Add(this.precoVendaTxt);
            this.infoProdPanel.Controls.Add(this.label2);
            this.infoProdPanel.Controls.Add(this.precoCustoTxt);
            this.infoProdPanel.Controls.Add(this.precoCustoLbl);
            this.infoProdPanel.Controls.Add(this.nomeTxt);
            this.infoProdPanel.Controls.Add(this.label1);
            this.infoProdPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoProdPanel.Location = new System.Drawing.Point(0, 0);
            this.infoProdPanel.Name = "infoProdPanel";
            this.infoProdPanel.Size = new System.Drawing.Size(526, 112);
            this.infoProdPanel.TabIndex = 0;
            // 
            // precoVendaTxt
            // 
            this.precoVendaTxt.Location = new System.Drawing.Point(427, 52);
            this.precoVendaTxt.MaxLength = 7;
            this.precoVendaTxt.Name = "precoVendaTxt";
            this.precoVendaTxt.Size = new System.Drawing.Size(65, 20);
            this.precoVendaTxt.TabIndex = 7;
            this.precoVendaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precoVendaTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço de Venda:";
            // 
            // precoCustoTxt
            // 
            this.precoCustoTxt.Location = new System.Drawing.Point(101, 52);
            this.precoCustoTxt.MaxLength = 7;
            this.precoCustoTxt.Name = "precoCustoTxt";
            this.precoCustoTxt.Size = new System.Drawing.Size(65, 20);
            this.precoCustoTxt.TabIndex = 5;
            this.precoCustoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precoCustoTxt_KeyPress);
            // 
            // precoCustoLbl
            // 
            this.precoCustoLbl.AutoSize = true;
            this.precoCustoLbl.Location = new System.Drawing.Point(12, 55);
            this.precoCustoLbl.Name = "precoCustoLbl";
            this.precoCustoLbl.Size = new System.Drawing.Size(83, 13);
            this.precoCustoLbl.TabIndex = 4;
            this.precoCustoLbl.Text = "Preço de Custo:";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(56, 15);
            this.nomeTxt.MaxLength = 100;
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(440, 20);
            this.nomeTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // listaProdSimplesPanel
            // 
            this.listaProdSimplesPanel.Controls.Add(this.listaProdSimplesDgv);
            this.listaProdSimplesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listaProdSimplesPanel.Location = new System.Drawing.Point(0, 112);
            this.listaProdSimplesPanel.Name = "listaProdSimplesPanel";
            this.listaProdSimplesPanel.Size = new System.Drawing.Size(526, 179);
            this.listaProdSimplesPanel.TabIndex = 1;
            this.listaProdSimplesPanel.Visible = false;
            // 
            // listaProdSimplesDgv
            // 
            this.listaProdSimplesDgv.AllowUserToAddRows = false;
            this.listaProdSimplesDgv.AllowUserToDeleteRows = false;
            this.listaProdSimplesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProdSimplesDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaProdSimplesDgv.Location = new System.Drawing.Point(0, 0);
            this.listaProdSimplesDgv.MultiSelect = false;
            this.listaProdSimplesDgv.Name = "listaProdSimplesDgv";
            this.listaProdSimplesDgv.ReadOnly = true;
            this.listaProdSimplesDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaProdSimplesDgv.Size = new System.Drawing.Size(526, 179);
            this.listaProdSimplesDgv.TabIndex = 0;
            this.listaProdSimplesDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaProdSimplesDgv_CellClick);
            this.listaProdSimplesDgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.listaProdSimplesDgv_RowsAdded);
            this.listaProdSimplesDgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.listaProdSimplesDgv_RowsRemoved);
            // 
            // addExcBtnPanel
            // 
            this.addExcBtnPanel.Controls.Add(this.excProdSimplesBtn);
            this.addExcBtnPanel.Controls.Add(this.addProdSimplesBtn);
            this.addExcBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addExcBtnPanel.Location = new System.Drawing.Point(0, 291);
            this.addExcBtnPanel.Name = "addExcBtnPanel";
            this.addExcBtnPanel.Size = new System.Drawing.Size(526, 41);
            this.addExcBtnPanel.TabIndex = 2;
            this.addExcBtnPanel.Visible = false;
            // 
            // excProdSimplesBtn
            // 
            this.excProdSimplesBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.excProdSimplesBtn.Enabled = false;
            this.excProdSimplesBtn.Location = new System.Drawing.Point(321, 0);
            this.excProdSimplesBtn.Name = "excProdSimplesBtn";
            this.excProdSimplesBtn.Size = new System.Drawing.Size(100, 41);
            this.excProdSimplesBtn.TabIndex = 7;
            this.excProdSimplesBtn.Text = "EXCLUIR ITEM";
            this.excProdSimplesBtn.UseVisualStyleBackColor = true;
            this.excProdSimplesBtn.Click += new System.EventHandler(this.excProdSimplesBtn_Click);
            // 
            // addProdSimplesBtn
            // 
            this.addProdSimplesBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addProdSimplesBtn.Location = new System.Drawing.Point(421, 0);
            this.addProdSimplesBtn.Name = "addProdSimplesBtn";
            this.addProdSimplesBtn.Size = new System.Drawing.Size(105, 41);
            this.addProdSimplesBtn.TabIndex = 6;
            this.addProdSimplesBtn.Text = "ADICIONAR ITEM";
            this.addProdSimplesBtn.UseVisualStyleBackColor = true;
            this.addProdSimplesBtn.Click += new System.EventHandler(this.addProdSimplesBtn_Click);
            // 
            // salvarBtnPanel
            // 
            this.salvarBtnPanel.Controls.Add(this.salvarBtn);
            this.salvarBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salvarBtnPanel.Location = new System.Drawing.Point(0, 334);
            this.salvarBtnPanel.Name = "salvarBtnPanel";
            this.salvarBtnPanel.Size = new System.Drawing.Size(526, 53);
            this.salvarBtnPanel.TabIndex = 3;
            // 
            // salvarBtn
            // 
            this.salvarBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.salvarBtn.Location = new System.Drawing.Point(451, 0);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(75, 53);
            this.salvarBtn.TabIndex = 0;
            this.salvarBtn.Text = "SALVAR";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // AltProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 387);
            this.Controls.Add(this.salvarBtnPanel);
            this.Controls.Add(this.addExcBtnPanel);
            this.Controls.Add(this.listaProdSimplesPanel);
            this.Controls.Add(this.infoProdPanel);
            this.Name = "AltProduto";
            this.Text = "Alterar Produto";
            this.infoProdPanel.ResumeLayout(false);
            this.infoProdPanel.PerformLayout();
            this.listaProdSimplesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaProdSimplesDgv)).EndInit();
            this.addExcBtnPanel.ResumeLayout(false);
            this.salvarBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoProdPanel;
        private System.Windows.Forms.Label precoCustoLbl;
        private System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel listaProdSimplesPanel;
        private System.Windows.Forms.Panel addExcBtnPanel;
        private System.Windows.Forms.Panel salvarBtnPanel;
        private System.Windows.Forms.TextBox precoVendaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precoCustoTxt;
        private System.Windows.Forms.Button excProdSimplesBtn;
        private System.Windows.Forms.Button addProdSimplesBtn;
        private System.Windows.Forms.Button salvarBtn;
        public System.Windows.Forms.DataGridView listaProdSimplesDgv;
    }
}