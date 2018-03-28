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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;
            //txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 10;
            txtLogin.TextAlign = HorizontalAlignment.Center;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            txtLogin.CharacterCasing = CharacterCasing.Lower;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Minhas_Classes.Usuario usr = new Minhas_Classes.Usuario();
            DataSet dados = new DataSet();

            dados = usr.verificaUsuario(txtLogin.Text, txtSenha.Text);

            if (dados.Tables[0].Rows.Count == 0) {
                MessageBox.Show("Login Incorreto!");
                txtLogin.Text = null;
                txtSenha.Text = null;
                txtLogin.Focus();
            }
            else {
                this.Hide();
                //FormPrincipal formPrincipal = new FormPrincipal();
                //formPrincipal.Show();
                FormGerenciaUsuario formGerenciaUsuario = new FormGerenciaUsuario(txtLogin.Text);
                formGerenciaUsuario.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSaudacao_Click(object sender, EventArgs e)
        {

        }
    }
}
