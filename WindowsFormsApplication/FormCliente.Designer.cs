namespace WindowsFormsApplication
{
    partial class FormCliente
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
            this.gridProfessor = new System.Windows.Forms.DataGridView();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.btnCarregaDados = new System.Windows.Forms.Button();
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.gridFuncionario = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProfessor
            // 
            this.gridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfessor.Location = new System.Drawing.Point(21, 88);
            this.gridProfessor.Name = "gridProfessor";
            this.gridProfessor.RowTemplate.Height = 24;
            this.gridProfessor.Size = new System.Drawing.Size(557, 172);
            this.gridProfessor.TabIndex = 0;
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(259, 33);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(166, 32);
            this.lblProfessor.TabIndex = 1;
            this.lblProfessor.Text = "Professores";
            // 
            // btnCarregaDados
            // 
            this.btnCarregaDados.Location = new System.Drawing.Point(21, 24);
            this.btnCarregaDados.Name = "btnCarregaDados";
            this.btnCarregaDados.Size = new System.Drawing.Size(148, 41);
            this.btnCarregaDados.TabIndex = 2;
            this.btnCarregaDados.Text = "Carrega Dados";
            this.btnCarregaDados.UseVisualStyleBackColor = true;
            this.btnCarregaDados.Click += new System.EventHandler(this.btnCarregaDados_Click);
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarios.Location = new System.Drawing.Point(194, 295);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(179, 32);
            this.lblFuncionarios.TabIndex = 4;
            this.lblFuncionarios.Text = "Funcionários";
            // 
            // gridFuncionario
            // 
            this.gridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionario.Location = new System.Drawing.Point(21, 348);
            this.gridFuncionario.Name = "gridFuncionario";
            this.gridFuncionario.RowTemplate.Height = 24;
            this.gridFuncionario.Size = new System.Drawing.Size(587, 176);
            this.gridFuncionario.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFuncionarios);
            this.Controls.Add(this.gridFuncionario);
            this.Controls.Add(this.btnCarregaDados);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.gridProfessor);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProfessor;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Button btnCarregaDados;
        private System.Windows.Forms.Label lblFuncionarios;
        private System.Windows.Forms.DataGridView gridFuncionario;
        private System.Windows.Forms.Button button1;
    }
}