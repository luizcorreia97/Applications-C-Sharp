namespace OficinaMecanica
{
    partial class GerenciarOrdemServico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFinalizacao = new System.Windows.Forms.DateTimePicker();
            this.dateAbertura = new System.Windows.Forms.DateTimePicker();
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.maskedPlaca = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(152, 108);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(79, 29);
            this.lblLogin.TabIndex = 44;
            this.lblLogin.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(240, 106);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(312, 34);
            this.txtNome.TabIndex = 47;
            // 
            // cmbMarca
            // 
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(925, 108);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(190, 33);
            this.cmbMarca.TabIndex = 43;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(90, 104);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(39, 34);
            this.txtId.TabIndex = 40;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(939, 264);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 46);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(939, 194);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 46);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(830, 109);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(82, 29);
            this.lblTipo.TabIndex = 42;
            this.lblTipo.Text = "Marca:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(575, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 29);
            this.lblNome.TabIndex = 29;
            this.lblNome.Text = "Placa:";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.BackColor = System.Drawing.Color.Gray;
            this.btnLimparCampos.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimparCampos.Location = new System.Drawing.Point(875, 347);
            this.btnLimparCampos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(240, 42);
            this.btnLimparCampos.TabIndex = 38;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = false;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(39, 166);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(192, 29);
            this.lblSenha.TabIndex = 31;
            this.lblSenha.Text = "Data de Abertura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(231, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 50);
            this.label2.TabIndex = 41;
            this.label2.Text = "Gerenciar Ordem de Serviço - Veículo";
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha2.Location = new System.Drawing.Point(395, 357);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(215, 29);
            this.lblSenha2.TabIndex = 34;
            this.lblSenha2.Text = "Data de Finalização:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nº:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(142, 353);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(185, 33);
            this.cmbStatus.TabIndex = 53;
            this.cmbStatus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cmbStatus_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 52;
            this.label3.Text = "Status:";
            // 
            // dateFinalizacao
            // 
            this.dateFinalizacao.Enabled = false;
            this.dateFinalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateFinalizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFinalizacao.Location = new System.Drawing.Point(648, 359);
            this.dateFinalizacao.Name = "dateFinalizacao";
            this.dateFinalizacao.Size = new System.Drawing.Size(165, 30);
            this.dateFinalizacao.TabIndex = 54;
            // 
            // dateAbertura
            // 
            this.dateAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAbertura.Location = new System.Drawing.Point(252, 166);
            this.dateAbertura.Name = "dateAbertura";
            this.dateAbertura.Size = new System.Drawing.Size(170, 30);
            this.dateAbertura.TabIndex = 55;
            // 
            // gridLista
            // 
            this.gridLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Location = new System.Drawing.Point(12, 414);
            this.gridLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridLista.Name = "gridLista";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridLista.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLista.RowTemplate.Height = 24;
            this.gridLista.Size = new System.Drawing.Size(1128, 316);
            this.gridLista.TabIndex = 56;
            this.gridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLista_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 29);
            this.label4.TabIndex = 57;
            this.label4.Text = "Descrição Problema:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(296, 224);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(517, 111);
            this.txtDescricao.TabIndex = 58;
            // 
            // maskedPlaca
            // 
            this.maskedPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedPlaca.Location = new System.Drawing.Point(651, 107);
            this.maskedPlaca.Name = "maskedPlaca";
            this.maskedPlaca.Size = new System.Drawing.Size(144, 30);
            this.maskedPlaca.TabIndex = 59;
            // 
            // GerenciarOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 741);
            this.Controls.Add(this.maskedPlaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.gridLista);
            this.Controls.Add(this.dateAbertura);
            this.Controls.Add(this.dateFinalizacao);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSenha2);
            this.MaximizeBox = false;
            this.Name = "GerenciarOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Ordem de Serviço - Veículo";
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSenha2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFinalizacao;
        private System.Windows.Forms.DateTimePicker dateAbertura;
        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox maskedPlaca;
    }
}

