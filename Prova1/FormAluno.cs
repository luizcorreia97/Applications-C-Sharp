using Prova1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FormAluno : Form
    {
        Aluno aluno = new Aluno();

        public FormAluno()
        {
            InitializeComponent();
        }

        public FormAluno(Aluno aluno)
        {
            InitializeComponent();

            lblTitulo.Text = "Gerenciar Aluno";
            txtId.Text = Convert.ToInt32(aluno.idAluno).ToString();
            txtNome.Text = aluno.nome;
            txtIdade.Text = Convert.ToInt32(aluno.idade).ToString();
            cmbSexo.Text = Convert.ToChar(aluno.sexo).ToString();

            //txtSeq.Text = Convert.ToInt32(aluno.mostraID()).ToString();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            aluno.nome = txtNome.Text;
            aluno.idade = Convert.ToInt32(txtIdade.Text);
            aluno.sexo = Convert.ToChar(cmbSexo.Text);

            if (txtId.Text == "") {

                aluno.Salvar();
                MessageBox.Show("Aluno " + txtNome.Text + " Salvo com sucesso.");
            }

            else {

                aluno.idAluno = Convert.ToInt32(txtId.Text);
                aluno.Alterar();
                MessageBox.Show("Aluno " + txtNome.Text + " Alterado com sucesso.");
            }

            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente apagar '" + txtNome.Text + "' ?", "ATENÇÃO", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    aluno.idAluno = Convert.ToInt32(txtId.Text);
                    aluno.Deletar();
                    MessageBox.Show("'" + txtNome.Text + "' Deletado com sucesso.");
                    break;
                case DialogResult.No:
                    MessageBox.Show("'" + txtNome.Text  + "' Conversado com sucesso.");
                    break;
            }

            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }
    }
}