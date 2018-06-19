using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LembreteWebForm
{
    public partial class Gerenciar : System.Web.UI.Page
    {
        Minhas_Classes.Lembrete lembrete = new Minhas_Classes.Lembrete();

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie_login_recuperado = Request.Cookies["Cookie_Login"];
            HttpCookie Cookie_Senha1_recuperada = Request.Cookies["Cookie_Senha1"];
            HttpCookie Cookie_Senha2_recuperada = Request.Cookies["Cookie_Senha2"];

            if (cookie_login_recuperado != null)
            {
                if (!Page.IsPostBack)
                {
                    txtDescricao.Focus();
                    txtID.Text = Request.QueryString["id"];
                    txtDescricao.Text = Request.QueryString["descricao"];
                    txtDia.Text = Request.QueryString["dia"];
                    txtHora.Text = Request.QueryString["hora"];
                    dropDownStatus.Text = Request.QueryString["status"];
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = null;
            txtDia.Text = null;
            txtHora.Text = null;
            txtDescricao.Focus();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            lembrete.descricao = txtDescricao.Text;
            lembrete.dia = txtDia.Text;
            lembrete.hora = txtHora.Text;
            lembrete.status = dropDownStatus.Text;
            
            if (txtID.Text == "")
            {
                lembrete.Salvar();
                Response.Write("<script>alert('Lembrete " + txtDescricao.Text + " salvo com sucesso.');</script>");
                
            }
            else
            {
                lembrete.idLembrete = Convert.ToInt32(txtID.Text);
                lembrete.Alterar();
                Response.Write("<script>alert('Lembrete " + txtDescricao.Text + " alterado com sucesso.');</script>");
            }
            Response.Redirect("Listagem.aspx");
        }
    }
}