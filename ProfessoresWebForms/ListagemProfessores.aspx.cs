using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessoresWebForms
{
    public partial class ListagemProfessores : System.Web.UI.Page
    {
        Minhas_Classes.Professor prof = new Minhas_Classes.Professor();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gridProfessor.DataSource = prof.Buscar();
                gridProfessor.DataBind();
                rbListSexo.SelectedIndex = 0;
            }
            if (rbListSexo.AutoPostBack)
            {
                gridProfessor.DataSource = prof.BuscarPorSexo(rbListSexo.SelectedValue);
                gridProfessor.DataBind();
            }
            if (chkListIdade.AutoPostBack)
            {
                if (Convert.ToString(chkListIdade.SelectedItem) != "")
                {
                    //Response.Write("<script>alert('Professor " + chkListIdade.SelectedItem + " selecionado.');</script>");
                    gridProfessor.DataSource = prof.BuscarPorIdade(Convert.ToString(chkListIdade.SelectedItem));
                    gridProfessor.DataBind();
                }
                else
                {
                    gridProfessor.DataSource = prof.BuscarPorSexo(rbListSexo.SelectedValue);
                    gridProfessor.DataBind();
                }
            }
        }

        protected void gridProfessor_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edit"))
            {
                Response.Write("<script>alert('Desejar editar " + e.Item.Cells[1].Text + "?')</script>");
                Response.Redirect("Index.aspx?id="+ e.Item.Cells[0].Text + "&nome=" + e.Item.Cells[1].Text + "&idade=" + e.Item.Cells[2].Text + "&sexo=" + e.Item.Cells[3].Text); ;
            }
            if (e.CommandName.Equals("Delete"))
            {
                Response.Write("<script>alert('Desejar excluir " + e.Item.Cells[1].Text + "?')</script>");

                prof.idProfessor = Convert.ToInt32(e.Item.Cells[0].Text);
                prof.Deletar();

                gridProfessor.DataSource = prof.BuscarPorSexo(rbListSexo.SelectedValue);
                gridProfessor.DataBind();

                Response.Write("<script>alert('Professor " + e.Item.Cells[1].Text + " excluído com sucesso.');</script>");
            }
        }

        protected void btnFiltrarSexo_Click(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('Selecionado " + rbList.SelectedValue + "')</script>");
            gridProfessor.DataSource = prof.BuscarPorSexo(rbListSexo.SelectedValue);
            gridProfessor.DataBind();
        }

        protected void gridProfessor_ItemDataBound(object sender, DataGridItemEventArgs e)
        {

            if (e.Item.Cells[3].Text == "M")
            {
                e.Item.Cells[3].Text = "Masculino";
                //e.Item.Cells[3].BackColor = System.Drawing.Color.Blue;
            }
            if (e.Item.Cells[3].Text == "F")
            {
                e.Item.Cells[3].Text = "Feminino";
                //e.Item.Cells[3].BackColor = System.Drawing.Color.Red;
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(chkListIdade.SelectedItem) != "")
            {
                Response.Write("<script>alert('Professor " + chkListIdade.SelectedItem + " excluído com sucesso.');</script>");
                gridProfessor.DataSource = prof.BuscarPorIdade(Convert.ToString(chkListIdade.SelectedItem));
                gridProfessor.DataBind();
            }
            else
            {
                gridProfessor.DataSource = prof.BuscarPorSexo(rbListSexo.SelectedValue);
                gridProfessor.DataBind();
            }
        }

        protected void gridProfessor_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            gridProfessor.CurrentPageIndex = e.NewPageIndex;
            gridProfessor.DataSource = prof.BuscarPorSexo(rbListSexo.SelectedValue);
            gridProfessor.DataBind();
        }

        protected void gridProfessor_ItemCreated(object sender, DataGridItemEventArgs e)
        {
            //if (e.Item.Cells[3].Text == "M")
            //{
            //    e.Item.Cells[3].Attributes.Add("onmouseover", "this.style.backgroundColor='blue'");
            //}
            //if (e.Item.Cells[3].Text == "F")
            //{
            //    e.Item.Cells[3].Attributes.Add("onmouseover", "this.style.backgroundColor='red'");
            //}
            //e.Item.Cells[3].Attributes.Add("onmouseout", "this.style.backgroundColor='white'");
        }

        //protected void rbList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //Response.Write("<script>alert('Oi');</script>");
        //    gridProfessor.DataSource = prof.BuscarPorSexo(rbList.SelectedValue);
        //    gridProfessor.DataBind();
        //}

        //protected void rbList_DataBound(object sender, EventArgs e)
        //{
        //    Response.Write("<script>alert('Oi Data Bound');</script>");
        //}
    }
}