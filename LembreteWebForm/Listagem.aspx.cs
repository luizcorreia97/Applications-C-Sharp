using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LembreteWebForm
{
    public partial class Listagem : System.Web.UI.Page
    {
        Minhas_Classes.Lembrete lembrete = new Minhas_Classes.Lembrete();

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie_login_recuperado = Request.Cookies["Cookie_Login"];
            HttpCookie Cookie_Senha1_recuperada = Request.Cookies["Cookie_Senha1"];
            HttpCookie Cookie_Senha2_recuperada = Request.Cookies["Cookie_Senha2"];

            if (cookie_login_recuperado != null)
            {
                if (dropDownMes.AutoPostBack)
                {
                    gridLembrete.DataSource = lembrete.BuscarPorMes(dropDownMes.Text);
                    gridLembrete.DataBind();
                }
            }
            else {
                Response.Redirect("Login.aspx");
            }
        }

        protected void gridLembrete_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edit"))
            {
                //Response.Write("<script>alert('Desejar editar " + e.Item.Cells[1].Text + "?')</script>");
                Response.Redirect("Gerenciar.aspx?id=" + e.Item.Cells[0].Text + "&descricao=" + e.Item.Cells[1].Text + "&dia=" + e.Item.Cells[2].Text + "&hora=" + e.Item.Cells[3].Text + "&status=" + e.Item.Cells[4].Text);
            }
            if (e.CommandName.Equals("Delete"))
            {
                Response.Write("<script>alert('Desejar excluir " + e.Item.Cells[1].Text + "?')</script>");

                lembrete.idLembrete = Convert.ToInt32(e.Item.Cells[0].Text);
                lembrete.Deletar();

                gridLembrete.DataSource = lembrete.Buscar();
                gridLembrete.DataBind();

                Response.Write("<script>alert('Lembrete " + e.Item.Cells[1].Text + " excluído com sucesso.');</script>");
            }
        }

        protected void gridLembrete_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            gridLembrete.CurrentPageIndex = e.NewPageIndex;
            gridLembrete.DataSource = lembrete.Buscar();
            gridLembrete.DataBind();
        }

        protected void gridLembrete_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.Cells[4].Text == "Em Aberto")
            {
                e.Item.Cells[4].BackColor = System.Drawing.Color.Blue;
                e.Item.Cells[4].ForeColor = System.Drawing.Color.White;
            }
            if (e.Item.Cells[4].Text == "Cancelado")
            {
                e.Item.Cells[4].BackColor = System.Drawing.Color.Red;
                e.Item.Cells[4].ForeColor = System.Drawing.Color.White;
            }
            if (e.Item.Cells[4].Text == "Finalizado")
            {
                e.Item.Cells[4].BackColor = System.Drawing.Color.Green;
                e.Item.Cells[4].ForeColor = System.Drawing.Color.White;
            }
        }
    }
}