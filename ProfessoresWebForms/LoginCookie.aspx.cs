using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfessoresWebForms
{
    public partial class LoginCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
            if (IsPostBack == false)
            {
                HttpCookie cookie_login_recuperado = Request.Cookies["Cookie_Login"];
                HttpCookie cookie_senha_recuperada = Request.Cookies["Cookie_Senha"];

                if (cookie_login_recuperado != null)
                {
                    txtLogin.Text = cookie_login_recuperado.Value;
                    txtSenha.Text = cookie_senha_recuperada.Value;
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

                HttpCookie cookie_senha = new HttpCookie("Cookie_Senha", txtSenha.Text);
                cookie_senha.Expires = DateTime.Now.AddDays(1);
                Response.AppendCookie(cookie_senha);
            }
            else
            {
                if (Request.Cookies["Cookie_Login"] != null)
                {
                    Response.Cookies["Cookie_Login"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["Cookie_Senha"].Expires = DateTime.Now.AddDays(-1);
                }
            }

            Response.Redirect("ListagemProfessores.aspx");
        }
    }
}