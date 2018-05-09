using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NossoSite
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var resultado = Convert.ToInt32(txtCampo1.Text) + Convert.ToInt32(txtCampo2.Text);
            txtResultado0.Text = resultado.ToString();
        }
    }
}