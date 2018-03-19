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
    public partial class Form1 : Form
    {
        public int nota1, nota2, media;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            txtDestino.Text = txtOrigem.Text;

            nota1 = Convert.ToInt32(txtOrigem.Text);
            nota2 = Convert.ToInt32(txtDestino.Text);

            media = (nota1 + nota2) / 2;

            if (media >= 70)
            {
                txtMedia.Text = "Aprovado! Sua média foi:" + media;
                txtMedia.BackColor = Color.Green;
                txtMedia.ForeColor = Color.White;
            }

            else if (media >= 30)
            {
                txtMedia.Text = "Recuperação! Sua média foi:" + media;
                txtMedia.BackColor = Color.Yellow;
                txtMedia.ForeColor = Color.Black;
            }

            else if (media < 30)
            {
                txtMedia.Text = "Reprovado! Sua média foi:" + media;
                txtMedia.BackColor = Color.Red;
                txtMedia.ForeColor = Color.White;
            }

            //txtOrigem.Width = txtDestino.Width;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtOrigem.Text = null;
            txtDestino.Text = null;
            txtMedia.Text = null;

            nota1 = 0;
            nota2 = 0;
            media = 0;

            txtMedia.BackColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblDestino.Text = txtOrigem.Text;
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
