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

        private void txtAluno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MeuDataSet.MeuDataSet mds = new MeuDataSet.MeuDataSet();
            gridLista.DataSource = mds.buscaNomeAluno(txtAluno.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.gridLista.DataSource = null;
        }
    }
}
