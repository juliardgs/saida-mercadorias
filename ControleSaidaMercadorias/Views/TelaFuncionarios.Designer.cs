namespace ControleSaidaMercadorias.Views
{
    partial class TelaFuncionarios
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
            this.funcionariosTab = new System.Windows.Forms.TabControl();
            this.cadastroTab = new System.Windows.Forms.TabPage();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataNascLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nomeLbl = new System.Windows.Forms.Label();
            this.listagemTab = new System.Windows.Forms.TabPage();
            this.botoesPanel = new System.Windows.Forms.Panel();
            this.alterarBtn = new System.Windows.Forms.Button();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.listaFuncPanel = new System.Windows.Forms.Panel();
            this.funcDgv = new System.Windows.Forms.DataGridView();
            this.buscarPanel = new System.Windows.Forms.Panel();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.buscarTxt = new System.Windows.Forms.TextBox();
            this.buscarLbl = new System.Windows.Forms.Label();
            this.cadastroPanel = new System.Windows.Forms.Panel();
            this.funcionariosTab.SuspendLayout();
            this.cadastroTab.SuspendLayout();
            this.listagemTab.SuspendLayout();
            this.botoesPanel.SuspendLayout();
            this.listaFuncPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcDgv)).BeginInit();
            this.buscarPanel.SuspendLayout();
            this.cadastroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcionariosTab
            // 
            this.funcionariosTab.Controls.Add(this.cadastroTab);
            this.funcionariosTab.Controls.Add(this.listagemTab);
            this.funcionariosTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funcionariosTab.Location = new System.Drawing.Point(0, 0);
            this.funcionariosTab.Name = "funcionariosTab";
            this.funcionariosTab.SelectedIndex = 0;
            this.funcionariosTab.Size = new System.Drawing.Size(849, 512);
            this.funcionariosTab.TabIndex = 0;
            // 
            // cadastroTab
            // 
            this.cadastroTab.Controls.Add(this.cadastroPanel);
            this.cadastroTab.Location = new System.Drawing.Point(4, 22);
            this.cadastroTab.Name = "cadastroTab";
            this.cadastroTab.Padding = new System.Windows.Forms.Padding(3);
            this.cadastroTab.Size = new System.Drawing.Size(841, 486);
            this.cadastroTab.TabIndex = 0;
            this.cadastroTab.Text = "Cadastrar Funcionários";
            this.cadastroTab.UseVisualStyleBackColor = true;
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.Location = new System.Drawing.Point(720, 36);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(84, 23);
            this.cadastrarBtn.TabIndex = 4;
            this.cadastrarBtn.Text = "CADASTRAR";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dataNascLbl
            // 
            this.dataNascLbl.AutoSize = true;
            this.dataNascLbl.Location = new System.Drawing.Point(366, 41);
            this.dataNascLbl.Name = "dataNascLbl";
            this.dataNascLbl.Size = new System.Drawing.Size(105, 13);
            this.dataNascLbl.TabIndex = 2;
            this.dataNascLbl.Text = "Data de nascimento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 1;
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Location = new System.Drawing.Point(3, 41);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(38, 13);
            this.nomeLbl.TabIndex = 0;
            this.nomeLbl.Text = "Nome:";
            // 
            // listagemTab
            // 
            this.listagemTab.Controls.Add(this.botoesPanel);
            this.listagemTab.Controls.Add(this.listaFuncPanel);
            this.listagemTab.Controls.Add(this.buscarPanel);
            this.listagemTab.Location = new System.Drawing.Point(4, 22);
            this.listagemTab.Name = "listagemTab";
            this.listagemTab.Padding = new System.Windows.Forms.Padding(3);
            this.listagemTab.Size = new System.Drawing.Size(841, 486);
            this.listagemTab.TabIndex = 1;
            this.listagemTab.Text = "Listar Funcionários";
            this.listagemTab.UseVisualStyleBackColor = true;
            this.listagemTab.Click += new System.EventHandler(this.listagemTab_Click);
            // 
            // botoesPanel
            // 
            this.botoesPanel.Controls.Add(this.alterarBtn);
            this.botoesPanel.Controls.Add(this.excluirBtn);
            this.botoesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.botoesPanel.Location = new System.Drawing.Point(598, 422);
            this.botoesPanel.Name = "botoesPanel";
            this.botoesPanel.Size = new System.Drawing.Size(240, 61);
            this.botoesPanel.TabIndex = 4;
            // 
            // alterarBtn
            // 
            this.alterarBtn.Enabled = false;
            this.alterarBtn.Location = new System.Drawing.Point(3, 19);
            this.alterarBtn.Name = "alterarBtn";
            this.alterarBtn.Size = new System.Drawing.Size(109, 23);
            this.alterarBtn.TabIndex = 2;
            this.alterarBtn.Text = "ALTERAR";
            this.alterarBtn.UseVisualStyleBackColor = true;
            // 
            // excluirBtn
            // 
            this.excluirBtn.Enabled = false;
            this.excluirBtn.Location = new System.Drawing.Point(123, 19);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(109, 23);
            this.excluirBtn.TabIndex = 3;
            this.excluirBtn.Text = "EXCLUIR";
            this.excluirBtn.UseVisualStyleBackColor = true;
            // 
            // listaFuncPanel
            // 
            this.listaFuncPanel.Controls.Add(this.funcDgv);
            this.listaFuncPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listaFuncPanel.Location = new System.Drawing.Point(3, 75);
            this.listaFuncPanel.Name = "listaFuncPanel";
            this.listaFuncPanel.Size = new System.Drawing.Size(835, 347);
            this.listaFuncPanel.TabIndex = 1;
            // 
            // funcDgv
            // 
            this.funcDgv.AllowUserToAddRows = false;
            this.funcDgv.AllowUserToDeleteRows = false;
            this.funcDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funcDgv.Location = new System.Drawing.Point(0, 0);
            this.funcDgv.MultiSelect = false;
            this.funcDgv.Name = "funcDgv";
            this.funcDgv.ReadOnly = true;
            this.funcDgv.Size = new System.Drawing.Size(835, 347);
            this.funcDgv.TabIndex = 0;
            // 
            // buscarPanel
            // 
            this.buscarPanel.Controls.Add(this.buscarBtn);
            this.buscarPanel.Controls.Add(this.buscarTxt);
            this.buscarPanel.Controls.Add(this.buscarLbl);
            this.buscarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buscarPanel.Location = new System.Drawing.Point(3, 3);
            this.buscarPanel.Name = "buscarPanel";
            this.buscarPanel.Size = new System.Drawing.Size(835, 72);
            this.buscarPanel.TabIndex = 0;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(705, 19);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(109, 23);
            this.buscarBtn.TabIndex = 2;
            this.buscarBtn.Text = "BUSCAR";
            this.buscarBtn.UseVisualStyleBackColor = true;
            // 
            // buscarTxt
            // 
            this.buscarTxt.Location = new System.Drawing.Point(139, 21);
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(549, 20);
            this.buscarTxt.TabIndex = 1;
            // 
            // buscarLbl
            // 
            this.buscarLbl.AutoSize = true;
            this.buscarLbl.Location = new System.Drawing.Point(14, 24);
            this.buscarLbl.Name = "buscarLbl";
            this.buscarLbl.Size = new System.Drawing.Size(119, 13);
            this.buscarLbl.TabIndex = 0;
            this.buscarLbl.Text = "Buscar por nome ou ID:";
            // 
            // cadastroPanel
            // 
            this.cadastroPanel.Controls.Add(this.nomeLbl);
            this.cadastroPanel.Controls.Add(this.cadastrarBtn);
            this.cadastroPanel.Controls.Add(this.textBox1);
            this.cadastroPanel.Controls.Add(this.dateTimePicker1);
            this.cadastroPanel.Controls.Add(this.dataNascLbl);
            this.cadastroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cadastroPanel.Location = new System.Drawing.Point(3, 3);
            this.cadastroPanel.Name = "cadastroPanel";
            this.cadastroPanel.Size = new System.Drawing.Size(835, 100);
            this.cadastroPanel.TabIndex = 5;
            // 
            // TelaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.funcionariosTab);
            this.Name = "TelaFuncionarios";
            this.Size = new System.Drawing.Size(849, 512);
            this.funcionariosTab.ResumeLayout(false);
            this.cadastroTab.ResumeLayout(false);
            this.listagemTab.ResumeLayout(false);
            this.botoesPanel.ResumeLayout(false);
            this.listaFuncPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.funcDgv)).EndInit();
            this.buscarPanel.ResumeLayout(false);
            this.buscarPanel.PerformLayout();
            this.cadastroPanel.ResumeLayout(false);
            this.cadastroPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl funcionariosTab;
        private System.Windows.Forms.TabPage cadastroTab;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dataNascLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.TabPage listagemTab;
        private System.Windows.Forms.Panel buscarPanel;
        private System.Windows.Forms.Button alterarBtn;
        private System.Windows.Forms.Panel listaFuncPanel;
        private System.Windows.Forms.DataGridView funcDgv;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.TextBox buscarTxt;
        private System.Windows.Forms.Label buscarLbl;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.Panel botoesPanel;
        private System.Windows.Forms.Panel cadastroPanel;
    }
}
