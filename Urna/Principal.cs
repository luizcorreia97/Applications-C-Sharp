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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            txtNumero.MaxLength = 2;
        }

        Eleicao eleicao = new Eleicao();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCandidato_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + "6";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + "0";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtNumero.Text + "7";
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtNumero.Text = null;
            txtCandidato.Text = null;
            txtPartido.Text = null;
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnBuscaCandidato_Click(object sender, EventArgs e)
        {
            eleicao.BuscaCandidato(Convert.ToInt32(txtNumero.Text));

            txtCandidato.Text = eleicao.candidato.ToString();
            txtPartido.Text = eleicao.partido.ToString();
        }
    }
}
