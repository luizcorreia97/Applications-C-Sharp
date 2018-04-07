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
            txtCpf.MaxLength = 11; // limita 11 caracteres que é o padrão do CPF
            txtCpf.TextAlign = HorizontalAlignment.Center; // deixa caracteres centralizados
        }

        //Botão Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //if (validaCpf(txtCpf.Text) == true)
            //{
                Eleicao eleicao = new Eleicao();
                DataSet dados = new DataSet();
                dados = eleicao.verificaEleitor(txtCpf.Text);

                if (dados.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("Este CPF já votou!");
                    txtCpf.Text = null;
                    txtCpf.Focus();
                }
                else
                {
                    this.Hide();
                    Principal form = new Principal(txtCpf.Text);
                    form.Show();
                }
            //}
            //else
            //{
            //    MessageBox.Show("CPF Inválido!");
            //    txtCpf.Text = null;
            //    txtCpf.Focus();
            //}
        }

        //Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Lista Apuração
        private void btnApuracao_Click(object sender, EventArgs e)
        {
            FormApuração formApuracao = new FormApuração();
            formApuracao.Show();
        }
        
        public bool validaCpf(string cpf)
        {
            int sm, i, r, num, dig10, dig11;

            int[] teste = new int[11];

            //teste = Convert.ToInt16(cpf);

            // calcula o 1o. digito verificador do CPF
            sm = 0;
            for (i = 0; i < 9; i++)
            {
                num = cpf[i] - 48;  // transforma o caracter '0' no inteiro 0
                                    // (48 eh a posição de '0' na tabela ASCII)
                sm = sm + (num * (10 - i));
            }
            r = 11 - (sm % 11);
            if ((r == 10) || (r == 11))
                dig10 = '0';
            else
                dig10 = r + 48;

            // calcula o 2o. digito verificador do CPF
            sm = 0;
            for (i = 0; i < 10; i++)
            {
                num = cpf[i] - 48;
                sm = sm + (num * (11 - i));
            }
            r = 11 - (sm % 11);
            if ((r == 10) || (r == 11))
                dig11 = '0';
            else
                dig11 = r + 48;

            // compara os dígitos calculados com os dígitos informados
            if ((dig10 == cpf[9]) && (dig11 == cpf[10]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
