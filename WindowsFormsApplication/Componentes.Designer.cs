namespace WindowsFormsApplication
{
    partial class Componentes
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
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.btnMateira = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.btnSelecionado = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.cmbBuscado = new System.Windows.Forms.ComboBox();
            this.chkSharp = new System.Windows.Forms.CheckBox();
            this.chkPHP = new System.Windows.Forms.CheckBox();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMarcaTodos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(64, 145);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(142, 24);
            this.cmbMateria.TabIndex = 0;
            // 
            // btnMateira
            // 
            this.btnMateira.Location = new System.Drawing.Point(64, 73);
            this.btnMateira.Name = "btnMateira";
            this.btnMateira.Size = new System.Drawing.Size(142, 44);
            this.btnMateira.TabIndex = 1;
            this.btnMateira.Text = "Carrega Matérias";
            this.btnMateira.UseVisualStyleBackColor = true;
            this.btnMateira.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Location = new System.Drawing.Point(64, 211);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(142, 44);
            this.btnProfessor.TabIndex = 3;
            this.btnProfessor.Text = "Carrega Professores";
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbProfessor.Location = new System.Drawing.Point(64, 283);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(142, 24);
            this.cmbProfessor.TabIndex = 2;
            // 
            // btnSelecionado
            // 
            this.btnSelecionado.Location = new System.Drawing.Point(64, 336);
            this.btnSelecionado.Name = "btnSelecionado";
            this.btnSelecionado.Size = new System.Drawing.Size(146, 44);
            this.btnSelecionado.TabIndex = 4;
            this.btnSelecionado.Text = "Selecionado";
            this.btnSelecionado.UseVisualStyleBackColor = true;
            this.btnSelecionado.Click += new System.EventHandler(this.btnSelecionado_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(64, 461);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(146, 44);
            this.btnLimpa.TabIndex = 5;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // cmbBuscado
            // 
            this.cmbBuscado.FormattingEnabled = true;
            this.cmbBuscado.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbBuscado.Location = new System.Drawing.Point(64, 412);
            this.cmbBuscado.Name = "cmbBuscado";
            this.cmbBuscado.Size = new System.Drawing.Size(142, 24);
            this.cmbBuscado.TabIndex = 6;
            // 
            // chkSharp
            // 
            this.chkSharp.AutoSize = true;
            this.chkSharp.Location = new System.Drawing.Point(349, 234);
            this.chkSharp.Name = "chkSharp";
            this.chkSharp.Size = new System.Drawing.Size(47, 21);
            this.chkSharp.TabIndex = 7;
            this.chkSharp.Text = "C#";
            this.chkSharp.UseVisualStyleBackColor = true;
            // 
            // chkPHP
            // 
            this.chkPHP.AutoSize = true;
            this.chkPHP.Location = new System.Drawing.Point(349, 272);
            this.chkPHP.Name = "chkPHP";
            this.chkPHP.Size = new System.Drawing.Size(58, 21);
            this.chkPHP.TabIndex = 8;
            this.chkPHP.Text = "PHP";
            this.chkPHP.UseVisualStyleBackColor = true;
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Location = new System.Drawing.Point(349, 310);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(60, 21);
            this.chkJava.TabIndex = 9;
            this.chkJava.Text = "Java";
            this.chkJava.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(349, 359);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(92, 21);
            this.rbtnMasculino.TabIndex = 10;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(462, 359);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(86, 21);
            this.rbtnFeminino.TabIndex = 11;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Checar Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMarcaTodos
            // 
            this.btnMarcaTodos.Location = new System.Drawing.Point(502, 134);
            this.btnMarcaTodos.Name = "btnMarcaTodos";
            this.btnMarcaTodos.Size = new System.Drawing.Size(142, 44);
            this.btnMarcaTodos.TabIndex = 13;
            this.btnMarcaTodos.Text = "Fazer Check";
            this.btnMarcaTodos.UseVisualStyleBackColor = true;
            this.btnMarcaTodos.Click += new System.EventHandler(this.btnMarcaTodos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(349, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Componentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMarcaTodos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtnFeminino);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.chkJava);
            this.Controls.Add(this.chkPHP);
            this.Controls.Add(this.chkSharp);
            this.Controls.Add(this.cmbBuscado);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnSelecionado);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.cmbProfessor);
            this.Controls.Add(this.btnMateira);
            this.Controls.Add(this.cmbMateria);
            this.Name = "Componentes";
            this.Text = "Componentes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Button btnMateira;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.Button btnSelecionado;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.ComboBox cmbBuscado;
        private System.Windows.Forms.CheckBox chkSharp;
        private System.Windows.Forms.CheckBox chkPHP;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMarcaTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}