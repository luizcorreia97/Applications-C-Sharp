using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImobiliariaProvaBimestral
{
    public partial class FormListagem : Form
    {
        Classes_Imobiliaria.Imovel imovel = new Classes_Imobiliaria.Imovel();
        public FormListagem()
        {
            InitializeComponent();
            gridImovel.DataSource = imovel.Buscar().Tables[0];
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormImovel formImovel = new FormImovel();
            formImovel.Show();
        }

        private void gridImovel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            
            imovel.idImovel = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString());
            imovel.nome = dgv.CurrentRow.Cells[1].Value.ToString();
            imovel.cep = dgv.CurrentRow.Cells[2].Value.ToString();
            imovel.logradouro = dgv.CurrentRow.Cells[3].Value.ToString();
            imovel.bairro = dgv.CurrentRow.Cells[4].Value.ToString();
            imovel.cidade = dgv.CurrentRow.Cells[5].Value.ToString();
            imovel.uf = dgv.CurrentRow.Cells[6].Value.ToString();
            imovel.dataCadastro = dgv.CurrentRow.Cells[7].Value.ToString();
            imovel.dataLocacao = dgv.CurrentRow.Cells[8].Value.ToString();
            imovel.observacao = dgv.CurrentRow.Cells[9].Value.ToString();
            imovel.status = dgv.CurrentRow.Cells[10].Value.ToString();

            this.Hide();
            FormImovel formImovel = new FormImovel(imovel);
            formImovel.Show();
        }

        private void txtBuscaBairro_KeyDown(object sender, KeyEventArgs e)
        {
            gridImovel.DataSource = imovel.buscaImovelPorBairro(cmbStatus.Text, txtBuscaBairro.Text).Tables[0];
        }

        private void txtBuscaBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            gridImovel.DataSource = imovel.buscaImovelPorBairro(cmbStatus.Text, txtBuscaBairro.Text).Tables[0];
        }

        private void txtBuscaBairro_KeyUp(object sender, KeyEventArgs e)
        {
            gridImovel.DataSource = imovel.buscaImovelPorBairro(cmbStatus.Text, txtBuscaBairro.Text).Tables[0];
        }

        private void txtBuscaBairro_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            gridImovel.DataSource = imovel.buscaImovelPorBairro(cmbStatus.Text, txtBuscaBairro.Text).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbStatus.Text = null;
            txtBuscaBairro.Text = null;
            gridImovel.DataSource = imovel.Buscar().Tables[0];
        }

        private void cmbStatus_MouseClick(object sender, MouseEventArgs e)
        {
            gridImovel.DataSource = imovel.buscaImovelPorStatus(cmbStatus.Text).Tables[0];
        }
    }
}