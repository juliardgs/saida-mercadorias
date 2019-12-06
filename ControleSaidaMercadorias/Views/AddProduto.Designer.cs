namespace ControleSaidaMercadorias.Views
{
    partial class AddProduto
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
            this.buscarProdPanel = new System.Windows.Forms.Panel();
            this.buscarProdutoBtn = new System.Windows.Forms.Button();
            this.buscarProdutoTxt = new System.Windows.Forms.TextBox();
            this.buscarLbl = new System.Windows.Forms.Label();
            this.dgvPanel = new System.Windows.Forms.Panel();
            this.buscaProdutoDgv = new System.Windows.Forms.DataGridView();
            this.limparPanel = new System.Windows.Forms.Panel();
            this.qtdeTxt = new System.Windows.Forms.TextBox();
            this.qtdeLbl = new System.Windows.Forms.Label();
            this.addProdutoBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.buscarProdPanel.SuspendLayout();
            this.dgvPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaProdutoDgv)).BeginInit();
            this.limparPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarProdPanel
            // 
            this.buscarProdPanel.Controls.Add(this.buscarProdutoBtn);
            this.buscarProdPanel.Controls.Add(this.buscarProdutoTxt);
            this.buscarProdPanel.Controls.Add(this.buscarLbl);
            this.buscarProdPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buscarProdPanel.Location = new System.Drawing.Point(0, 0);
            this.buscarProdPanel.Name = "buscarProdPanel";
            this.buscarProdPanel.Size = new System.Drawing.Size(504, 69);
            this.buscarProdPanel.TabIndex = 0;
            // 
            // buscarProdutoBtn
            // 
            this.buscarProdutoBtn.Location = new System.Drawing.Point(408, 14);
            this.buscarProdutoBtn.Name = "buscarProdutoBtn";
            this.buscarProdutoBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarProdutoBtn.TabIndex = 2;
            this.buscarProdutoBtn.Text = "BUSCAR";
            this.buscarProdutoBtn.UseVisualStyleBackColor = true;
            this.buscarProdutoBtn.Click += new System.EventHandler(this.buscarProdutoBtn_Click);
            // 
            // buscarProdutoTxt
            // 
            this.buscarProdutoTxt.Location = new System.Drawing.Point(108, 16);
            this.buscarProdutoTxt.MaxLength = 100;
            this.buscarProdutoTxt.Name = "buscarProdutoTxt";
            this.buscarProdutoTxt.Size = new System.Drawing.Size(291, 20);
            this.buscarProdutoTxt.TabIndex = 1;
            // 
            // buscarLbl
            // 
            this.buscarLbl.AutoSize = true;
            this.buscarLbl.Location = new System.Drawing.Point(12, 19);
            this.buscarLbl.Name = "buscarLbl";
            this.buscarLbl.Size = new System.Drawing.Size(90, 13);
            this.buscarLbl.TabIndex = 0;
            this.buscarLbl.Text = "Buscar por nome:";
            // 
            // dgvPanel
            // 
            this.dgvPanel.Controls.Add(this.buscaProdutoDgv);
            this.dgvPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPanel.Location = new System.Drawing.Point(0, 69);
            this.dgvPanel.Name = "dgvPanel";
            this.dgvPanel.Size = new System.Drawing.Size(504, 216);
            this.dgvPanel.TabIndex = 1;
            // 
            // buscaProdutoDgv
            // 
            this.buscaProdutoDgv.AllowUserToAddRows = false;
            this.buscaProdutoDgv.AllowUserToDeleteRows = false;
            this.buscaProdutoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscaProdutoDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscaProdutoDgv.Location = new System.Drawing.Point(0, 0);
            this.buscaProdutoDgv.MultiSelect = false;
            this.buscaProdutoDgv.Name = "buscaProdutoDgv";
            this.buscaProdutoDgv.ReadOnly = true;
            this.buscaProdutoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscaProdutoDgv.Size = new System.Drawing.Size(504, 216);
            this.buscaProdutoDgv.TabIndex = 0;
            this.buscaProdutoDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buscaProdutoDgv_CellClick);
            // 
            // limparPanel
            // 
            this.limparPanel.Controls.Add(this.qtdeTxt);
            this.limparPanel.Controls.Add(this.qtdeLbl);
            this.limparPanel.Controls.Add(this.addProdutoBtn);
            this.limparPanel.Controls.Add(this.limparBtn);
            this.limparPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.limparPanel.Location = new System.Drawing.Point(0, 285);
            this.limparPanel.Name = "limparPanel";
            this.limparPanel.Size = new System.Drawing.Size(504, 60);
            this.limparPanel.TabIndex = 2;
            // 
            // qtdeTxt
            // 
            this.qtdeTxt.Location = new System.Drawing.Point(83, 18);
            this.qtdeTxt.MaxLength = 3;
            this.qtdeTxt.Name = "qtdeTxt";
            this.qtdeTxt.Size = new System.Drawing.Size(29, 20);
            this.qtdeTxt.TabIndex = 3;
            this.qtdeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtdeTxt_KeyPress);
            // 
            // qtdeLbl
            // 
            this.qtdeLbl.AutoSize = true;
            this.qtdeLbl.Location = new System.Drawing.Point(12, 21);
            this.qtdeLbl.Name = "qtdeLbl";
            this.qtdeLbl.Size = new System.Drawing.Size(65, 13);
            this.qtdeLbl.TabIndex = 2;
            this.qtdeLbl.Text = "Quantidade:";
            // 
            // addProdutoBtn
            // 
            this.addProdutoBtn.Enabled = false;
            this.addProdutoBtn.Location = new System.Drawing.Point(408, 16);
            this.addProdutoBtn.Name = "addProdutoBtn";
            this.addProdutoBtn.Size = new System.Drawing.Size(75, 23);
            this.addProdutoBtn.TabIndex = 1;
            this.addProdutoBtn.Text = "ADICIONAR";
            this.addProdutoBtn.UseVisualStyleBackColor = true;
            this.addProdutoBtn.Click += new System.EventHandler(this.addProdutoBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.Location = new System.Drawing.Point(324, 16);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 23);
            this.limparBtn.TabIndex = 0;
            this.limparBtn.Text = "LIMPAR";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // AddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 348);
            this.Controls.Add(this.limparPanel);
            this.Controls.Add(this.dgvPanel);
            this.Controls.Add(this.buscarProdPanel);
            this.Name = "AddProduto";
            this.Text = "Adicionar Produto Simples";
            this.buscarProdPanel.ResumeLayout(false);
            this.buscarProdPanel.PerformLayout();
            this.dgvPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buscaProdutoDgv)).EndInit();
            this.limparPanel.ResumeLayout(false);
            this.limparPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buscarProdPanel;
        private System.Windows.Forms.Button buscarProdutoBtn;
        private System.Windows.Forms.TextBox buscarProdutoTxt;
        private System.Windows.Forms.Label buscarLbl;
        private System.Windows.Forms.Panel dgvPanel;
        private System.Windows.Forms.DataGridView buscaProdutoDgv;
        private System.Windows.Forms.Panel limparPanel;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button addProdutoBtn;
        private System.Windows.Forms.TextBox qtdeTxt;
        private System.Windows.Forms.Label qtdeLbl;
    }
}