using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlunosWebForm
{
    public partial class Listagem : System.Web.UI.Page
    {
        Minhas_Classes.Aluno aluno = new Minhas_Classes.Aluno();

        protected void Page_Load(object sender, EventArgs e)
        {
            gridAluno.DataSource = aluno.Buscar();
            gridAluno.DataBind();
        }

        protected void gridAluno_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edit"))
            {
                Response.Write("<script>alert('Desejar editar " + e.Item.Cells[1].Text + "?')</script>");
                Response.Redirect("Gerenciar.aspx?id=" + e.Item.Cells[0].Text + "&nome=" + e.Item.Cells[1].Text + "&idade=" + e.Item.Cells[2].Text); ;
            }
            if (e.CommandName.Equals("Delete"))
            {
                Response.Write("<script>alert('Desejar excluir " + e.Item.Cells[1].Text + "?')</script>");

                aluno.idAluno = Convert.ToInt32(e.Item.Cells[0].Text);
                aluno.Deletar();

                gridAluno.DataSource = aluno.Buscar();
                gridAluno.DataBind();

                Response.Write("<script>alert('Aluno " + e.Item.Cells[1].Text + " excluído com sucesso.');</script>");
            }
        }

        protected void gridAluno_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            gridAluno.CurrentPageIndex = e.NewPageIndex;
            gridAluno.DataSource = aluno.Buscar();
            gridAluno.DataBind();
        }
    }
}