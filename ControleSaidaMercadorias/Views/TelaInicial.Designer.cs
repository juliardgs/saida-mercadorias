﻿namespace ControleSaidaMercadorias.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.relatoriosBtn = new System.Windows.Forms.Button();
            this.requisicoesBtn = new System.Windows.Forms.Button();
            this.produtosBtn = new System.Windows.Forms.Button();
            this.funcionariosBtn = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.tituloLbl = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.telasPanel = new System.Windows.Forms.Panel();
            this.telaRequisicoes1 = new ControleSaidaMercadorias.Views.TelaRequisicoes();
            this.telaProdutos1 = new ControleSaidaMercadorias.Views.TelaProdutos();
            this.telaFuncionarios1 = new ControleSaidaMercadorias.Views.TelaFuncionarios();
            this.telaRelatorios1 = new ControleSaidaMercadorias.Views.TelaRelatorios();
            this.menuPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.telasPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.navPanel);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 505);
            this.menuPanel.TabIndex = 0;
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.relatoriosBtn);
            this.navPanel.Controls.Add(this.requisicoesBtn);
            this.navPanel.Controls.Add(this.produtosBtn);
            this.navPanel.Controls.Add(this.funcionariosBtn);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 113);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(195, 304);
            this.navPanel.TabIndex = 0;
            // 
            // relatoriosBtn
            // 
            this.relatoriosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.relatoriosBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.relatoriosBtn.FlatAppearance.BorderSize = 0;
            this.relatoriosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.relatoriosBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.relatoriosBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.relatoriosBtn.Image = ((System.Drawing.Image)(resources.GetObject("relatoriosBtn.Image")));
            this.relatoriosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.relatoriosBtn.Location = new System.Drawing.Point(0, 165);
            this.relatoriosBtn.Name = "relatoriosBtn";
            this.relatoriosBtn.Size = new System.Drawing.Size(195, 55);
            this.relatoriosBtn.TabIndex = 3;
            this.relatoriosBtn.Text = "Relatórios";
            this.relatoriosBtn.UseVisualStyleBackColor = true;
            this.relatoriosBtn.Click += new System.EventHandler(this.relatoriosBtn_Click);
            // 
            // requisicoesBtn
            // 
            this.requisicoesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.requisicoesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.requisicoesBtn.FlatAppearance.BorderSize = 0;
            this.requisicoesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requisicoesBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.requisicoesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.requisicoesBtn.Image = ((System.Drawing.Image)(resources.GetObject("requisicoesBtn.Image")));
            this.requisicoesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requisicoesBtn.Location = new System.Drawing.Point(0, 110);
            this.requisicoesBtn.Name = "requisicoesBtn";
            this.requisicoesBtn.Size = new System.Drawing.Size(195, 55);
            this.requisicoesBtn.TabIndex = 2;
            this.requisicoesBtn.Text = "Requisições";
            this.requisicoesBtn.UseVisualStyleBackColor = true;
            this.requisicoesBtn.Click += new System.EventHandler(this.requisicoesBtn_Click);
            // 
            // produtosBtn
            // 
            this.produtosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.produtosBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.produtosBtn.FlatAppearance.BorderSize = 0;
            this.produtosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produtosBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.produtosBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.produtosBtn.Image = ((System.Drawing.Image)(resources.GetObject("produtosBtn.Image")));
            this.produtosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produtosBtn.Location = new System.Drawing.Point(0, 55);
            this.produtosBtn.Name = "produtosBtn";
            this.produtosBtn.Size = new System.Drawing.Size(195, 55);
            this.produtosBtn.TabIndex = 1;
            this.produtosBtn.Text = "Produtos";
            this.produtosBtn.UseVisualStyleBackColor = true;
            this.produtosBtn.Click += new System.EventHandler(this.produtosBtn_Click);
            // 
            // funcionariosBtn
            // 
            this.funcionariosBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.funcionariosBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.funcionariosBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.funcionariosBtn.FlatAppearance.BorderSize = 0;
            this.funcionariosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.funcionariosBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.funcionariosBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.funcionariosBtn.Image = ((System.Drawing.Image)(resources.GetObject("funcionariosBtn.Image")));
            this.funcionariosBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.funcionariosBtn.Location = new System.Drawing.Point(0, 0);
            this.funcionariosBtn.Name = "funcionariosBtn";
            this.funcionariosBtn.Size = new System.Drawing.Size(195, 55);
            this.funcionariosBtn.TabIndex = 0;
            this.funcionariosBtn.Text = "Funcionários";
            this.funcionariosBtn.UseVisualStyleBackColor = false;
            this.funcionariosBtn.Click += new System.EventHandler(this.funcionariosBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.tituloLbl);
            this.logoPanel.Controls.Add(this.logo);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(195, 113);
            this.logoPanel.TabIndex = 0;
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.tituloLbl.ForeColor = System.Drawing.Color.White;
            this.tituloLbl.Location = new System.Drawing.Point(76, 37);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(113, 32);
            this.tituloLbl.TabIndex = 3;
            this.tituloLbl.Text = "Controle de Saída\r\nde Mercadorias";
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.Location = new System.Drawing.Point(12, 21);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(64, 64);
            this.logo.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(195, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 505);
            this.panel1.TabIndex = 3;
            // 
            // telasPanel
            // 
            this.telasPanel.Controls.Add(this.telaRelatorios1);
            this.telasPanel.Controls.Add(this.telaRequisicoes1);
            this.telasPanel.Controls.Add(this.telaProdutos1);
            this.telasPanel.Controls.Add(this.telaFuncionarios1);
            this.telasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telasPanel.Location = new System.Drawing.Point(200, 0);
            this.telasPanel.Name = "telasPanel";
            this.telasPanel.Size = new System.Drawing.Size(831, 505);
            this.telasPanel.TabIndex = 1;
            // 
            // telaRequisicoes1
            // 
            this.telaRequisicoes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telaRequisicoes1.Location = new System.Drawing.Point(0, 0);
            this.telaRequisicoes1.Name = "telaRequisicoes1";
            this.telaRequisicoes1.Size = new System.Drawing.Size(831, 505);
            this.telaRequisicoes1.TabIndex = 2;
            this.telaRequisicoes1.Visible = false;
            // 
            // telaProdutos1
            // 
            this.telaProdutos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telaProdutos1.Location = new System.Drawing.Point(0, 0);
            this.telaProdutos1.Name = "telaProdutos1";
            this.telaProdutos1.Size = new System.Drawing.Size(831, 505);
            this.telaProdutos1.TabIndex = 1;
            this.telaProdutos1.Visible = false;
            // 
            // telaFuncionarios1
            // 
            this.telaFuncionarios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telaFuncionarios1.Location = new System.Drawing.Point(0, 0);
            this.telaFuncionarios1.Name = "telaFuncionarios1";
            this.telaFuncionarios1.Size = new System.Drawing.Size(831, 505);
            this.telaFuncionarios1.TabIndex = 0;
            this.telaFuncionarios1.Visible = false;
            // 
            // telaRelatorios1
            // 
            this.telaRelatorios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telaRelatorios1.Location = new System.Drawing.Point(0, 0);
            this.telaRelatorios1.Name = "telaRelatorios1";
            this.telaRelatorios1.Size = new System.Drawing.Size(831, 505);
            this.telaRelatorios1.TabIndex = 3;
            this.telaRelatorios1.Visible = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 505);
            this.Controls.Add(this.telasPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "TelaInicial";
            this.Text = "Controle de Saída de Mercadorias";
            this.menuPanel.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.telasPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button relatoriosBtn;
        private System.Windows.Forms.Button requisicoesBtn;
        private System.Windows.Forms.Button produtosBtn;
        private System.Windows.Forms.Button funcionariosBtn;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel telasPanel;
        private TelaFuncionarios telaFuncionarios1;
        private TelaProdutos telaProdutos1;
        private TelaRequisicoes telaRequisicoes1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.Panel logo;
        private TelaRelatorios telaRelatorios1;
    }
}