using Minhas_Classes;
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
    public partial class FormGerenciaUsuario : Form
    {
        public FormGerenciaUsuario()
        {
            InitializeComponent();
        }

        public FormGerenciaUsuario(string nome)
        {
            InitializeComponent();

            lblUsuario.Text = nome;
        }

        Minhas_Classes.Usuario usuario = new Minhas_Classes.Usuario();

        public void LimpaCampos()
        {
            txtId.Text = null;
            txtNome.Text = null;
            txtSenha.Text = null;
            txtSenha2.Text = null;
            cmbTipo.Text = null;
            txtBuscaNome.Text = null;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Minhas_Classes.Usuario usuario = new Minhas_Classes.Usuario();
            gridUsuario.DataSource = usuario.buscaUsuarioNome(txtBuscaNome.Text).Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            
            txtId.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtLogin.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txtSenha.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            cmbTipo.Text = dgv.CurrentRow.Cells[4].Value.ToString();

            if (dgv.CurrentRow.Cells[5].Value.ToString() == "Masculino")
            {
                rbMasculino.Checked = true;
            }
            if (dgv.CurrentRow.Cells[5].Value.ToString() == "Feminino")
            {
                rbFeminino.Checked = true;
            }
            
            if (dgv.CurrentRow.Cells[6].Value.ToString() == "Inativo")
            {
                chkStatus.Checked = true;
            }
            else {
                chkStatus.Checked = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Minhas_Classes.Usuario usuario = new Minhas_Classes.Usuario();

            if (txtSenha.Text == "" || txtSenha2.Text == "")
            {
                MessageBox.Show("Campo senha é de preenchimento obrigatório!");
            }
            
            if (txtSenha.Text == txtSenha2.Text) {
                usuario.senha = txtSenha.Text;

                if (txtId.Text == "")
                {
                    //usuario.idUsuario = Convert.ToInt32(txtId.Text);
                    usuario.nome = txtNome.Text;
                    usuario.login = txtLogin.Text;
                    //usuario.senha = txtSenha.Text;
                    usuario.tipo = cmbTipo.Text;

                    if (rbMasculino.Checked == true)
                    {
                        usuario.sexo = "Masculino";
                    }
                    if (rbFeminino.Checked == true)
                    {
                        usuario.sexo = "Feminino";
                    }
                    if (chkStatus.Checked == true)
                    {
                        usuario.status = "Inativo";
                    }
                    if (chkStatus.Checked == false)
                    {
                        usuario.status = "Ativo";
                    }

                    usuario.Salvar();
                    MessageBox.Show("Usuário " + txtNome.Text + " Salvo com sucesso.");
                }

                else
                {
                    usuario.idUsuario = Convert.ToInt32(txtId.Text);
                    usuario.nome = txtNome.Text;
                    usuario.login = txtLogin.Text;
                    usuario.senha = txtSenha.Text;
                    usuario.tipo = cmbTipo.Text;

                    if (rbMasculino.Checked == true)
                    {
                        usuario.sexo = "Masculino";
                    }
                    if (rbFeminino.Checked == true)
                    {
                        usuario.sexo = "Feminino";
                    }
                    if (chkStatus.Checked == true)
                    {
                        usuario.status = "Inativo";
                    }
                    if (chkStatus.Checked == false)
                    {
                        usuario.status = "Ativo";
                    }

                    usuario.Alterar();
                    MessageBox.Show("Usuário " + txtNome.Text + " Alterado com sucesso.");
                }
                
                gridUsuario.DataSource = usuario.buscaUsuarioNome(txtBuscaNome.Text).Tables[0];
                LimpaCampos();
            }
            
            else {
                MessageBox.Show("Senha não confere, favor verificar");
                txtSenha2.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            usuario.idUsuario = Convert.ToInt32(txtId.Text);
            DialogResult dr = MessageBox.Show("Deseja apagar" + txtNome.Text,
                      "kakakak", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    usuario.Deletar();
                    MessageBox.Show("Professor " + txtNome.Text + " Deletado.");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Professor " + txtNome.Text + " Conversado.");
                    break;
            }

            gridUsuario.DataSource = usuario.buscaUsuarioNome(txtBuscaNome.Text).Tables[0];
            LimpaCampos();
        }

        private void FormGerenciaUsuario_Layout(object sender, LayoutEventArgs e)
        {
            gridUsuario.DataSource = usuario.buscaUsuarioNome(txtBuscaNome.Text).Tables[0];

            //int teste = usuario.totalUsuario();
            //lblTotal.Text = usuario.totalUsuario().ToString();

        }

        private void txtBuscaNome_Leave(object sender, EventArgs e)
        {
            gridUsuario.DataSource = usuario.buscaUsuarioNome(txtBuscaNome.Text).Tables[0];
        }

        private void txtBuscaNome_Enter(object sender, EventArgs e)
        {
            gridUsuario.DataSource = usuario.buscaUsuarioNome(txtBuscaNome.Text).Tables[0];
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormGerenciaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza que deseja sair do sistema?" + txtNome.Text,
                      "kakakak", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    break;
                case DialogResult.No:
                    break;
            }

            
        }
    }
}
