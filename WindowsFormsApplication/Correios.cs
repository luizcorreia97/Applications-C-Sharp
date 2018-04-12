using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.ServiceReference1;

namespace WindowsFormsApplication
{
    public partial class Correios : Form
    {
        public Correios()
        {
            InitializeComponent();
            txtCep.MaxLength = 8;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AtendeClienteClient ws = new AtendeClienteClient();
        
            try
            {
                var dados = ws.consultaCEP(txtCep.Text);

                txtRua.Text = dados.end;
                txtBairro.Text = dados.bairro;
                txtCidade.Text = dados.cidade;
                txtUF.Text = dados.uf;
                txtComplemento.Text = dados.complemento;
                txtCep.Focus();

            }
            catch
            {
                MessageBox.Show("CEP não encontrado");
                txtCep.Focus();
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            AtendeClienteClient ws = new AtendeClienteClient();

            try
            {
                var dados = ws.consultaCEP(txtCep.Text);

                txtRua.Text = dados.end;
                txtBairro.Text = dados.bairro;
                txtCidade.Text = dados.cidade;
                txtUF.Text = dados.uf;
                txtComplemento.Text = dados.complemento;
                txtCep.Focus();

            }
            catch
            {
                MessageBox.Show("CEP não encontrado");
                txtCep.Focus();
            }
        }
    }
}
