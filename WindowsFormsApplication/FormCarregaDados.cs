using Minhas_Classes;
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
    public partial class FormCarregaDados : Form
    {
        public FormCarregaDados()
        {
            InitializeComponent();
        }

        Professor prof = new Professor();

        public void LimpaCampos() {
            txtId.Text = "";
            txtNome.Text = "";
            txtIdade.Text = "";
            txtBuscaNome.Text = "";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Minhas_Classes.Professor prof = new Minhas_Classes.Professor();
            dataGridView1.DataSource = prof.buscaProfessorNome(txtBuscaNome.Text).Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            txtId.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtIdade.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            cmbSexo.Text = dgv.CurrentRow.Cells[3].Value.ToString();

            prof.idProfessor = Convert.ToInt32(txtId.Text);
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
            
            dataGridView1.DataSource = prof.buscaProfessorNome(txtBuscaNome.Text).Tables[0];
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
            
           dataGridView1.DataSource = prof.buscaProfessorNome(txtBuscaNome.Text).Tables[0];
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
            dataGridView1.DataSource = prof.buscaProfessorNome(txtBuscaNome.Text).Tables[0];
            LimpaCampos();
        }

        private void FormCarregaDados_Layout(object sender, LayoutEventArgs e)
        {
            dataGridView1.DataSource = prof.buscaProfessorNome(txtBuscaNome.Text).Tables[0];
        }

        private void txtBuscaNome_Leave(object sender, EventArgs e)
        {
            Minhas_Classes.Professor prof = new Minhas_Classes.Professor();
            dataGridView1.DataSource = prof.buscaProfessorNome(txtBuscaNome.Text).Tables[0];
        }

        private void txtBuscaNome_Enter(object sender, EventArgs e)
        {
            Minhas_Classes.Professor prof = new Minhas_Classes.Professor();
            dataGridView1.DataSource = prof.buscaProfessorNome(txtBuscaNome.Text).Tables[0];
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
