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

        public static bool controlEdit = false;
        public static int indexRow = 0;

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
                //dgMaterias.VirtualItemCount = 2;
                //dgMaterias.AllowCustomPaging = true;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            aluno.nome = txtNome.Text;

            if (txtIdade.Text != "")
            {
                aluno.idade = Convert.ToInt32(txtIdade.Text);
            }

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
                    // remove all records of the dataBase to avoid duplicates
                    p.RemoveAllNotas(p.idAluno);

                    // get all object of the session
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
            txtNome.Text = null;
            txtIdade.Text = null;
            txtNome.Focus();
            txtNota1.Text = null;
            txtNota2.Text = null;
            dropDownMaterias.SelectedIndex = 0;
            controlEdit = false;
            btnAddNota.Text = "Adicionar";
            txtNome.Focus();
        }

        protected void btnAddMateria_Click(object sender, EventArgs e)
        {
            var _lista = new HashSet<Aluno>();

            if (Session["lista_de_materias"] != null)
            {
                _lista = (HashSet<Aluno>)Session["lista_de_materias"];
            }

            //verify condition add or update
            if (controlEdit == false)
            {
                // adding new object on hashSet populated by the session
                _lista.Add(new Aluno
                {
                    idMateria = Convert.ToInt32(dropDownMaterias.SelectedItem.Value),
                    nota1 = Convert.ToDouble(txtNota1.Text),
                    nota2 = Convert.ToDouble(txtNota2.Text),
                    nome = dropDownMaterias.SelectedItem.Text
                });
            }
            else
            {
                // convert hashSet to list
                var listOfHash = _lista.ToList();

                Aluno a = new Aluno();
                a.idMateria = Convert.ToInt32(dropDownMaterias.SelectedItem.Value);
                a.nota1 = Convert.ToDouble(txtNota1.Text);
                a.nota2 = Convert.ToDouble(txtNota2.Text);
                a.nome = dropDownMaterias.SelectedItem.Text;

                // update list in position of the indexRow with object updated
                listOfHash[indexRow] = a;

                // clear the list and get the new hash with removed value
                _lista.Clear();
                _lista.UnionWith(listOfHash);
            }

            // update the lists, clear fields and set focus
            Session["lista_de_materias"] = _lista;
            dgMaterias.DataSource = _lista;
            dgMaterias.DataBind();
            controlEdit = false;
            btnAddNota.Text = "Adicionar";
            dropDownMaterias.SelectedIndex = 0;
            txtNota1.Text = null;
            txtNota2.Text = null;
            txtNota1.Focus();
        }

        protected void dgMaterias_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Delete"))
            {   
                var indexRow = e.Item.ItemIndex;
                //Response.Write("<script>alert('Deletar item posição: " + indexRow + "')</script>");
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
                controlEdit = false;

            }
            if (e.CommandName.Equals("Edit"))
            {
                // get row index selected of the datagrid
                indexRow = e.Item.ItemIndex;

                // attributes hashSet of the session on a list
                _lista = (HashSet<Aluno>)Session["lista_de_materias"];

                // transform hashSet on a list
                var listOfHash = _lista.ToList();

                // get element of the list
                var element = listOfHash.ElementAt(indexRow);

                // set elements on components
                dropDownMaterias.SelectedValue = Convert.ToDouble(element.idMateria).ToString();
                txtNota1.Text = Convert.ToDouble(element.nota1).ToString();
                txtNota2.Text = Convert.ToDouble(element.nota2).ToString();

                controlEdit = true;
                btnAddNota.Text = "Atualizar";
            }
        }

        protected void dgMaterias_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dgMaterias.CurrentPageIndex = e.NewPageIndex;
            dgMaterias.DataSource = aluno.Buscar();
            dgMaterias.DataBind();
        }
    }
}