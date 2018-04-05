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
    public partial class MeuDataService : Form
    {
        public MeuDataService()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MeuDataSet.MeuDataSet mds = new MeuDataSet.MeuDataSet();
            gridLista.DataSource = mds.Buscar().Tables[0];
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.gridLista.DataSource = null;
        }

        private void txtAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            MeuDataSet.MeuDataSet mds = new MeuDataSet.MeuDataSet();
            gridLista.DataSource = mds.buscaNomeAluno(txtAluno.Text).Tables[0];
        }
    }
}
