using Minhas_Classes;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace ProfessoresWebForms
{

    public partial class Index : System.Web.UI.Page
    {
        //Response.Redirect - Mudar página
        // txt_nome.Text = Request.QueryString["nome"] + " " + Request.QueryString["sobrenome"];
        // lbl_idade.Text = Request.QueryString["idade"];
        //Response.Redirect("Pagina2.aspx?nome=" + e.Item.Cells[1].Text + "&idade=21&idade=");

        Minhas_Classes.Professor prof = new Minhas_Classes.Professor();
        private HashSet<Professor> _lista = new HashSet<Professor>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtNome.Focus();
                //gridProfessor.DataSource = prof.Buscar();
                //gridProfessor.DataBind();
                //limpaCampos();

                txtID.Text = Request.QueryString["id"];
                txtNome.Text = Request.QueryString["nome"];
                txtIdade.Text = Request.QueryString["idade"];
                DropDownSexo.Text = Request.QueryString["sexo"];

                dropDownMaterias.DataSource = prof.BuscarMateria();
                dropDownMaterias.DataTextField = "nome";
                dropDownMaterias.DataValueField = "idMateria";
                dropDownMaterias.DataBind();

                // dgMaterias.DataSource = Professor.BuscaMateriaProfessor(Convert.ToInt32(Request.QueryString["id"]));
                Session["lista_de_materias"] = Professor.BuscaMateriaProfessor(Convert.ToInt32(Request.QueryString["id"]));
                dgMaterias.DataSource = Session["lista_de_materias"];
                dgMaterias.DataBind();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            prof.nome = txtNome.Text;
            prof.idade = Convert.ToInt32(txtIdade.Text);
            prof.sexo = DropDownSexo.Text[0];

            if (txtID.Text == "")
            {
                prof.Salvar();

                var p = new Professor { idProfessor = Professor.BuscaIdProfessor() };

                if (Session["lista_de_materias"] != null)
                {
                    var listaMateria = (HashSet<Professor>)Session["lista_de_materias"];

                    foreach (var item in listaMateria)
                    {
                        p.idMateria = item.idMateria;
                        p.SalvarMateriaProfessor();

                    }
                }

                Response.Write("<script>alert('Professor " + txtNome.Text + " salvo com sucesso.');</script>");

                Session.Remove("lista_de_materias");
            }
            else
            {
                var p = new Professor { idProfessor = Convert.ToInt32(txtID.Text) };

                if (Session["lista_de_materias"] != null)
                {
                    // remove todas as materias pq senao ocorreu duplicatas (gambiarra)
                    p.RemoveAllMaterias(p.idProfessor);

                    // pega todas as materias da sessão
                    var lista = (HashSet<Professor>)Session["lista_de_materias"];

                    foreach (var item in lista)
                    {
                        p.idMateria = item.idMateria;
                        p.SalvarMateriaProfessor();
                    }
                }
                Session.Remove("lista_de_materias");

                prof.idProfessor = Convert.ToInt32(txtID.Text);
                prof.Alterar();

                Response.Write("<script>alert('Professor " + txtNome.Text + " alterado com sucesso.');</script>");
            }

            //gridProfessor.DataSource = prof.Buscar();
            //gridProfessor.DataBind();
            //limpaCampos();
            //txtNome.Focus();
            Response.Redirect("ListagemProfessores.aspx");
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            prof.idProfessor = Convert.ToInt32(txtID.Text);
            prof.Deletar();
            Response.Write("<script>alert('Professor " + txtNome.Text + " excluído com sucesso.');</script>");

            //gridProfessor.DataSource = prof.Buscar();
            //gridProfessor.DataBind();
            //limpaCampos();
            //txtNome.Focus();
        }

        protected void gridProfessor_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edit"))
            {
                txtID.Text = e.Item.Cells[0].Text;
                txtNome.Text = e.Item.Cells[1].Text;
                txtIdade.Text = e.Item.Cells[2].Text;
                DropDownSexo.Text = e.Item.Cells[3].Text == "Masculino" ? "M" : "F";

                txtNome.Focus();
                //DropDownSexo.Text = e.Item.Cells[3].Text;
                //Response.Redirect("Pagina2.aspx?nome=" + e.Item.Cells[1].Text + "&idade=21&idade=");
                //Response.Write("<script>alert('" + e.Item.Cells[1].Text + " excluído com sucesso.')</script>");
            }
            if (e.CommandName.Equals("Delete"))
            {
                prof.idProfessor = Convert.ToInt32(e.Item.Cells[0].Text);
                prof.Deletar();

                Response.Write("<script>alert('" + e.Item.Cells[1].Text + " excluído com sucesso.')</script>");
                LimpaCampos();
            }

            //gridProfessor.DataSource = prof.Buscar();
            //gridProfessor.DataBind();
            txtNome.Focus();
        }

        protected void gridProfessor_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            e.Item.Cells[3].Text = e.Item.Cells[3].Text == "M" ? "Masculino" : "Feminino";
        }

        protected void gridProfessor_EditCommand(object source, DataGridCommandEventArgs e)
        {

        }

        //protected void gridProfessor_ItemCreated(object sender, DataGridItemEventArgs e)
        //{
        //    e.Item.Cells[0].Attributes.Add("onmouseover", "this.style.backgroundColor='red'");
        //    e.Item.Cells[0].Attributes.Add("onmouseout", "this.style.backgroundColor='white'");
        //}

        private void LimpaCampos()
        {
            txtID.Text = null;
            txtNome.Text = null;
            txtIdade.Text = null;
            DropDownSexo.Text = null;
            txtNome.Focus();
        }

        protected void btnLimparCampos_Click(object sender, EventArgs e)
        {
            Session.Remove("lista_de_materias");
            LimpaCampos();
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Session.Remove("lista_de_materias");
            Response.Redirect("ListagemProfessores.aspx");
        }

        protected void btnAddMateria_Click(object sender, EventArgs e)
        {
            var listaMateria = new HashSet<Professor>();
            if (Session["lista_de_materias"] != null)
            {
                listaMateria = (HashSet<Professor>)Session["lista_de_materias"];
            }

            // adicionando nova matéria no set populado pela sessão
            listaMateria.Add(new Professor
            {
                idMateria = Convert.ToInt32(dropDownMaterias.SelectedItem.Value),
                nome = dropDownMaterias.SelectedItem.Text
            });
            Session["lista_de_materias"] = listaMateria;

            dgMaterias.DataSource = listaMateria;
            dgMaterias.DataBind();
        }

        protected void gridArray_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Delete"))
            {
                //var item1 = e.Item.ToString();
                var row = (Professor)e.Item.DataItem;

                //Response.Write("<script>alert('selecteditem.id datagrid: " + item1 = + "')</script>");
                //Response.Write("<script>alert('var item2 = e.Item.ItemIndex.ToString();: " + item2 + "')</script>");
                //lista.RemoveAt(Convert.ToInt32(item2));

                _lista = (HashSet<Professor>)Session["lista_de_materias"];
                _lista.Remove(row);
                Session["lista_de_materias"] = _lista;

            }
        }

        protected void dgMaterias_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Delete"))
            {
                var row = (Professor)e.Item.DataItem;
                //Response.Write("<script>alert('Deletar item: " + row + "')</script>");

                _lista = (HashSet<Professor>)Session["lista_de_materias"];
                _lista.Remove(row);
                Session["lista_de_materias"] = _lista;

                dgMaterias.DataSource = _lista;
                dgMaterias.DataBind();
            }
            //if (e.CommandName.Equals("Edit"))
            //{
            //    var materia = e.Item.Cells[1].Text;
            //    dropDownMaterias.DataTextField = materia;
            //}
        }
    }
}