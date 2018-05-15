using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessoresWebForms
{

    public partial class Index : System.Web.UI.Page
    {
        //Response.Redirect - Mudar página
        // txt_nome.Text = Request.QueryString["nome"] + " " + Request.QueryString["sobrenome"];
        // lbl_idade.Text = Request.QueryString["idade"];
        //Response.Redirect("Pagina2.aspx?nome=" + e.Item.Cells[1].Text + "&idade=21&idade=");
        
        Minhas_Classes.Professor prof = new Minhas_Classes.Professor();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtNome.Focus();
                //gridProfessor.DataSource = prof.Buscar();
                //gridProfessor.DataBind();

                //limpaCampos();

                txtID.Text = Request.QueryString["id"];
                txtNome.Text = Request.QueryString["nome"];
                txtIdade.Text = Request.QueryString["idade"];
                DropDownSexo.Text = Request.QueryString["sexo"];
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            prof.nome = txtNome.Text;
            prof.idade = Convert.ToInt32(txtIdade.Text);
            prof.sexo = Convert.ToChar(DropDownSexo.Text);

            if (txtID.Text == "")
            {
                prof.Salvar();

                Response.Write("<script>alert('Professor " + txtNome.Text + " salvo com sucesso.');</script>");

                //gridProfessor.DataSource = prof.Buscar();
                //gridProfessor.DataBind();
            }
            else
            {
                prof.idProfessor = Convert.ToInt32(txtID.Text);
                prof.Alterar();

                Response.Write("<script>alert('Professor " + txtNome.Text + " alterado com sucesso.');</script>");

                //gridProfessor.DataSource = prof.Buscar();
                //gridProfessor.DataBind();
            }

            //limpaCampos();
            //txtNome.Focus();
            Response.Redirect("ListagemProfessores.aspx");
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            prof.idProfessor = Convert.ToInt32(txtID.Text);
            prof.Deletar();

            Response.Write("<script>alert('Professor " + txtNome.Text + " excluído com sucesso.');</script>");

            //gridProfessor.DataSource = prof.Buscar();
            //gridProfessor.DataBind();

            limpaCampos();
            txtNome.Focus();
        }

        protected void gridProfessor_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edit"))
            {
                txtID.Text = e.Item.Cells[0].Text;
                txtNome.Text = e.Item.Cells[1].Text;
                txtIdade.Text = e.Item.Cells[2].Text;
                //DropDownSexo.Text = e.Item.Cells[3].Text;

                if (e.Item.Cells[3].Text == "Masculino")
                {
                    DropDownSexo.Text = "M";
                    //e.Item.Cells[2].Text = 
                }
                else
                {
                    DropDownSexo.Text = "F";
                }

                txtNome.Focus();
                //DropDownSexo.Text = e.Item.Cells[3].Text;
                //Response.Redirect("Pagina2.aspx?nome=" + e.Item.Cells[1].Text + "&idade=21&idade=");

                //Response.Write("<script>alert('" + e.Item.Cells[1].Text + " excluído com sucesso.')</script>");
            }
            if (e.CommandName.Equals("Delete"))
            {
                prof.idProfessor = Convert.ToInt32(e.Item.Cells[0].Text);
                prof.Deletar();

                Response.Write("<script>alert('" + e.Item.Cells[1].Text + " excluído com sucesso.')</script>");
                limpaCampos();
            }

            //gridProfessor.DataSource = prof.Buscar();
            //gridProfessor.DataBind();
            txtNome.Focus();
        }

        protected void gridProfessor_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.Cells[3].Text == "M")
            {
                e.Item.Cells[3].Text = "Masculino";
                //e.Item.Cells[2].Text = 
            }
            if (e.Item.Cells[3].Text == "F")
            {
                e.Item.Cells[3].Text = "Feminino";
            }
        }

        protected void gridProfessor_EditCommand(object source, DataGridCommandEventArgs e)
        {

        }

        //protected void gridProfessor_ItemCreated(object sender, DataGridItemEventArgs e)
        //{
        //    e.Item.Cells[0].Attributes.Add("onmouseover", "this.style.backgroundColor='red'");
        //    e.Item.Cells[0].Attributes.Add("onmouseout", "this.style.backgroundColor='white'");
        //}

        public void limpaCampos()
        {
            txtID.Text = null;
            txtNome.Text = null;
            txtIdade.Text = null;
            DropDownSexo.Text = null;
            txtNome.Focus();
        }

        protected void btnLimparCampos_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListagemProfessores.aspx");
        }
    }
}