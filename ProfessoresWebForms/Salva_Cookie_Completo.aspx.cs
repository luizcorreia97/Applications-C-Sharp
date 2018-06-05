using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessoresWebForms
{
    public partial class Salva_Cookie_Completo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_salva_dados_Click(object sender, EventArgs e)
        {
            HttpCookie outro_cookie = new HttpCookie("Dados_do_Usuario");
            outro_cookie.Values.Add("Nome", "Luiz");
            outro_cookie.Values.Add("Idade", "21");
            outro_cookie.Values.Add("Sexo", "Masculino");

            outro_cookie.Expires = DateTime.Now.AddMinutes(5);
            Response.AppendCookie(outro_cookie);
        }

        protected void btn_recupera_cookie_completo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Recupera_Cookie_Completo.aspx");
        }
    }
}