using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessoresWebForms
{
    public partial class SalvaCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_salva_cookies_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Cookie_Facear","FACEAR");
            cookie.Expires = DateTime.Now.AddYears(5);
            Response.AppendCookie(cookie);
        }

        protected void btn_recupera_cookie_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecuperaCookie.aspx");
        }
    }
}