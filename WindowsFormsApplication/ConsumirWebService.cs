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
    public partial class ConsumirWebService : Form
    {
        public ConsumirWebService()
        {
            InitializeComponent();
        }
        
        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            MeuWebService.WebService1 meuWS = new MeuWebService.WebService1();
            txtResultado.Text = meuWS.subtrair(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            MeuWebService.WebService1 meuWS = new MeuWebService.WebService1();
            txtResultado.Text = meuWS.somar(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            MeuWebService.WebService1 meuWS = new MeuWebService.WebService1();
            txtResultado.Text = meuWS.multiplicar(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            MeuWebService.WebService1 meuWS = new MeuWebService.WebService1();
            txtResultado.Text = meuWS.dividir(Convert.ToInt32(txtNum1.Text), Convert.ToInt32(txtNum2.Text)).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
