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
    public partial class FormFuncionario : Form
    {
        Funcionario func = new Funcionario();

        public FormFuncionario()
        {
            InitializeComponent();
        }

        public FormFuncionario(Funcionario func)
        {
            InitializeComponent();

            lblTitulo.Text = "Gerenciar Funcionario";
            txtId.Text = Convert.ToInt32(func.idFuncionario).ToString();
            txtNome.Text = func.nome;
            txtIdade.Text = Convert.ToInt32(func.idade).ToString();
            cmbSexo.Text = Convert.ToChar(func.sexo).ToString();

            //txtSeq.Text = Convert.ToInt32(func.mostraID()).ToString();
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            func.nome = txtNome.Text;
            func.idade = Convert.ToInt32(txtIdade.Text);
            func.sexo = Convert.ToChar(cmbSexo.Text);

            if (txtId.Text == "") {

                func.Salvar();
                MessageBox.Show("Funcionario " + txtNome.Text + " Salvo com sucesso.");
            }

            else {

                func.idFuncionario = Convert.ToInt32(txtId.Text);
                func.Alterar();
                MessageBox.Show("Funcionario " + txtNome.Text + " Alterado com sucesso.");
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
                    func.idFuncionario = Convert.ToInt32(txtId.Text);
                    func.Deletar();
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