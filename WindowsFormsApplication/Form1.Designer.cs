namespace WindowsFormsApplication
{
    partial class Form1
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
            this.btnMensagem = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensagem
            // 
            this.btnMensagem.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMensagem.Font = new System.Drawing.Font("Palatino Linotype", 7.8F);
            this.btnMensagem.ForeColor = System.Drawing.Color.Black;
            this.btnMensagem.Location = new System.Drawing.Point(51, 38);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(141, 40);
            this.btnMensagem.TabIndex = 0;
            this.btnMensagem.Text = "Minha Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = false;
            this.btnMensagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(51, 158);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(290, 22);
            this.txtOrigem.TabIndex = 1;
            this.txtOrigem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(52, 219);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(290, 22);
            this.txtDestino.TabIndex = 2;
            this.txtDestino.TextChanged += new System.EventHandler(this.txtDestino_TextChanged);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.btnCopiar.Location = new System.Drawing.Point(150, 271);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(108, 31);
            this.btnCopiar.TabIndex = 3;
            this.btnCopiar.Text = "Calcular";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Font = new System.Drawing.Font("Palatino Linotype", 7.8F);
            this.lblOrigem.Location = new System.Drawing.Point(48, 128);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(56, 19);
            this.lblOrigem.TabIndex = 4;
            this.lblOrigem.Text = "Nota 1:";
            this.lblOrigem.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(48, 197);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(56, 19);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Nota 2:";
            this.lblDestino.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(51, 326);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(290, 22);
            this.txtMedia.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(248, 97);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(78, 31);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 375);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.btnMensagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button btnLimpar;
    }
}

