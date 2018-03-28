namespace Prova1
{
    partial class FormPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridAluno = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gridFuncionario = new System.Windows.Forms.DataGridView();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProfessor
            // 
            this.gridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfessor.Location = new System.Drawing.Point(16, 97);
            this.gridProfessor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridProfessor.Name = "gridProfessor";
            this.gridProfessor.RowTemplate.Height = 24;
            this.gridProfessor.Size = new System.Drawing.Size(543, 129);
            this.gridProfessor.TabIndex = 0;
            this.gridProfessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfessor_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(196, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 41);
            this.label2.TabIndex = 18;
            this.label2.Text = "Professores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(210, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "Alunos";
            // 
            // gridAluno
            // 
            this.gridAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAluno.Location = new System.Drawing.Point(9, 320);
            this.gridAluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridAluno.Name = "gridAluno";
            this.gridAluno.RowTemplate.Height = 24;
            this.gridAluno.Size = new System.Drawing.Size(550, 130);
            this.gridAluno.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(196, 462);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 41);
            this.label3.TabIndex = 22;
            this.label3.Text = "Funcionários";
            // 
            // gridFuncionario
            // 
            this.gridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionario.Location = new System.Drawing.Point(9, 547);
            this.gridFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridFuncionario.Name = "gridFuncionario";
            this.gridFuncionario.RowTemplate.Height = 24;
            this.gridFuncionario.Size = new System.Drawing.Size(543, 130);
            this.gridFuncionario.TabIndex = 21;
            // 
            // btnProfessor
            // 
            this.btnProfessor.BackColor = System.Drawing.Color.Gray;
            this.btnProfessor.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.Color.White;
            this.btnProfessor.Location = new System.Drawing.Point(427, 56);
            this.btnProfessor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(132, 34);
            this.btnProfessor.TabIndex = 23;
            this.btnProfessor.Text = "Gerenciar";
            this.btnProfessor.UseVisualStyleBackColor = false;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.Gray;
            this.btnAluno.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.Color.White;
            this.btnAluno.Location = new System.Drawing.Point(427, 270);
            this.btnAluno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(132, 34);
            this.btnAluno.TabIndex = 24;
            this.btnAluno.Text = "Gerenciar";
            this.btnAluno.UseVisualStyleBackColor = false;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Gray;
            this.btnFuncionario.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnFuncionario.Location = new System.Drawing.Point(427, 508);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(125, 34);
            this.btnFuncionario.TabIndex = 25;
            this.btnFuncionario.Text = "Gerenciar";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 694);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridFuncionario);
            this.Controls.Add(this.gridAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridProfessor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridAluno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridFuncionario;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnFuncionario;
    }
}