namespace ControleSaidaMercadorias.Views
{
    partial class AltFuncionario
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
            this.nomeLbl = new System.Windows.Forms.Label();
            this.dataNascLbl = new System.Windows.Forms.Label();
            this.salvarPanel = new System.Windows.Forms.Panel();
            this.dataNascDtp = new System.Windows.Forms.DateTimePicker();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.salvarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLbl
            // 
            this.nomeLbl.AutoSize = true;
            this.nomeLbl.Location = new System.Drawing.Point(12, 21);
            this.nomeLbl.Name = "nomeLbl";
            this.nomeLbl.Size = new System.Drawing.Size(38, 13);
            this.nomeLbl.TabIndex = 0;
            this.nomeLbl.Text = "Nome:";
            // 
            // dataNascLbl
            // 
            this.dataNascLbl.AutoSize = true;
            this.dataNascLbl.Location = new System.Drawing.Point(12, 59);
            this.dataNascLbl.Name = "dataNascLbl";
            this.dataNascLbl.Size = new System.Drawing.Size(107, 13);
            this.dataNascLbl.TabIndex = 1;
            this.dataNascLbl.Text = "Data de Nascimento:";
            // 
            // salvarPanel
            // 
            this.salvarPanel.Controls.Add(this.btnSalvar);
            this.salvarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salvarPanel.Location = new System.Drawing.Point(0, 98);
            this.salvarPanel.Name = "salvarPanel";
            this.salvarPanel.Size = new System.Drawing.Size(413, 47);
            this.salvarPanel.TabIndex = 2;
            // 
            // dataNascDtp
            // 
            this.dataNascDtp.Location = new System.Drawing.Point(125, 53);
            this.dataNascDtp.Name = "dataNascDtp";
            this.dataNascDtp.Size = new System.Drawing.Size(276, 20);
            this.dataNascDtp.TabIndex = 3;
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(56, 18);
            this.nomeTxt.MaxLength = 100;
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(345, 20);
            this.nomeTxt.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.Location = new System.Drawing.Point(338, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 47);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // AltFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 145);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.dataNascDtp);
            this.Controls.Add(this.salvarPanel);
            this.Controls.Add(this.dataNascLbl);
            this.Controls.Add(this.nomeLbl);
            this.Name = "AltFuncionario";
            this.Text = "Alterar Funcionário";
            this.salvarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLbl;
        private System.Windows.Forms.Label dataNascLbl;
        private System.Windows.Forms.Panel salvarPanel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dataNascDtp;
        private System.Windows.Forms.TextBox nomeTxt;
    }
}