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
            gridProfessor.DataSource = prof.Buscar().Tables[0];
            gridAluno.DataSource = aluno.Buscar().Tables[0];
            gridFuncionario.DataSource = func.Buscar().Tables[0];
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfessor formProfessor = new FormProfessor(prof.idProfessor, prof.nome, prof.idade, prof.sexo);
            formProfessor.Show();
        }

        private void gridProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            prof.idProfessor = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
            prof.nome = dgv.CurrentRow.Cells[1].Value.ToString();
            prof.idade = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
            prof.sexo = Convert.ToChar(dgv.CurrentRow.Cells[3].Value.ToString());

            //MessageBox.Show("Parâmetros:" + prof.idProfessor + prof.nome + prof.idade + prof.sexo);

            //this.Hide();
            FormProfessor formProfessor = new FormProfessor(prof.idProfessor, prof.nome, prof.idade, prof.sexo);
            //formPrincipal.Show();
            formProfessor.Show();


        }
    }
}
