namespace Urna
{
    partial class FormLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.btnApuracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(115, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCpf.Location = new System.Drawing.Point(55, 170);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(213, 34);
            this.txtCpf.TabIndex = 2;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEntrar.Location = new System.Drawing.Point(175, 239);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(93, 44);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSair.Location = new System.Drawing.Point(55, 239);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 44);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSaudacao.Location = new System.Drawing.Point(100, 11);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(31, 29);
            this.lblSaudacao.TabIndex = 6;
            this.lblSaudacao.Text = "   ";
            // 
            // btnApuracao
            // 
            this.btnApuracao.Location = new System.Drawing.Point(188, 49);
            this.btnApuracao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApuracao.Name = "btnApuracao";
            this.btnApuracao.Size = new System.Drawing.Size(108, 30);
            this.btnApuracao.TabIndex = 24;
            this.btnApuracao.Text = "Apuração";
            this.btnApuracao.UseVisualStyleBackColor = true;
            this.btnApuracao.Click += new System.EventHandler(this.btnApuracao_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 340);
            this.Controls.Add(this.btnApuracao);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpf);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Button btnApuracao;
    }
}