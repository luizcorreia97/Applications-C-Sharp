using Classes_Imobiliaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImobiliariaProvaBimestral.ServiceReference1;

namespace ImobiliariaProvaBimestral
{
    public partial class FormImovel : Form
    {
        Classes_Imobiliaria.Imovel imovel = new Classes_Imobiliaria.Imovel();

        public FormImovel()
        {
            InitializeComponent();
            txtNome.Select();
        }

        public FormImovel(Imovel imovel)
        {
            InitializeComponent();

            lblTitulo.Text = "Gerenciar Imóvel";
            txtId.Text = Convert.ToInt32(imovel.idImovel).ToString();
            txtNome.Text = imovel.nome;
            txtCep.Text = imovel.cep;
            txtRua.Text = imovel.logradouro;
            txtBairro.Text = imovel.bairro;
            txtCidade.Text = imovel.cidade;
            txtUF.Text = imovel.uf;
            txtObservacao.Text = imovel.observacao;
            dateCadastro.Text = imovel.dataCadastro;
            dateLocacao.Text = imovel.dataLocacao;
            cmbStatus.Text = imovel.status;

            txtNome.Select();

            //txtSeq.Text = Convert.ToInt32(aluno.mostraID()).ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListagem formListagem = new FormListagem();
            formListagem.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente apagar '" + txtNome.Text + "' ?", "ATENÇÃO", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    imovel.idImovel = Convert.ToInt32(txtId.Text);
                    imovel.Deletar();
                    MessageBox.Show("'" + txtNome.Text + "' Deletado com sucesso.");
                    break;
                case DialogResult.No:
                    MessageBox.Show("'" + txtNome.Text + "' Conversado com sucesso.");
                    break;
            }

            this.Hide();
            FormListagem formListagem = new FormListagem();
            formListagem.Show();
        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            AtendeClienteClient ws = new AtendeClienteClient();

            try
            {
                var dados = ws.consultaCEP(txtCep.Text);

                txtRua.Text = dados.end;
                txtBairro.Text = dados.bairro;
                txtCidade.Text = dados.cidade;
                txtUF.Text = dados.uf;
                txtCep.Focus();

            }
            catch
            {
                MessageBox.Show("CEP não encontrado");
                txtCep.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            imovel.nome = txtNome.Text;
            imovel.cep = txtCep.Text;
            imovel.logradouro = txtRua.Text;
            imovel.bairro = txtBairro.Text;
            imovel.cidade = txtCidade.Text;
            imovel.uf = txtUF.Text;
            imovel.dataCadastro = dateCadastro.Text;
            imovel.dataLocacao = dateLocacao.Text;
            imovel.observacao = txtObservacao.Text;
            imovel.status = cmbStatus.Text;

            if (txtId.Text == "")
            {

                imovel.Salvar();
                MessageBox.Show("Imóvel " + txtNome.Text + " Salvo com sucesso.");
            }

            else
            {
                imovel.idImovel = Convert.ToInt32(txtId.Text);
                imovel.Alterar();
                MessageBox.Show("Imóvel " + txtNome.Text + " Alterado com sucesso.");
            }

            this.Hide();
            FormListagem formListagem = new FormListagem();
            formListagem.Show();
        }
    }
}