using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication;

namespace Prova1
{
    public partial class FormPrincipal : Form
    {
        Professor prof = new Professor();
        Aluno aluno = new Aluno();
        Funcionario func = new Funcionario();

        public FormPrincipal()
        {
            InitializeComponent();
            gridVoto.DataSource = prof.Buscar().Tables[0];
            gridAluno.DataSource = aluno.Buscar().Tables[0];
            gridFuncionario.DataSource = func.Buscar().Tables[0];
        }

        public FormPrincipal(string nome)
        {
            InitializeComponent();
            gridVoto.DataSource = prof.Buscar().Tables[0];
            gridAluno.DataSource = aluno.Buscar().Tables[0];
            gridFuncionario.DataSource = func.Buscar().Tables[0];
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfessor formProfessor = new FormProfessor();
            formProfessor.Show();
        }

        private void gridProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            prof.idProfessor = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
            prof.nome = dgv.CurrentRow.Cells[1].Value.ToString();
            prof.idade = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
            prof.sexo = Convert.ToChar(dgv.CurrentRow.Cells[3].Value.ToString());

            this.Hide();
            FormProfessor formProfessor = new FormProfessor(prof);
            formProfessor.Show();
        }

        private void txtProfessor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            gridVoto.DataSource = prof.buscaNomeProfessor(txtProfessor.Text).Tables[0];
        }

        private void txtProfessor_KeyDown(object sender, KeyEventArgs e)
        {
            gridVoto.DataSource = prof.buscaNomeProfessor(txtProfessor.Text).Tables[0];
        }

        private void txtProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            gridVoto.DataSource = prof.buscaNomeProfessor(txtProfessor.Text).Tables[0];
        }

        private void txtProfessor_KeyUp(object sender, KeyEventArgs e)
        {
            gridVoto.DataSource = prof.buscaNomeProfessor(txtProfessor.Text).Tables[0];
        }

        private void gridAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            aluno.idAluno = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
            aluno.nome = dgv.CurrentRow.Cells[1].Value.ToString();
            aluno.idade = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
            aluno.sexo = Convert.ToChar(dgv.CurrentRow.Cells[3].Value.ToString());

            this.Hide();
            FormAluno formAluno = new FormAluno(aluno);
            formAluno.Show();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAluno formAluno = new FormAluno();
            formAluno.Show();
        }

        private void txtAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            gridAluno.DataSource = aluno.buscaNomeAluno(txtAluno.Text).Tables[0];
        }

        private void txtAluno_KeyDown(object sender, KeyEventArgs e)
        {
            gridAluno.DataSource = aluno.buscaNomeAluno(txtAluno.Text).Tables[0];
        }

        private void txtAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            gridAluno.DataSource = aluno.buscaNomeAluno(txtAluno.Text).Tables[0];
        }

        private void txtAluno_KeyUp(object sender, KeyEventArgs e)
        {
            gridAluno.DataSource = aluno.buscaNomeAluno(txtAluno.Text).Tables[0];
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFuncionario formFuncionario = new FormFuncionario();
            formFuncionario.Show();
        }

        private void txtFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            gridFuncionario.DataSource = func.buscaNomeFuncionario(txtFuncionario.Text).Tables[0];
        }

        private void txtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            gridFuncionario.DataSource = func.buscaNomeFuncionario(txtFuncionario.Text).Tables[0];
        }

        private void txtFuncionario_KeyUp(object sender, KeyEventArgs e)
        {
            gridFuncionario.DataSource = func.buscaNomeFuncionario(txtFuncionario.Text).Tables[0];
        }

        private void txtFuncionario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            gridFuncionario.DataSource = func.buscaNomeFuncionario(txtFuncionario.Text).Tables[0];
        }

        private void gridFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            func.idFuncionario = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
            func.nome = dgv.CurrentRow.Cells[1].Value.ToString();
            func.idade = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
            func.sexo = Convert.ToChar(dgv.CurrentRow.Cells[3].Value.ToString());

            this.Hide();
            FormFuncionario formFuncionario = new FormFuncionario(func);
            formFuncionario.Show();
        }
    }
}