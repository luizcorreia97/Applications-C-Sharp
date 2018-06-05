using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessoresWebForms
{
    public partial class RecuperaCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Cookie_Facear"];
            if (cookie != null)
            {
                string texto = cookie.Value;
                Response.Write(texto);
            }
        }
    }
}