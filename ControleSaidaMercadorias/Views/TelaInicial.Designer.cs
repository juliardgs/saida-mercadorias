namespace ControleSaidaMercadorias.Views
{
    partial class TelaInicial
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.navegacaoPanel = new System.Windows.Forms.Panel();
            this.funcionariosBtn = new System.Windows.Forms.Button();
            this.produtosBtn = new System.Windows.Forms.Button();
            this.requisicoesBtn = new System.Windows.Forms.Button();
            this.relatoriosBtn = new System.Windows.Forms.Button();
            this.telasPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.navegacaoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.navegacaoPanel);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 466);
            this.menuPanel.TabIndex = 0;
            // 
            // logoPanel
            // 
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 100);
            this.logoPanel.TabIndex = 1;
            // 
            // navegacaoPanel
            // 
            this.navegacaoPanel.Controls.Add(this.relatoriosBtn);
            this.navegacaoPanel.Controls.Add(this.requisicoesBtn);
            this.navegacaoPanel.Controls.Add(this.produtosBtn);
            this.navegacaoPanel.Controls.Add(this.funcionariosBtn);
            this.navegacaoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navegacaoPanel.Location = new System.Drawing.Point(0, 100);
            this.navegacaoPanel.Name = "navegacaoPanel";
            this.navegacaoPanel.Size = new System.Drawing.Size(200, 309);
            this.navegacaoPanel.TabIndex = 1;
            // 
            // funcionariosBtn
            // 
            this.funcionariosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.funcionariosBtn.Location = new System.Drawing.Point(0, 0);
            this.funcionariosBtn.Name = "funcionariosBtn";
            this.funcionariosBtn.Size = new System.Drawing.Size(200, 53);
            this.funcionariosBtn.TabIndex = 1;
            this.funcionariosBtn.Text = "Funcionários";
            this.funcionariosBtn.UseVisualStyleBackColor = true;
            // 
            // produtosBtn
            // 
            this.produtosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.produtosBtn.Location = new System.Drawing.Point(0, 53);
            this.produtosBtn.Name = "produtosBtn";
            this.produtosBtn.Size = new System.Drawing.Size(200, 53);
            this.produtosBtn.TabIndex = 2;
            this.produtosBtn.Text = "Produtos";
            this.produtosBtn.UseVisualStyleBackColor = true;
            // 
            // requisicoesBtn
            // 
            this.requisicoesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.requisicoesBtn.Location = new System.Drawing.Point(0, 106);
            this.requisicoesBtn.Name = "requisicoesBtn";
            this.requisicoesBtn.Size = new System.Drawing.Size(200, 53);
            this.requisicoesBtn.TabIndex = 3;
            this.requisicoesBtn.Text = "Requisições";
            this.requisicoesBtn.UseVisualStyleBackColor = true;
            // 
            // relatoriosBtn
            // 
            this.relatoriosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.relatoriosBtn.Location = new System.Drawing.Point(0, 159);
            this.relatoriosBtn.Name = "relatoriosBtn";
            this.relatoriosBtn.Size = new System.Drawing.Size(200, 53);
            this.relatoriosBtn.TabIndex = 4;
            this.relatoriosBtn.Text = "Relatórios";
            this.relatoriosBtn.UseVisualStyleBackColor = true;
            // 
            // telasPanel
            // 
            this.telasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telasPanel.Location = new System.Drawing.Point(200, 0);
            this.telasPanel.Name = "telasPanel";
            this.telasPanel.Size = new System.Drawing.Size(628, 466);
            this.telasPanel.TabIndex = 1;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 466);
            this.Controls.Add(this.telasPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.menuPanel.ResumeLayout(false);
            this.navegacaoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel navegacaoPanel;
        private System.Windows.Forms.Button relatoriosBtn;
        private System.Windows.Forms.Button requisicoesBtn;
        private System.Windows.Forms.Button produtosBtn;
        private System.Windows.Forms.Button funcionariosBtn;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel telasPanel;
    }
}