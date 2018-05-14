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
            gridProfessor.DataSource = prof.Buscar();
            gridProfessor.DataBind();
        }

        protected void gridProfessor_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edit"))
            {
                Response.Write("<script>alert('Desejar editar " + e.Item.Cells[1].Text + "?')</script>");
            }
            if (e.CommandName.Equals("Delete"))
            {
                Response.Write("<script>alert('Desejar excluir " + e.Item.Cells[1].Text + "?')</script>");
            }
        }
    }
}