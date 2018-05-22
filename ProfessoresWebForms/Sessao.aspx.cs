using Minhas_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessoresWebForms
{
    public partial class Sessao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            IList<Professor> lista = new List<Professor>();
            if(Session["lista_de_professores"] != null)
            {
                lista = (List<Professor>)Session["lista_de_professores"];
            }

            Professor p = new Professor();
            p.nome = txtNome.Text;
            lista.Add(p);
            Session["lista_de_professores"] = lista;

            dgProfessores.DataSource = lista;
            dgProfessores.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            IList<Professor> lista = new List<Professor>();
            if (Session["lista_de_professores"] != null)
            {
                lista = (List<Professor>)Session["lista_de_professores"];

                foreach (var item in lista)
                {
                    Professor p = new Professor();
                    p = item;
                    p.Salvar();
                }
            }
            Session.Remove("lista_de_professores");
        }
    }
}