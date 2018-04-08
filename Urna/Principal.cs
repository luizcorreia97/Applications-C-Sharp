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
        }

        public Principal(string cpf)
        {
            InitializeComponent();
            eleicao.cpf = cpf;
        }

        Eleicao eleicao = new Eleicao();

        private void btn1_Click(object sender, EventArgs e)
        {
            validaCampo("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            validaCampo("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            validaCampo("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            validaCampo("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            validaCampo("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            validaCampo("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            validaCampo("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            validaCampo("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            validaCampo("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            validaCampo("0");
        }

        //Botão Corrige
        private void btnCorrige_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        //Botão Em Branco
        private void btnBranco_Click(object sender, EventArgs e)
        {
            eleicao.numero = 1;
            eleicao.candidato = "Branco";
            popUp("Aperte o botão confirma!", "Voto " + eleicao.candidato + " cancelado, vote novamente!", false);
            btnConfirma.Enabled = true;
            btnBranco.Enabled = false;
        }

        //Botão Voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        public void validaCampo(string num)
        {
            if (txtNumero1.Text.Length < 1)
            {
                txtNumero1.Text = num;
                btnCorrige.Enabled = true;
                btnBranco.Enabled = false;
            }
            else
            {
                txtNumero2.Text = num;
                mostraCandidato();
                btnConfirma.Enabled = true;
            }
        }

        //Lista Apuração
        private void btnBuscaCandidato_Click(object sender, EventArgs e)
        {
            FormApuração formApuracao = new FormApuração();
            formApuracao.Show();
        }

        //Mostra Candidato Buscado
        public void mostraCandidato()
        {
            DataSet dados = new DataSet();
            dados = eleicao.BuscaCandidato(Convert.ToInt32(txtNumero1.Text + txtNumero2.Text));

            if (dados.Tables[0].Rows.Count != 0)
            {
                foreach (DataRow row in dados.Tables[0].Rows)
                {
                    picturePresidente.ImageLocation = (row["foto"] + " ");
                    pictureVice.ImageLocation = (row["fotovice"] + " ");
                    lblMostraCandidato.Text = (row["nome"] + " ");
                    lblMostraPartido.Text = (row["partido"] + " ");
                    lblMostraVice.Text = (row["vice"] + " ");
                }

                eleicao.numero = Convert.ToInt16(txtNumero1.Text + txtNumero2.Text);
                eleicao.candidato = lblMostraCandidato.Text;
                eleicao.partido = lblMostraPartido.Text;
            }
            else
            {
                eleicao.numero = 2;
                eleicao.candidato = "Nulo";
                popUp("Aperte o botão confirma!", "Voto " + eleicao.candidato + " cancelado, vote novamente!", false);

            }
        }

        //Botão Confirma
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            popUp("Voto computado com sucesso!", "Voto não computado, vote novamente!", true);
        }

        //Limpa Campos
        public void limpaCampos()
        {
            txtNumero1.Text = null;
            txtNumero2.Text = null;
            lblMostraCandidato.Text = null;
            lblMostraPartido.Text = null;
            lblMostraVice.Text = null;
            btnCorrige.Enabled = false;
            btnConfirma.Enabled = false;
            btnBranco.Enabled = true;
            picturePresidente.ImageLocation = null;
            pictureVice.ImageLocation = null;
        }

        //Monta PopUp
        public void popUp(string yes, string no, bool quit)
        {
            DialogResult dr = MessageBox.Show("Confirma seu voto para " + eleicao.candidato + "?",
                      "ATENÇÃO", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    eleicao.Salvar();
                    MessageBox.Show(yes);

                    if (quit == true)
                    {
                        this.Hide();
                        FormLogin formLogin = new FormLogin();
                        formLogin.Show();
                    }
                    else
                    {
                        limpaCampos();
                    }

                    break;
                case DialogResult.No:
                    MessageBox.Show(no);
                    limpaCampos();
                    break;
            }
        }
    }
}