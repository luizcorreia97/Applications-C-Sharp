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
            this.lblProfessor = new System.Windows.Forms.Label();
            this.gridAluno = new System.Windows.Forms.DataGridView();
            this.gridFuncionario = new System.Windows.Forms.DataGridView();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.btnAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProfessor
            // 
            this.gridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfessor.Location = new System.Drawing.Point(8, 79);
            this.gridProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.gridProfessor.Name = "gridProfessor";
            this.gridProfessor.RowTemplate.Height = 24;
            this.gridProfessor.Size = new System.Drawing.Size(399, 135);
            this.gridProfessor.TabIndex = 0;
            this.gridProfessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfessor_CellContentClick);
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.lblProfessor.Location = new System.Drawing.Point(105, 0);
            this.lblProfessor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(172, 41);
            this.lblProfessor.TabIndex = 18;
            this.lblProfessor.Text = "Professores";
            // 
            // gridAluno
            // 
            this.gridAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAluno.Location = new System.Drawing.Point(9, 294);
            this.gridAluno.Margin = new System.Windows.Forms.Padding(2);
            this.gridAluno.Name = "gridAluno";
            this.gridAluno.RowTemplate.Height = 24;
            this.gridAluno.Size = new System.Drawing.Size(399, 135);
            this.gridAluno.TabIndex = 20;
            this.gridAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAluno_CellContentClick);
            // 
            // gridFuncionario
            // 
            this.gridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionario.Location = new System.Drawing.Point(9, 508);
            this.gridFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.gridFuncionario.Name = "gridFuncionario";
            this.gridFuncionario.RowTemplate.Height = 24;
            this.gridFuncionario.Size = new System.Drawing.Size(400, 135);
            this.gridFuncionario.TabIndex = 21;
            this.gridFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFuncionario_CellContentClick);
            // 
            // btnProfessor
            // 
            this.btnProfessor.BackColor = System.Drawing.Color.Green;
            this.btnProfessor.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.Color.White;
            this.btnProfessor.Location = new System.Drawing.Point(332, 43);
            this.btnProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(76, 32);
            this.btnProfessor.TabIndex = 23;
            this.btnProfessor.Text = "Novo";
            this.btnProfessor.UseVisualStyleBackColor = false;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(8, 43);
            this.txtProfessor.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfessor.Multiline = true;
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(297, 28);
            this.txtProfessor.TabIndex = 30;
            this.txtProfessor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProfessor_KeyDown);
            this.txtProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfessor_KeyPress);
            this.txtProfessor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProfessor_KeyUp);
            this.txtProfessor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtProfessor_PreviewKeyDown);
            // 
            // txtAluno
            // 
            this.txtAluno.Location = new System.Drawing.Point(9, 258);
            this.txtAluno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAluno.Multiline = true;
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(297, 28);
            this.txtAluno.TabIndex = 33;
            this.txtAluno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAluno_KeyDown);
            this.txtAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluno_KeyPress);
            this.txtAluno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAluno_KeyUp);
            this.txtAluno.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtAluno_PreviewKeyDown);
            // 
            // btnAluno
            // 
            this.btnAluno.BackColor = System.Drawing.Color.Green;
            this.btnAluno.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.Color.White;
            this.btnAluno.Location = new System.Drawing.Point(331, 258);
            this.btnAluno.Margin = new System.Windows.Forms.Padding(2);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(76, 32);
            this.btnAluno.TabIndex = 32;
            this.btnAluno.Text = "Novo";
            this.btnAluno.UseVisualStyleBackColor = false;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(125, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 41);
            this.label1.TabIndex = 31;
            this.label1.Text = "Alunos";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(8, 472);
            this.txtFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuncionario.Multiline = true;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(297, 28);
            this.txtFuncionario.TabIndex = 36;
            this.txtFuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFuncionario_KeyDown);
            this.txtFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFuncionario_KeyPress);
            this.txtFuncionario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFuncionario_KeyUp);
            this.txtFuncionario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtFuncionario_PreviewKeyDown);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Green;
            this.btnFuncionario.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnFuncionario.Location = new System.Drawing.Point(331, 472);
            this.btnFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(76, 32);
            this.btnFuncionario.TabIndex = 35;
            this.btnFuncionario.Text = "Novo";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(104, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 41);
            this.label2.TabIndex = 34;
            this.label2.Text = "Funcionários";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 651);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.gridFuncionario);
            this.Controls.Add(this.gridAluno);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.gridProfessor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProfessor;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.DataGridView gridAluno;
        private System.Windows.Forms.DataGridView gridFuncionario;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Label label2;
    }
}