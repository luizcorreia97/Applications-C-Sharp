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
            maskedTextBox.TextAlign = HorizontalAlignment.Center; // deixa caracteres centralizados            
            this.maskedTextBox.Mask = "000,000,000-00";
            maskedTextBox.Focus();
            maskedTextBox.Select();
        }

        //Botão Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.MaskCompleted)
            {
                Eleicao eleicao = new Eleicao();
                DataSet dados = new DataSet();
                dados = eleicao.verificaEleitor(maskedTextBox.Text);

                if (dados.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("Este CPF já votou!");
                    maskedTextBox.Text = null;
                    maskedTextBox.Focus();
                }
                else
                {
                    this.Hide();
                    Principal form = new Principal(maskedTextBox.Text);
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Insira um CPF válido.");

            }
        }

        //Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Lista Apuração
        private void btnApuracao_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormApuração formApuracao = new FormApuração();
            formApuracao.Show();
        }

        private void maskedTextBox_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox.Text == "097.881.639-04")
            {
                btnApuracao.Enabled = true;
                btnEntrar.Enabled = false;
            }
            else
            {
                btnApuracao.Enabled = false;
                btnEntrar.Enabled = true;
            }
        }
    }
}
