using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessoresWebForms
{
    public partial class Componentes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Minhas_Classes.Professor prof = new Minhas_Classes.Professor();
                drtProfessor.DataSource = prof.Buscar();
                drtProfessor.DataTextField = "nome";
                drtProfessor.DataValueField = "idProfessor";
                drtProfessor.DataBind();
                drtProfessor.SelectedIndex = 2;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Professor selecionado');</script>");
        }
    }
}