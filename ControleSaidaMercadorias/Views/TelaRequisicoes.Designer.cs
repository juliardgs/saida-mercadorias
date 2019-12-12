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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCustoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoReqPanel = new System.Windows.Forms.Panel();
            this.nomeFuncLbl = new System.Windows.Forms.Label();
            this.dataReqDtp = new System.Windows.Forms.DateTimePicker();
            this.funReqCb = new System.Windows.Forms.ComboBox();
            this.dataLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buscarReqPanel = new System.Windows.Forms.Panel();
            this.buscaLbl = new System.Windows.Forms.Label();
            this.buscaFuncCb = new System.Windows.Forms.ComboBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.listaReqPanel = new System.Windows.Forms.Panel();
            this.altExcPanel = new System.Windows.Forms.Panel();
            this.buscaReqDgv = new System.Windows.Forms.DataGridView();
            this.alterarReqBtn = new System.Windows.Forms.Button();
            this.excReqBtn = new System.Windows.Forms.Button();
            this.requisicoesTab.SuspendLayout();
            this.cadastroReqTab.SuspendLayout();
            this.salvarBtnPanel.SuspendLayout();
            this.addExcBtnPanel.SuspendLayout();
            this.itensReqlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensReqDgv)).BeginInit();
            this.infoReqPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.buscarReqPanel.SuspendLayout();
            this.listaReqPanel.SuspendLayout();
            this.altExcPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buscaReqDgv)).BeginInit();
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
            this.salvarReqBtn.Click += new System.EventHandler(this.salvarReqBtn_Click);
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
            this.excItemBtn.Enabled = false;
            this.excItemBtn.Location = new System.Drawing.Point(620, 0);
            this.excItemBtn.Name = "excItemBtn";
            this.excItemBtn.Size = new System.Drawing.Size(107, 47);
            this.excItemBtn.TabIndex = 1;
            this.excItemBtn.Text = "EXCLUIR ITEM";
            this.excItemBtn.UseVisualStyleBackColor = true;
            this.excItemBtn.Click += new System.EventHandler(this.excItemBtn_Click);
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
            this.itensReqDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itensReqDgv_CellClick);
            this.itensReqDgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.itensReqDgv_RowsAdded);
            this.itensReqDgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.itensReqDgv_RowsRemoved);
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
            // infoReqPanel
            // 
            this.infoReqPanel.Controls.Add(this.nomeFuncLbl);
            this.infoReqPanel.Controls.Add(this.dataReqDtp);
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
            // dataReqDtp
            // 
            this.dataReqDtp.Location = new System.Drawing.Point(54, 54);
            this.dataReqDtp.Name = "dataReqDtp";
            this.dataReqDtp.Size = new System.Drawing.Size(236, 20);
            this.dataReqDtp.TabIndex = 3;
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
            this.tabPage2.Controls.Add(this.altExcPanel);
            this.tabPage2.Controls.Add(this.listaReqPanel);
            this.tabPage2.Controls.Add(this.buscarReqPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listar Requisições";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buscarReqPanel
            // 
            this.buscarReqPanel.Controls.Add(this.buscarBtn);
            this.buscarReqPanel.Controls.Add(this.buscaLbl);
            this.buscarReqPanel.Controls.Add(this.buscaFuncCb);
            this.buscarReqPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buscarReqPanel.Location = new System.Drawing.Point(3, 3);
            this.buscarReqPanel.Name = "buscarReqPanel";
            this.buscarReqPanel.Size = new System.Drawing.Size(835, 50);
            this.buscarReqPanel.TabIndex = 0;
            // 
            // buscaLbl
            // 
            this.buscaLbl.AutoSize = true;
            this.buscaLbl.Location = new System.Drawing.Point(16, 15);
            this.buscaLbl.Name = "buscaLbl";
            this.buscaLbl.Size = new System.Drawing.Size(119, 13);
            this.buscaLbl.TabIndex = 2;
            this.buscaLbl.Text = "Buscar por Funcionário:";
            // 
            // buscaFuncCb
            // 
            this.buscaFuncCb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.buscaFuncCb.FormattingEnabled = true;
            this.buscaFuncCb.Location = new System.Drawing.Point(152, 12);
            this.buscaFuncCb.Name = "buscaFuncCb";
            this.buscaFuncCb.Size = new System.Drawing.Size(561, 21);
            this.buscaFuncCb.TabIndex = 3;
            this.buscaFuncCb.Enter += new System.EventHandler(this.buscaFuncCb_Enter);
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(731, 10);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 4;
            this.buscarBtn.Text = "BUSCAR";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // listaReqPanel
            // 
            this.listaReqPanel.Controls.Add(this.buscaReqDgv);
            this.listaReqPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listaReqPanel.Location = new System.Drawing.Point(3, 53);
            this.listaReqPanel.Name = "listaReqPanel";
            this.listaReqPanel.Size = new System.Drawing.Size(835, 225);
            this.listaReqPanel.TabIndex = 1;
            // 
            // altExcPanel
            // 
            this.altExcPanel.Controls.Add(this.excReqBtn);
            this.altExcPanel.Controls.Add(this.alterarReqBtn);
            this.altExcPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.altExcPanel.Location = new System.Drawing.Point(3, 278);
            this.altExcPanel.Name = "altExcPanel";
            this.altExcPanel.Size = new System.Drawing.Size(835, 47);
            this.altExcPanel.TabIndex = 2;
            // 
            // buscaReqDgv
            // 
            this.buscaReqDgv.AllowUserToAddRows = false;
            this.buscaReqDgv.AllowUserToDeleteRows = false;
            this.buscaReqDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscaReqDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscaReqDgv.Location = new System.Drawing.Point(0, 0);
            this.buscaReqDgv.MultiSelect = false;
            this.buscaReqDgv.Name = "buscaReqDgv";
            this.buscaReqDgv.ReadOnly = true;
            this.buscaReqDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buscaReqDgv.Size = new System.Drawing.Size(835, 225);
            this.buscaReqDgv.TabIndex = 0;
            // 
            // alterarReqBtn
            // 
            this.alterarReqBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.alterarReqBtn.Location = new System.Drawing.Point(720, 0);
            this.alterarReqBtn.Name = "alterarReqBtn";
            this.alterarReqBtn.Size = new System.Drawing.Size(115, 47);
            this.alterarReqBtn.TabIndex = 0;
            this.alterarReqBtn.Text = "ALTERAR";
            this.alterarReqBtn.UseVisualStyleBackColor = true;
            // 
            // excReqBtn
            // 
            this.excReqBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.excReqBtn.Location = new System.Drawing.Point(605, 0);
            this.excReqBtn.Name = "excReqBtn";
            this.excReqBtn.Size = new System.Drawing.Size(115, 47);
            this.excReqBtn.TabIndex = 1;
            this.excReqBtn.Text = "EXCLUIR";
            this.excReqBtn.UseVisualStyleBackColor = true;
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
            this.tabPage2.ResumeLayout(false);
            this.buscarReqPanel.ResumeLayout(false);
            this.buscarReqPanel.PerformLayout();
            this.listaReqPanel.ResumeLayout(false);
            this.altExcPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buscaReqDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl requisicoesTab;
        private System.Windows.Forms.TabPage cadastroReqTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dataReqDtp;
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
        private System.Windows.Forms.Panel altExcPanel;
        private System.Windows.Forms.Button excReqBtn;
        private System.Windows.Forms.Button alterarReqBtn;
        private System.Windows.Forms.Panel listaReqPanel;
        private System.Windows.Forms.DataGridView buscaReqDgv;
        private System.Windows.Forms.Panel buscarReqPanel;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Label buscaLbl;
        private System.Windows.Forms.ComboBox buscaFuncCb;
    }
}
