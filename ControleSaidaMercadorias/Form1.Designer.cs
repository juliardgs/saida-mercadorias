namespace ControleSaidaMercadorias
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.Panel();
            this.relatoriosBtn = new System.Windows.Forms.Button();
            this.requisicoesBtn = new System.Windows.Forms.Button();
            this.produtosBtn = new System.Windows.Forms.Button();
            this.funcionariosBtn = new System.Windows.Forms.Button();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.telaProdutos = new ControleSaidaMercadorias.Views.TelaProdutos();
            this.menuFuncionarios = new ControleSaidaMercadorias.Views.TelaFuncionarios();
            this.menu.SuspendLayout();
            this.painelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menu.Controls.Add(this.relatoriosBtn);
            this.menu.Controls.Add(this.requisicoesBtn);
            this.menu.Controls.Add(this.produtosBtn);
            this.menu.Controls.Add(this.funcionariosBtn);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(187, 505);
            this.menu.TabIndex = 0;
            // 
            // relatoriosBtn
            // 
            this.relatoriosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.relatoriosBtn.Location = new System.Drawing.Point(0, 69);
            this.relatoriosBtn.Name = "relatoriosBtn";
            this.relatoriosBtn.Size = new System.Drawing.Size(187, 23);
            this.relatoriosBtn.TabIndex = 3;
            this.relatoriosBtn.Text = "Relatórios";
            this.relatoriosBtn.UseVisualStyleBackColor = true;
            // 
            // requisicoesBtn
            // 
            this.requisicoesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.requisicoesBtn.Location = new System.Drawing.Point(0, 46);
            this.requisicoesBtn.Name = "requisicoesBtn";
            this.requisicoesBtn.Size = new System.Drawing.Size(187, 23);
            this.requisicoesBtn.TabIndex = 2;
            this.requisicoesBtn.Text = "Requisições";
            this.requisicoesBtn.UseVisualStyleBackColor = true;
            // 
            // produtosBtn
            // 
            this.produtosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.produtosBtn.Location = new System.Drawing.Point(0, 23);
            this.produtosBtn.Name = "produtosBtn";
            this.produtosBtn.Size = new System.Drawing.Size(187, 23);
            this.produtosBtn.TabIndex = 1;
            this.produtosBtn.Text = "Produtos";
            this.produtosBtn.UseVisualStyleBackColor = true;
            this.produtosBtn.Click += new System.EventHandler(this.produtosBtn_Click);
            // 
            // funcionariosBtn
            // 
            this.funcionariosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.funcionariosBtn.Location = new System.Drawing.Point(0, 0);
            this.funcionariosBtn.Name = "funcionariosBtn";
            this.funcionariosBtn.Size = new System.Drawing.Size(187, 23);
            this.funcionariosBtn.TabIndex = 0;
            this.funcionariosBtn.Text = "Funcionários";
            this.funcionariosBtn.UseVisualStyleBackColor = true;
            this.funcionariosBtn.Click += new System.EventHandler(this.funcionariosBtn_Click);
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.telaProdutos);
            this.painelPrincipal.Controls.Add(this.menuFuncionarios);
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(187, 0);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(844, 505);
            this.painelPrincipal.TabIndex = 1;
            // 
            // telaProdutos
            // 
            this.telaProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telaProdutos.Location = new System.Drawing.Point(0, 0);
            this.telaProdutos.Name = "telaProdutos";
            this.telaProdutos.Size = new System.Drawing.Size(844, 505);
            this.telaProdutos.TabIndex = 1;
            this.telaProdutos.Visible = false;
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(844, 505);
            this.menuFuncionarios.TabIndex = 0;
            this.menuFuncionarios.Visible = false;
            this.menuFuncionarios.Load += new System.EventHandler(this.menuFuncionarios_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 505);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.Text = "Controle de Saída de Mercadorias";
            this.menu.ResumeLayout(false);
            this.painelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button relatoriosBtn;
        private System.Windows.Forms.Button requisicoesBtn;
        private System.Windows.Forms.Button produtosBtn;
        private System.Windows.Forms.Button funcionariosBtn;
        private System.Windows.Forms.Panel painelPrincipal;
        private Views.TelaFuncionarios telaFuncionarios;
        private Views.TelaFuncionarios menuFuncionarios;
        private Views.TelaProdutos telaProdutos;
    }
}

