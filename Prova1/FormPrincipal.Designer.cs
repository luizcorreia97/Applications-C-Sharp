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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProfessor
            // 
            this.gridProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfessor.Location = new System.Drawing.Point(11, 97);
            this.gridProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridProfessor.Name = "gridProfessor";
            this.gridProfessor.RowTemplate.Height = 24;
            this.gridProfessor.Size = new System.Drawing.Size(532, 166);
            this.gridProfessor.TabIndex = 0;
            this.gridProfessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfessor_CellContentClick);
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.lblProfessor.Location = new System.Drawing.Point(140, 0);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(215, 50);
            this.lblProfessor.TabIndex = 18;
            this.lblProfessor.Text = "Professores";
            // 
            // gridAluno
            // 
            this.gridAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAluno.Location = new System.Drawing.Point(12, 362);
            this.gridAluno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridAluno.Name = "gridAluno";
            this.gridAluno.RowTemplate.Height = 24;
            this.gridAluno.Size = new System.Drawing.Size(532, 166);
            this.gridAluno.TabIndex = 20;
            // 
            // gridFuncionario
            // 
            this.gridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionario.Location = new System.Drawing.Point(12, 625);
            this.gridFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridFuncionario.Name = "gridFuncionario";
            this.gridFuncionario.RowTemplate.Height = 24;
            this.gridFuncionario.Size = new System.Drawing.Size(533, 166);
            this.gridFuncionario.TabIndex = 21;
            // 
            // btnProfessor
            // 
            this.btnProfessor.BackColor = System.Drawing.Color.Green;
            this.btnProfessor.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.ForeColor = System.Drawing.Color.White;
            this.btnProfessor.Location = new System.Drawing.Point(442, 53);
            this.btnProfessor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(102, 40);
            this.btnProfessor.TabIndex = 23;
            this.btnProfessor.Text = "Novo";
            this.btnProfessor.UseVisualStyleBackColor = false;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(11, 53);
            this.txtProfessor.Multiline = true;
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(395, 34);
            this.txtProfessor.TabIndex = 30;
            this.txtProfessor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProfessor_KeyDown);
            this.txtProfessor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfessor_KeyPress);
            this.txtProfessor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProfessor_KeyUp);
            this.txtProfessor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtProfessor_PreviewKeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 318);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 34);
            this.textBox1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(441, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 32;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(167, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 50);
            this.label1.TabIndex = 31;
            this.label1.Text = "Alunos";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 581);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(395, 34);
            this.textBox2.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(441, 581);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 40);
            this.button2.TabIndex = 35;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(139, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 50);
            this.label2.TabIndex = 34;
            this.label2.Text = "Funcionários";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 801);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.gridFuncionario);
            this.Controls.Add(this.gridAluno);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.gridProfessor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}