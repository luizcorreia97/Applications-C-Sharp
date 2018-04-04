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
            this.gridLista.Location = new System.Drawing.Point(12, 163);
            this.gridLista.Name = "gridLista";
            this.gridLista.Size = new System.Drawing.Size(424, 181);
            this.gridLista.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnListar.Location = new System.Drawing.Point(118, 69);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(80, 28);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLimpar.Location = new System.Drawing.Point(257, 69);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 28);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(91, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Busca Data Set - Web Service";
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(72, 116);
            this.txtAluno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAluno.Multiline = true;
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(297, 28);
            this.txtAluno.TabIndex = 34;
            this.txtAluno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtAluno_PreviewKeyDown);
            // 
            // MeuDataService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 363);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.gridLista);
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