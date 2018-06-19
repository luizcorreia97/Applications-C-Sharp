using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LembreteWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
            if (IsPostBack == false)
            {
                HttpCookie cookie_login_recuperado = Request.Cookies["Cookie_Login"];
                HttpCookie Cookie_Senha1_recuperada = Request.Cookies["Cookie_Senha1"];
                HttpCookie Cookie_Senha2_recuperada = Request.Cookies["Cookie_Senha2"];

                if (cookie_login_recuperado != null)
                {
                    txtLogin.Text = cookie_login_recuperado.Value;
                    txtSenha1.Text = Cookie_Senha1_recuperada.Value;
                    txtSenha2.Text = Cookie_Senha2_recuperada.Value;
                    checkLembrar.Checked = true;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkLembrar.Checked)
            {
                HttpCookie cookie_login = new HttpCookie("Cookie_Login", txtLogin.Text);
                cookie_login.Expires = DateTime.Now.AddDays(1);
                Response.AppendCookie(cookie_login);

                HttpCookie Cookie_Senha1 = new HttpCookie("Cookie_Senha1", txtSenha1.Text);
                Cookie_Senha1.Expires = DateTime.Now.AddDays(1);
                Response.AppendCookie(Cookie_Senha1);

                HttpCookie Cookie_Senha2 = new HttpCookie("Cookie_Senha2", txtSenha2.Text);
                Cookie_Senha2.Expires = DateTime.Now.AddDays(1);
                Response.AppendCookie(Cookie_Senha2);
            }
            else
            {
                if (Request.Cookies["Cookie_Login"] != null)
                {
                    Response.Cookies["Cookie_Login"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["Cookie_Senha1"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["Cookie_Senha2"].Expires = DateTime.Now.AddDays(-1);
                }
            }

            Response.Redirect("Listagem.aspx");
        }
    }
}