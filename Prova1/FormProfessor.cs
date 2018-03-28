using Minhas_Classes;
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
        Minhas_Classes.Professor prof = new Minhas_Classes.Professor();

        

        public FormProfessor(int idProfessor, string nome, int idade, char sexo)
        {
            InitializeComponent();
           

            //MessageBox.Show("Parâmetros:" + idProfessor + nome + idade + sexo);
        }
        
        public void LimpaCampos() {
            txtId.Text = "";
            txtNome.Text = "";
            txtIdade.Text = "";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Minhas_Classes.Professor prof = new Minhas_Classes.Professor();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            txtId.Text = prof.idProfessor.ToString();
            txtNome.Text = prof.nome.ToString();
            txtIdade.Text = prof.idade.ToString();
            cmbSexo.Text = prof.sexo.ToString();

            prof.idProfessor = Convert.ToInt32(txtId);
            prof.nome = txtNome.Text;
            prof.idade = Convert.ToInt32(txtIdade.Text);
            prof.sexo = Convert.ToChar(cmbSexo.Text);
            
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Minhas_Classes.Professor prof = new Minhas_Classes.Professor();

            if (txtId.Text == "") {

                prof.nome = txtNome.Text;
                prof.idade = Convert.ToInt32(txtIdade.Text);
                prof.sexo = Convert.ToChar(cmbSexo.Text);
                prof.Salvar();
                MessageBox.Show("Professor " + txtNome.Text + " Salvo com sucesso.");
            }

            else {

                prof.idProfessor = Convert.ToInt32(txtId.Text);
                prof.nome = txtNome.Text;
                prof.idade = Convert.ToInt32(txtIdade.Text);
                prof.sexo = Convert.ToChar(cmbSexo.Text);
                prof.Alterar();
                MessageBox.Show("Professor " + txtNome.Text + " Alterado com sucesso.");
            }
            
            LimpaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja apagar" + txtNome.Text,
                      "kakakak", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    prof.Deletar();
                    MessageBox.Show("Professor " + txtNome.Text + " Deletado.");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Professor " + txtNome.Text  + " Conversado.");
                    break;
            }
            
           LimpaCampos();
        }
        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Minhas_Classes.Professor prof = new Minhas_Classes.Professor();
            prof.idProfessor = Convert.ToInt32(txtId.Text);
            prof.nome = txtNome.Text;
            prof.idade = Convert.ToInt32(txtIdade.Text);
            prof.sexo = Convert.ToChar(cmbSexo.Text);
            prof.Alterar();
            LimpaCampos();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
