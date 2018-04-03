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
    public partial class FormProfessor : Form
    {
        Professor prof = new Professor();

        public FormProfessor()
        {
            InitializeComponent();
        }

        public FormProfessor(Professor prof)
        {
            InitializeComponent();

            lblTitulo.Text = "Gerenciar Professor";
            txtId.Text = Convert.ToInt32(prof.idProfessor).ToString();
            txtNome.Text = prof.nome;
            txtIdade.Text = Convert.ToInt32(prof.idade).ToString();
            cmbSexo.Text = Convert.ToChar(prof.sexo).ToString();
            
            //txtSeq.Text = prof.mostraID().ToString();
            //txtSeq.Text = Convert.ToInt32(prof.mostraID()).ToString();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            prof.nome = txtNome.Text;
            prof.idade = Convert.ToInt32(txtIdade.Text);
            prof.sexo = Convert.ToChar(cmbSexo.Text);

            if (txtId.Text == "") {

                prof.Salvar();
                MessageBox.Show("Professor " + txtNome.Text + " Salvo com sucesso.");
            }

            else {

                prof.idProfessor = Convert.ToInt32(txtId.Text);
                prof.Alterar();
                MessageBox.Show("Professor " + txtNome.Text + " Alterado com sucesso.");
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
                    prof.idProfessor = Convert.ToInt32(txtId.Text);
                    prof.Deletar();
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