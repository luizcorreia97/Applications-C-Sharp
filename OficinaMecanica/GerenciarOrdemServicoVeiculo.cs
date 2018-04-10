using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMecanica
{
    public partial class GerenciarOrdemServico : Form
    {
        localhost.WSOrdemServico wsOrdem = new localhost.WSOrdemServico();
        localhost.Ordem ordem = new localhost.Ordem();
        
        public GerenciarOrdemServico()
        {
            InitializeComponent();
            
            gridLista.DataSource = wsOrdem.BuscarOrdem();

            cmbMarca.DataSource = wsOrdem.BuscarMarca();
            cmbMarca.ValueMember = "id";
            cmbMarca.DisplayMember = "marca";

            cmbStatus.DataSource = wsOrdem.BuscarStatus();
            cmbStatus.ValueMember = "id";
            cmbStatus.DisplayMember = "status";

            this.maskedPlaca.Mask = "AAA-0000";
            txtNome.Focus();
        }
 
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja apagar ordem nº " + txtId.Text + "?",
                      "ATENÇÃO", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    wsOrdem.Deletar(Convert.ToInt32(txtId.Text));
                    MessageBox.Show("Ordem nº " + txtId.Text + " Deletada.");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Ordem nº " + txtId.Text + " Conversada.");
                    break;
            }
            gridLista.DataSource = wsOrdem.BuscarOrdem();
            LimpaCampos();
        }
        
        private void gridLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            txtId.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            maskedPlaca.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            cmbMarca.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            dateAbertura.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            dateFinalizacao.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            txtDescricao.Text = dgv.CurrentRow.Cells[6].Value.ToString();
            cmbStatus.Text = dgv.CurrentRow.Cells[7].Value.ToString();

            if (cmbStatus.Text == "Cancelada" || cmbStatus.Text == "Finalizada")
            {
                bloqueiaComponentes(false);
            }
            else
            {
                bloqueiaComponentes(true);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                defineValores();
                wsOrdem.Salvar(ordem);
                MessageBox.Show("Ordem nº " + txtId.Text + " salva com sucesso.");
                gridLista.DataSource = wsOrdem.BuscarOrdem();
                LimpaCampos();
            }
            else
            {
                ordem.idOrdem = Convert.ToInt32(txtId.Text);
                defineValores();
                wsOrdem.Alterar(ordem);
                MessageBox.Show("Ordem nº " + txtId.Text + " alterada com sucesso.");
                gridLista.DataSource = wsOrdem.BuscarOrdem();
                LimpaCampos();
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        public void LimpaCampos()
        {
            txtId.Text = null;
            txtNome.Text = null;
            maskedPlaca.Text = null;
            txtDescricao.Text = null;
            cmbMarca.Text = null;
            cmbStatus.Text = null;
            dateAbertura.Text = null;
            dateFinalizacao.Text = null;
            btnExcluir.Visible = false;
        }

        public void defineValores()
        {
            ordem.nome = txtNome.Text;
            ordem.placa = maskedPlaca.Text;
            ordem.descricao = txtDescricao.Text;
            ordem.dataAbertura = dateAbertura.Text;

            if (cmbStatus.Text == "Cancelada" || cmbStatus.Text == "Finalizada")
            {
                ordem.dataFinalizacao = dateFinalizacao.Text;
            }

            ordem.idMarca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
            ordem.idStatus = Convert.ToInt32(cmbStatus.SelectedValue.ToString());
        }
        
        private void cmbStatus_MouseMove(object sender, MouseEventArgs e)
        {
            if (cmbStatus.Text == "Cancelada" || cmbStatus.Text == "Finalizada")
            {
                dateFinalizacao.Enabled = true;
            }
            else
            {
                dateFinalizacao.Enabled = false;
            }
        }

        public void bloqueiaComponentes(bool bloqueia)
        {
            txtNome.Enabled = bloqueia;
            maskedPlaca.Enabled = bloqueia;
            cmbMarca.Enabled = bloqueia;
            dateAbertura.Enabled = bloqueia;
            txtDescricao.Enabled = bloqueia;
            cmbStatus.Enabled = bloqueia;
            btnExcluir.Visible = bloqueia;
            btnLimparCampos.Visible = bloqueia;
            btnSalvar.Visible = bloqueia;
        }
    }
}