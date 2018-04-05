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
            txtCpf.UseSystemPasswordChar = true;
            //txtSenha.PasswordChar = '*';
            txtCpf.MaxLength = 11;
            txtCpf.TextAlign = HorizontalAlignment.Center;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
           // //DataSet dados = new DataSet();

           //// dados = usr.verificaUsuario(txtCpf.Text);

           // //if (dados.Tables[0].Rows.Count == 0) {
           //   //  MessageBox.Show("Login Incorreto!");
           //     //txtCpf.Text = null;
           //     txtCpf.Focus();
           // }
           // else {
           //     this.Hide();
           //     //FormPrincipal formPrincipal = new FormPrincipal();
           //     //formPrincipal.Show();
           //     //FormPrincipal formGerenciaUsuario = new FormGerenciaUsuario(txtLogin.Text);
           //     //formGerenciaUsuario.Show();
            }
        }

        //private void btnSair_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void lblSaudacao_Click(object sender, EventArgs e)
        //{

        //}
    }
}
