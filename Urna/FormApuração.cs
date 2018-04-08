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
    public partial class FormApuração : Form
    {
        public FormApuração()
        {
            InitializeComponent();
            Eleicao eleicao = new Eleicao();
            gridLista.DataSource = eleicao.Listar().Tables[0];
            lblTotalVotos.Text = eleicao.totalVotos().ToString();
        }

        private void txtAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Eleicao eleicao = new Eleicao();
            //gridLista.DataSource = eleicao.buscaNomeAluno(txtBusca.Text).Tables[0];
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();
            form.Show();
        }
    }
}
