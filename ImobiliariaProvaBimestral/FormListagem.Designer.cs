namespace ImobiliariaProvaBimestral
{
    partial class FormListagem
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
            this.txtBuscaBairro = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.gridImovel = new System.Windows.Forms.DataGridView();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridImovel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscaBairro
            // 
            this.txtBuscaBairro.Location = new System.Drawing.Point(266, 98);
            this.txtBuscaBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscaBairro.Multiline = true;
            this.txtBuscaBairro.Name = "txtBuscaBairro";
            this.txtBuscaBairro.Size = new System.Drawing.Size(321, 34);
            this.txtBuscaBairro.TabIndex = 34;
            this.txtBuscaBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscaBairro_KeyDown);
            this.txtBuscaBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscaBairro_KeyPress);
            this.txtBuscaBairro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscaBairro_KeyUp);
            this.txtBuscaBairro.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBuscaBairro_PreviewKeyDown);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Green;
            this.btnNovo.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(639, 262);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(197, 39);
            this.btnNovo.TabIndex = 33;
            this.btnNovo.Text = "Novo Imóvel";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.lblProfessor.Location = new System.Drawing.Point(211, 25);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(569, 50);
            this.lblProfessor.TabIndex = 32;
            this.lblProfessor.Text = "Imóveis - Imobiliária MundoLar";
            // 
            // gridImovel
            // 
            this.gridImovel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImovel.Location = new System.Drawing.Point(12, 324);
            this.gridImovel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridImovel.Name = "gridImovel";
            this.gridImovel.RowTemplate.Height = 24;
            this.gridImovel.Size = new System.Drawing.Size(1535, 270);
            this.gridImovel.TabIndex = 31;
            this.gridImovel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridImovel_CellContentClick);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lblSenha.Location = new System.Drawing.Point(223, 19);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(97, 37);
            this.lblSenha.TabIndex = 60;
            this.lblSenha.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Bairro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "",
            "Em Aberto",
            "Locado"});
            this.cmbStatus.Location = new System.Drawing.Point(13, 98);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(190, 37);
            this.cmbStatus.TabIndex = 77;
            this.cmbStatus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbStatus_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.txtBuscaBairro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 207);
            this.panel1.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(118, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 39);
            this.button1.TabIndex = 79;
            this.button1.Text = "Limpar Filtros";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.gridImovel);
            this.Name = "FormListagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imobiliária";
            ((System.ComponentModel.ISupportInitialize)(this.gridImovel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscaBairro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.DataGridView gridImovel;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

