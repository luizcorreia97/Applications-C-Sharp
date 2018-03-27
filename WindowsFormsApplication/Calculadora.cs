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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        float num = 0;
        float result = 0;
        private string op = "";
        bool vez = true;
        bool calcok = true;

        public void valida_calculo()
        {

            if (vez == true)
            {
                result = num;
                vez = false;
                calcok = true;
            }

            if (op == "+")
            {
                result += num;
                calcok = true;
            }

            if (op == "-")
            {
                result -= num;
                calcok = true;
            }

            if (op == "*")
            {
                result *= num;
                calcok = true;
            }

            if (op == "/")
            {
                if (num == 0)
                {
                    //Toast.makeText(getApplicationContext(), " I Can't Divide By Zero !!", Toast.LENGTH_LONG).show();
                    calcok = false;
                }
                else
                {
                    result /= num;
                    calcok = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + " 7";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + " 8";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + " 1";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + " 2";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + " 3";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + " 4";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + " 5";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + " 6";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + " 9";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + " 0";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //txtCima.Text = txtCima.Text + "/";
            //num = Convert.ToInt32(txtBaixo.Text);

            //txtCima.Text = txtCima.Text + "-";
            //num = Convert.ToInt32(txtBaixo.Text);

            valida_calculo();
            op = "/";

            if (calcok == true)
            {
                txtBaixo.Text = " = " + result;
                txtCima.Text = txtCima.Text + txtBaixo.Text + " /";
                txtBaixo.Text = "";
            }
            else
            {
                txtBaixo.Text = "";
                op = "";
            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            //txtCima.Text = txtCima.Text + "*";
            //num = Convert.ToInt32(txtBaixo.Text);

            //txtCima.Text = txtCima.Text + "-";
            //num = Convert.ToInt32(txtBaixo.Text);

            valida_calculo();
            op = "*";

            if (calcok == true)
            {
                txtBaixo.Text = " = " + result;
                txtCima.Text = txtCima.Text + txtBaixo.Text + " *";
                txtBaixo.Text = "";
            }
            else
            {
                txtBaixo.Text = "";
                op = "";
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            //txtCima.Text = txtCima.Text + "-";
            //num = Convert.ToInt32(txtBaixo.Text);

            valida_calculo();
            op = "-";

            if (calcok == true)
            {
                txtBaixo.Text = " = " + result;
                txtCima.Text = txtCima.Text + txtBaixo.Text + " -";
                txtBaixo.Text = "";
            }
            else
            {
                txtBaixo.Text = "";
                op = "";
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            //txtBaixo.Text = txtBaixo.Text + "+";
            //num = Convert.ToInt32(txtBaixo.Text);

           valida_calculo();
            op = "+";

            if (calcok == true)
            {
                txtBaixo.Text = " = " + result;
                txtCima.Text = txtCima.Text + txtBaixo.Text + " +";
                txtBaixo.Text = "";
            }
            else
            {
                txtBaixo.Text = "";
                op = "";
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtBaixo.Text = txtBaixo.Text + ".";
            num = Convert.ToInt32(txtBaixo.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCima.Text = "";
            txtBaixo.Text = "";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            valida_calculo();

            if (calcok == true)
            {
                txtBaixo.Text = "= " + result;
                txtCima.Text = txtCima + txtBaixo.Text + "=" + result;
                txtBaixo.Text = "";
                num = 0;
                calcok = false;
            }
            else
            {
                txtBaixo.Text = "";
            }
        }
    }
}
