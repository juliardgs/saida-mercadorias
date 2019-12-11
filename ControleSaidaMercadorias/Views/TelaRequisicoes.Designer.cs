namespace ControleSaidaMercadorias.Views
{
    partial class TelaRequisicoes
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
            this.requisicoesTab = new System.Windows.Forms.TabControl();
            this.cadastroReqTab = new System.Windows.Forms.TabPage();
            this.salvarBtnPanel = new System.Windows.Forms.Panel();
            this.salvarReqBtn = new System.Windows.Forms.Button();
            this.addExcBtnPanel = new System.Windows.Forms.Panel();
            this.precoCustoTotalTxt = new System.Windows.Forms.TextBox();
            this.precoCustoTotalLbl = new System.Windows.Forms.Label();
            this.excItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.itensReqlPanel = new System.Windows.Forms.Panel();
            this.itensReqDgv = new System.Windows.Forms.DataGridView();
            this.infoReqPanel = new System.Windows.Forms.Panel();
            this.nomeFuncLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.funReqCb = new System.Windows.Forms.ComboBox();
            this.dataLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCustoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requisicoesTab.SuspendLayout();
            this.cadastroReqTab.SuspendLayout();
            this.salvarBtnPanel.SuspendLayout();
            this.addExcBtnPanel.SuspendLayout();
            this.itensReqlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensReqDgv)).BeginInit();
            this.infoReqPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // requisicoesTab
            // 
            this.requisicoesTab.Controls.Add(this.cadastroReqTab);
            this.requisicoesTab.Controls.Add(this.tabPage2);
            this.requisicoesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requisicoesTab.Location = new System.Drawing.Point(0, 0);
            this.requisicoesTab.Name = "requisicoesTab";
            this.requisicoesTab.SelectedIndex = 0;
            this.requisicoesTab.Size = new System.Drawing.Size(849, 512);
            this.requisicoesTab.TabIndex = 0;
            // 
            // cadastroReqTab
            // 
            this.cadastroReqTab.Controls.Add(this.salvarBtnPanel);
            this.cadastroReqTab.Controls.Add(this.addExcBtnPanel);
            this.cadastroReqTab.Controls.Add(this.itensReqlPanel);
            this.cadastroReqTab.Controls.Add(this.infoReqPanel);
            this.cadastroReqTab.Location = new System.Drawing.Point(4, 22);
            this.cadastroReqTab.Name = "cadastroReqTab";
            this.cadastroReqTab.Padding = new System.Windows.Forms.Padding(3);
            this.cadastroReqTab.Size = new System.Drawing.Size(841, 486);
            this.cadastroReqTab.TabIndex = 0;
            this.cadastroReqTab.Text = "Cadastrar Requisição";
            this.cadastroReqTab.UseVisualStyleBackColor = true;
            // 
            // salvarBtnPanel
            // 
            this.salvarBtnPanel.Controls.Add(this.salvarReqBtn);
            this.salvarBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salvarBtnPanel.Location = new System.Drawing.Point(3, 431);
            this.salvarBtnPanel.Name = "salvarBtnPanel";
            this.salvarBtnPanel.Size = new System.Drawing.Size(835, 52);
            this.salvarBtnPanel.TabIndex = 7;
            // 
            // salvarReqBtn
            // 
            this.salvarReqBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.salvarReqBtn.Location = new System.Drawing.Point(620, 0);
            this.salvarReqBtn.Name = "salvarReqBtn";
            this.salvarReqBtn.Size = new System.Drawing.Size(215, 52);
            this.salvarReqBtn.TabIndex = 0;
            this.salvarReqBtn.Text = "SALVAR REQUISIÇÃO";
            this.salvarReqBtn.UseVisualStyleBackColor = true;
            // 
            // addExcBtnPanel
            // 
            this.addExcBtnPanel.Controls.Add(this.precoCustoTotalTxt);
            this.addExcBtnPanel.Controls.Add(this.precoCustoTotalLbl);
            this.addExcBtnPanel.Controls.Add(this.excItemBtn);
            this.addExcBtnPanel.Controls.Add(this.addItemBtn);
            this.addExcBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addExcBtnPanel.Location = new System.Drawing.Point(3, 328);
            this.addExcBtnPanel.Name = "addExcBtnPanel";
            this.addExcBtnPanel.Size = new System.Drawing.Size(835, 47);
            this.addExcBtnPanel.TabIndex = 6;
            // 
            // precoCustoTotalTxt
            // 
            this.precoCustoTotalTxt.Enabled = false;
            this.precoCustoTotalTxt.Location = new System.Drawing.Point(131, 14);
            this.precoCustoTotalTxt.Name = "precoCustoTotalTxt";
            this.precoCustoTotalTxt.Size = new System.Drawing.Size(98, 20);
            this.precoCustoTotalTxt.TabIndex = 3;
            // 
            // precoCustoTotalLbl
            // 
            this.precoCustoTotalLbl.AutoSize = true;
            this.precoCustoTotalLbl.Location = new System.Drawing.Point(15, 17);
            this.precoCustoTotalLbl.Name = "precoCustoTotalLbl";
            this.precoCustoTotalLbl.Size = new System.Drawing.Size(110, 13);
            this.precoCustoTotalLbl.TabIndex = 2;
            this.precoCustoTotalLbl.Text = "Preço Total de Custo:";
            // 
            // excItemBtn
            // 
            this.excItemBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.excItemBtn.Location = new System.Drawing.Point(620, 0);
            this.excItemBtn.Name = "excItemBtn";
            this.excItemBtn.Size = new System.Drawing.Size(107, 47);
            this.excItemBtn.TabIndex = 1;
            this.excItemBtn.Text = "EXCLUIR ITEM";
            this.excItemBtn.UseVisualStyleBackColor = true;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addItemBtn.Location = new System.Drawing.Point(727, 0);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(108, 47);
            this.addItemBtn.TabIndex = 0;
            this.addItemBtn.Text = "ADICIONAR ITEM";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // itensReqlPanel
            // 
            this.itensReqlPanel.Controls.Add(this.itensReqDgv);
            this.itensReqlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.itensReqlPanel.Location = new System.Drawing.Point(3, 99);
            this.itensReqlPanel.Name = "itensReqlPanel";
            this.itensReqlPanel.Size = new System.Drawing.Size(835, 229);
            this.itensReqlPanel.TabIndex = 5;
            // 
            // itensReqDgv
            // 
            this.itensReqDgv.AllowUserToAddRows = false;
            this.itensReqDgv.AllowUserToDeleteRows = false;
            this.itensReqDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensReqDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.qtde,
            this.precoCustoUnitario,
            this.subtotal});
            this.itensReqDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itensReqDgv.Location = new System.Drawing.Point(0, 0);
            this.itensReqDgv.MultiSelect = false;
            this.itensReqDgv.Name = "itensReqDgv";
            this.itensReqDgv.ReadOnly = true;
            this.itensReqDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itensReqDgv.Size = new System.Drawing.Size(835, 229);
            this.itensReqDgv.TabIndex = 0;
            // 
            // infoReqPanel
            // 
            this.infoReqPanel.Controls.Add(this.nomeFuncLbl);
            this.infoReqPanel.Controls.Add(this.dateTimePicker1);
            this.infoReqPanel.Controls.Add(this.funReqCb);
            this.infoReqPanel.Controls.Add(this.dataLbl);
            this.infoReqPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoReqPanel.Location = new System.Drawing.Point(3, 3);
            this.infoReqPanel.Name = "infoReqPanel";
            this.infoReqPanel.Size = new System.Drawing.Size(835, 96);
            this.infoReqPanel.TabIndex = 4;
            // 
            // nomeFuncLbl
            // 
            this.nomeFuncLbl.AutoSize = true;
            this.nomeFuncLbl.Location = new System.Drawing.Point(15, 19);
            this.nomeFuncLbl.Name = "nomeFuncLbl";
            this.nomeFuncLbl.Size = new System.Drawing.Size(130, 13);
            this.nomeFuncLbl.TabIndex = 0;
            this.nomeFuncLbl.Text = "Funcionário Responsável:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // funReqCb
            // 
            this.funReqCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.funReqCb.FormattingEnabled = true;
            this.funReqCb.Location = new System.Drawing.Point(151, 16);
            this.funReqCb.Name = "funReqCb";
            this.funReqCb.Size = new System.Drawing.Size(618, 21);
            this.funReqCb.TabIndex = 1;
            this.funReqCb.Enter += new System.EventHandler(this.funReqCb_Enter);
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Location = new System.Drawing.Point(15, 60);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(33, 13);
            this.dataLbl.TabIndex = 2;
            this.dataLbl.Text = "Data:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listar Requisições";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // qtde
            // 
            this.qtde.HeaderText = "QUANTIDADE";
            this.qtde.Name = "qtde";
            this.qtde.ReadOnly = true;
            // 
            // precoCustoUnitario
            // 
            this.precoCustoUnitario.HeaderText = "PREÇO DE CUSTO UNITÁRIO";
            this.precoCustoUnitario.Name = "precoCustoUnitario";
            this.precoCustoUnitario.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SUBTOTAL";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // TelaRequisicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requisicoesTab);
            this.Name = "TelaRequisicoes";
            this.Size = new System.Drawing.Size(849, 512);
            this.requisicoesTab.ResumeLayout(false);
            this.cadastroReqTab.ResumeLayout(false);
            this.salvarBtnPanel.ResumeLayout(false);
            this.addExcBtnPanel.ResumeLayout(false);
            this.addExcBtnPanel.PerformLayout();
            this.itensReqlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itensReqDgv)).EndInit();
            this.infoReqPanel.ResumeLayout(false);
            this.infoReqPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl requisicoesTab;
        private System.Windows.Forms.TabPage cadastroReqTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.ComboBox funReqCb;
        private System.Windows.Forms.Label nomeFuncLbl;
        private System.Windows.Forms.Panel addExcBtnPanel;
        private System.Windows.Forms.Button excItemBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Panel itensReqlPanel;
        private System.Windows.Forms.Panel infoReqPanel;
        private System.Windows.Forms.Panel salvarBtnPanel;
        private System.Windows.Forms.Button salvarReqBtn;
        private System.Windows.Forms.TextBox precoCustoTotalTxt;
        private System.Windows.Forms.Label precoCustoTotalLbl;
        public System.Windows.Forms.DataGridView itensReqDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCustoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}
