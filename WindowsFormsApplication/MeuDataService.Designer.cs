namespace WindowsFormsApplication
{
    partial class MeuDataService
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAluno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLista
            // 
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Location = new System.Drawing.Point(16, 201);
            this.gridLista.Margin = new System.Windows.Forms.Padding(4);
            this.gridLista.Name = "gridLista";
            this.gridLista.Size = new System.Drawing.Size(565, 223);
            this.gridLista.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnListar.Location = new System.Drawing.Point(157, 85);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(107, 34);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLimpar.Location = new System.Drawing.Point(343, 85);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 34);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(121, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Busca Data Set - Web Service";
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(96, 143);
            this.txtAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAluno.Multiline = true;
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(395, 34);
            this.txtAluno.TabIndex = 34;
            this.txtAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluno_KeyPress);
            // 
            // MeuDataService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 447);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gridLista);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeuDataService";
            this.Text = "MeuDataService";
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAluno;
    }
}