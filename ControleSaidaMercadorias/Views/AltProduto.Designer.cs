﻿namespace ControleSaidaMercadorias.Views
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
            this.listaProdSimplesPanel = new System.Windows.Forms.Panel();
            this.addExcBtnPanel = new System.Windows.Forms.Panel();
            this.salvarBtnPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.qtdeEstoqueLbl = new System.Windows.Forms.Label();
            this.qtdeEstoqueTxt = new System.Windows.Forms.TextBox();
            this.precoCustoLbl = new System.Windows.Forms.Label();
            this.precoCustoTxt = new System.Windows.Forms.TextBox();
            this.precoVendaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qtdeProdSimplesTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProdSimplesBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.infoProdPanel.SuspendLayout();
            this.listaProdSimplesPanel.SuspendLayout();
            this.addExcBtnPanel.SuspendLayout();
            this.salvarBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoProdPanel
            // 
            this.infoProdPanel.Controls.Add(this.precoVendaTxt);
            this.infoProdPanel.Controls.Add(this.label2);
            this.infoProdPanel.Controls.Add(this.precoCustoTxt);
            this.infoProdPanel.Controls.Add(this.precoCustoLbl);
            this.infoProdPanel.Controls.Add(this.qtdeEstoqueTxt);
            this.infoProdPanel.Controls.Add(this.qtdeEstoqueLbl);
            this.infoProdPanel.Controls.Add(this.textBox1);
            this.infoProdPanel.Controls.Add(this.label1);
            this.infoProdPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoProdPanel.Location = new System.Drawing.Point(0, 0);
            this.infoProdPanel.Name = "infoProdPanel";
            this.infoProdPanel.Size = new System.Drawing.Size(526, 112);
            this.infoProdPanel.TabIndex = 0;
            // 
            // listaProdSimplesPanel
            // 
            this.listaProdSimplesPanel.Controls.Add(this.dataGridView1);
            this.listaProdSimplesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.listaProdSimplesPanel.Location = new System.Drawing.Point(0, 112);
            this.listaProdSimplesPanel.Name = "listaProdSimplesPanel";
            this.listaProdSimplesPanel.Size = new System.Drawing.Size(526, 179);
            this.listaProdSimplesPanel.TabIndex = 1;
            this.listaProdSimplesPanel.Visible = false;
            // 
            // addExcBtnPanel
            // 
            this.addExcBtnPanel.Controls.Add(this.button1);
            this.addExcBtnPanel.Controls.Add(this.addProdSimplesBtn);
            this.addExcBtnPanel.Controls.Add(this.qtdeProdSimplesTxt);
            this.addExcBtnPanel.Controls.Add(this.label3);
            this.addExcBtnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addExcBtnPanel.Location = new System.Drawing.Point(0, 291);
            this.addExcBtnPanel.Name = "addExcBtnPanel";
            this.addExcBtnPanel.Size = new System.Drawing.Size(526, 41);
            this.addExcBtnPanel.TabIndex = 2;
            this.addExcBtnPanel.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 15);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 20);
            this.textBox1.TabIndex = 1;
            // 
            // qtdeEstoqueLbl
            // 
            this.qtdeEstoqueLbl.AutoSize = true;
            this.qtdeEstoqueLbl.Location = new System.Drawing.Point(386, 55);
            this.qtdeEstoqueLbl.Name = "qtdeEstoqueLbl";
            this.qtdeEstoqueLbl.Size = new System.Drawing.Size(65, 13);
            this.qtdeEstoqueLbl.TabIndex = 2;
            this.qtdeEstoqueLbl.Text = "Quantidade:";
            // 
            // qtdeEstoqueTxt
            // 
            this.qtdeEstoqueTxt.Location = new System.Drawing.Point(457, 52);
            this.qtdeEstoqueTxt.MaxLength = 4;
            this.qtdeEstoqueTxt.Name = "qtdeEstoqueTxt";
            this.qtdeEstoqueTxt.Size = new System.Drawing.Size(37, 20);
            this.qtdeEstoqueTxt.TabIndex = 3;
            this.qtdeEstoqueTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtdeEstoqueTxt_KeyPress);
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
            // precoCustoTxt
            // 
            this.precoCustoTxt.Location = new System.Drawing.Point(101, 52);
            this.precoCustoTxt.MaxLength = 7;
            this.precoCustoTxt.Name = "precoCustoTxt";
            this.precoCustoTxt.Size = new System.Drawing.Size(65, 20);
            this.precoCustoTxt.TabIndex = 5;
            this.precoCustoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precoCustoTxt_KeyPress);
            // 
            // precoVendaTxt
            // 
            this.precoVendaTxt.Location = new System.Drawing.Point(285, 52);
            this.precoVendaTxt.MaxLength = 7;
            this.precoVendaTxt.Name = "precoVendaTxt";
            this.precoVendaTxt.Size = new System.Drawing.Size(65, 20);
            this.precoVendaTxt.TabIndex = 7;
            this.precoVendaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precoVendaTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço de Venda:";
            // 
            // qtdeProdSimplesTxt
            // 
            this.qtdeProdSimplesTxt.Location = new System.Drawing.Point(83, 10);
            this.qtdeProdSimplesTxt.MaxLength = 4;
            this.qtdeProdSimplesTxt.Name = "qtdeProdSimplesTxt";
            this.qtdeProdSimplesTxt.Size = new System.Drawing.Size(37, 20);
            this.qtdeProdSimplesTxt.TabIndex = 5;
            this.qtdeProdSimplesTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtdeProdSimplesTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade:";
            // 
            // addProdSimplesBtn
            // 
            this.addProdSimplesBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addProdSimplesBtn.Enabled = false;
            this.addProdSimplesBtn.Location = new System.Drawing.Point(421, 0);
            this.addProdSimplesBtn.Name = "addProdSimplesBtn";
            this.addProdSimplesBtn.Size = new System.Drawing.Size(105, 41);
            this.addProdSimplesBtn.TabIndex = 6;
            this.addProdSimplesBtn.Text = "ADICIONAR ITEM";
            this.addProdSimplesBtn.UseVisualStyleBackColor = true;
            this.addProdSimplesBtn.Click += new System.EventHandler(this.addProdSimplesBtn_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(321, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "EXCLUIR ITEM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.qtde,
            this.precoCusto,
            this.precoVenda});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(526, 179);
            this.dataGridView1.TabIndex = 0;
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
            // precoCusto
            // 
            this.precoCusto.HeaderText = "PREÇO DE CUSTO";
            this.precoCusto.Name = "precoCusto";
            this.precoCusto.ReadOnly = true;
            // 
            // precoVenda
            // 
            this.precoVenda.HeaderText = "PREÇO DE VENDA";
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.ReadOnly = true;
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
            this.addExcBtnPanel.ResumeLayout(false);
            this.addExcBtnPanel.PerformLayout();
            this.salvarBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoProdPanel;
        private System.Windows.Forms.Label precoCustoLbl;
        private System.Windows.Forms.TextBox qtdeEstoqueTxt;
        private System.Windows.Forms.Label qtdeEstoqueLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel listaProdSimplesPanel;
        private System.Windows.Forms.Panel addExcBtnPanel;
        private System.Windows.Forms.Panel salvarBtnPanel;
        private System.Windows.Forms.TextBox precoVendaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precoCustoTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addProdSimplesBtn;
        private System.Windows.Forms.TextBox qtdeProdSimplesTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
        private System.Windows.Forms.Button salvarBtn;
    }
}