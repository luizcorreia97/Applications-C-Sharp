using Minhas_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlunosWebForm
{
    public partial class Gerenciar : System.Web.UI.Page
    {
        Minhas_Classes.Aluno aluno = new Minhas_Classes.Aluno();
        private HashSet<Aluno> _lista = new HashSet<Aluno>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtNome.Focus();
                txtID.Text = Request.QueryString["id"];
                txtNome.Text = Request.QueryString["nome"];
                txtIdade.Text = Request.QueryString["idade"];

                dropDownMaterias.DataSource = aluno.BuscarMateria();
                dropDownMaterias.DataTextField = "nome";
                dropDownMaterias.DataValueField = "idMateria";
                dropDownMaterias.DataBind();
                
                Session["lista_de_materias"] = aluno.BuscaNotaAluno(Convert.ToInt32(Request.QueryString["id"]));
                dgMaterias.DataSource = Session["lista_de_materias"];
                dgMaterias.DataBind();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            aluno.nome = txtNome.Text;
            aluno.idade = Convert.ToInt32(txtIdade.Text);

            if (txtID.Text == "")
            {
                aluno.Salvar();

                Aluno p = new Aluno();
                
                p.idAluno = p.BuscaIdAluno();

                //var p = new Aluno { idAluno = Aluno.BuscaIdAluno() };

                if (Session["lista_de_materias"] != null)
                {
                    var listaMateria = (HashSet<Aluno>)Session["lista_de_materias"];

                    foreach (var item in listaMateria)
                    {
                        p.idMateria = item.idMateria;
                        p.nota1 = item.nota1;
                        p.nota2 = item.nota2;
                        p.SalvarNotaAluno();
                    }
                }

                Response.Write("<script>alert('Aluno " + txtNome.Text + " salvo com sucesso.');</script>");

                Session.Remove("lista_de_materias");
            }
            else
            {
                Aluno p = new Aluno();

                p.idAluno = Convert.ToInt32(txtID.Text);

                if (Session["lista_de_materias"] != null)
                {
                    // remove todas as materias pq senao ocorreu duplicatas (gambiarra)
                    p.RemoveAllNotas(p.idAluno);

                    // pega todas as materias da sessão
                    var lista = (HashSet<Aluno>)Session["lista_de_materias"];

                    foreach (var item in lista)
                    {
                        p.idMateria = item.idMateria;
                        p.nota1 = item.nota1;
                        p.nota2 = item.nota2;
                        p.SalvarNotaAluno();
                    }
                }
                Session.Remove("lista_de_materias");

                aluno.idAluno = Convert.ToInt32(txtID.Text);
                aluno.Alterar();

                Response.Write("<script>alert('Professor " + txtNome.Text + " alterado com sucesso.');</script>");
            }
            Response.Redirect("Listagem.aspx");
        }

        protected void btnLimparCampos_Click(object sender, EventArgs e)
        {
            Session.Remove("lista_de_materias");
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            txtID.Text = null;
            txtNome.Text = null;
            txtIdade.Text = null;
            txtNome.Focus();
        }

        protected void btnAddMateria_Click(object sender, EventArgs e)
        {
            var listaMateria = new HashSet<Aluno>();
            if (Session["lista_de_materias"] != null)
            {
                listaMateria = (HashSet<Aluno>)Session["lista_de_materias"];
            }

            // adicionando nova matéria no set populado pela sessão
            listaMateria.Add(new Aluno
            {
                idMateria = Convert.ToInt32(dropDownMaterias.SelectedItem.Value),
                nota1 = Convert.ToDouble(txtNota1.Text),
                nota2 = Convert.ToDouble(txtNota2.Text),
                nome = dropDownMaterias.SelectedItem.Text
            });
            Session["lista_de_materias"] = listaMateria;

            dgMaterias.DataSource = listaMateria;
            dgMaterias.DataBind();
        }

        protected void dgMaterias_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Delete"))
            {
                //Response.Write("<script>alert('Deletar item posição: " + indexRow + "')</script>");
                var indexRow = e.Item.ItemIndex;
                _lista = (HashSet<Aluno>)Session["lista_de_materias"];

                // transform hash on a list than you can manage with removeAt
                var listOfHash = _lista.ToList();
                listOfHash.RemoveAt(indexRow);

                // clear the list and get the new hash with removed value
                _lista.Clear();
                _lista.UnionWith(listOfHash);

                // update the lists
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