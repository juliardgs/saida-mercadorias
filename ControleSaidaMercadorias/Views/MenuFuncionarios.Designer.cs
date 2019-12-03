namespace ControleSaidaMercadorias.Views
{
    partial class MenuFuncionarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.pesquisaTxt = new System.Windows.Forms.TextBox();
            this.pesquisaLbl = new System.Windows.Forms.Label();
            this.funcionariosTab.SuspendLayout();
            this.cadastroTab.SuspendLayout();
            this.listagemTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.cadastroTab.Controls.Add(this.cadastrarBtn);
            this.cadastroTab.Controls.Add(this.dateTimePicker1);
            this.cadastroTab.Controls.Add(this.dataNascLbl);
            this.cadastroTab.Controls.Add(this.textBox1);
            this.cadastroTab.Controls.Add(this.nomeLbl);
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
            this.cadastrarBtn.Location = new System.Drawing.Point(735, 30);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(84, 23);
            this.cadastrarBtn.TabIndex = 4;
            this.cadastrarBtn.Text = "CADASTRAR";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(492, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dataNascLbl
            // 
            this.dataNascLbl.AutoSize = true;
            this.dataNascLbl.Location = new System.Drawing.Point(381, 35);
            this.dataNascLbl.Name = "dataNascLbl";
            this.dataNascLbl.Size = new System.Drawing.Size(105, 13);
            this.dataNascLbl.TabIndex = 2;
            this.dataNascLbl.Text = "Data de nascimento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 1;
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Location = new System.Drawing.Point(18, 35);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(38, 13);
            this.nomeLbl.TabIndex = 0;
            this.nomeLbl.Text = "Nome:";
            // 
            // listagemTab
            // 
            this.listagemTab.Controls.Add(this.panel1);
            this.listagemTab.Controls.Add(this.buscarBtn);
            this.listagemTab.Controls.Add(this.pesquisaTxt);
            this.listagemTab.Controls.Add(this.pesquisaLbl);
            this.listagemTab.Location = new System.Drawing.Point(4, 22);
            this.listagemTab.Name = "listagemTab";
            this.listagemTab.Padding = new System.Windows.Forms.Padding(3);
            this.listagemTab.Size = new System.Drawing.Size(841, 486);
            this.listagemTab.TabIndex = 1;
            this.listagemTab.Text = "Listar Funcionários";
            this.listagemTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 395);
            this.panel1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(835, 395);
            this.dataGridView1.TabIndex = 10;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(726, 28);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(84, 23);
            this.buscarBtn.TabIndex = 9;
            this.buscarBtn.Text = "BUSCAR";
            this.buscarBtn.UseVisualStyleBackColor = true;
            // 
            // pesquisaTxt
            // 
            this.pesquisaTxt.Location = new System.Drawing.Point(142, 30);
            this.pesquisaTxt.Name = "pesquisaTxt";
            this.pesquisaTxt.Size = new System.Drawing.Size(565, 20);
            this.pesquisaTxt.TabIndex = 6;
            // 
            // pesquisaLbl
            // 
            this.pesquisaLbl.AutoSize = true;
            this.pesquisaLbl.Location = new System.Drawing.Point(19, 33);
            this.pesquisaLbl.Name = "pesquisaLbl";
            this.pesquisaLbl.Size = new System.Drawing.Size(117, 13);
            this.pesquisaLbl.TabIndex = 5;
            this.pesquisaLbl.Text = "Burcar por nome ou ID:";
            // 
            // MenuFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.funcionariosTab);
            this.Name = "MenuFuncionarios";
            this.Size = new System.Drawing.Size(849, 512);
            this.funcionariosTab.ResumeLayout(false);
            this.cadastroTab.ResumeLayout(false);
            this.cadastroTab.PerformLayout();
            this.listagemTab.ResumeLayout(false);
            this.listagemTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl funcionariosTab;
        private System.Windows.Forms.TabPage cadastroTab;
        private System.Windows.Forms.TabPage listagemTab;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dataNascLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.TextBox pesquisaTxt;
        private System.Windows.Forms.Label pesquisaLbl;
    }
}
