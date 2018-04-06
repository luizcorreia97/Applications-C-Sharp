using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //txtCpf.UseSystemPasswordChar = true;
            //txtSenha.PasswordChar = '*';
            txtCpf.MaxLength = 11;
            txtCpf.TextAlign = HorizontalAlignment.Center;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Eleicao eleicao = new Eleicao();

            DataSet dados = new DataSet();

            dados = eleicao.verificaEleitor(txtCpf.Text);

            if (dados.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("CPF eleitor já votou!");
                txtCpf.Text = null;
                txtCpf.Focus();
            }
            else
            {
                this.Hide();
                Principal form = new Principal();
                form.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
