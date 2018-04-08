namespace Urna
{
    partial class FormApuração
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
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalVotos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLista
            // 
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Location = new System.Drawing.Point(22, 85);
            this.gridLista.Margin = new System.Windows.Forms.Padding(4);
            this.gridLista.Name = "gridLista";
            this.gridLista.Size = new System.Drawing.Size(503, 168);
            this.gridLista.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(163, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Apuração dos Votos";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(22, 23);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(68, 30);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(177, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Total de Votos:";
            // 
            // lblTotalVotos
            // 
            this.lblTotalVotos.AutoSize = true;
            this.lblTotalVotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalVotos.Location = new System.Drawing.Point(330, 267);
            this.lblTotalVotos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVotos.Name = "lblTotalVotos";
            this.lblTotalVotos.Size = new System.Drawing.Size(23, 25);
            this.lblTotalVotos.TabIndex = 37;
            this.lblTotalVotos.Text = "0";
            // 
            // FormApuração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 301);
            this.Controls.Add(this.lblTotalVotos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridLista);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormApuração";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apuração dos Votos";
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalVotos;
    }
}