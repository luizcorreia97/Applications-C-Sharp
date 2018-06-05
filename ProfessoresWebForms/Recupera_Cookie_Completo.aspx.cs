using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessoresWebForms
{
    public partial class Recupera_Cookie_Completo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Dados_do_Usuario"];
            if (cookie != null)
            {
                string[] valores = cookie.Value.ToString().Split('&');
                for (int i = 0; i < valores.Length; i++)
                {
                    Response.Write("<br>" + valores[i]);
                }
            }
        }
    }
}