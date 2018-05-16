using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormEstacionamento
{
    public partial class Listagem : System.Web.UI.Page
    {
        Minhas_Classes.Estacionamento estac = new Minhas_Classes.Estacionamento();

        protected void Page_Load(object sender, EventArgs e)
        {
            gridEstacionamento.DataSource = estac.Buscar();
            gridEstacionamento.DataBind();
            //DropDownVeiculo.DataSource = estac.BuscarVeiculo();
            //DropDownVeiculo.DataTextField = "nome";
            //DropDownVeiculo.DataBind();
            //DropDownVeiculo.DataValueField = "nome";
            //txtPlaca.Text = DropDownVeiculo.DataTextField = "placa";

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            estac.placa = txtPlaca.Text;
            estac.veiculo = txtVeiculo.Text;
            estac.cor = DropDownCor.Text;
            estac.dataEntrada = txtDataEntrada.Text;
            estac.horaEntrada = txtHoraEntrada.Text;
            estac.dataSaida = txtDataSaida.Text;
            estac.horaSaida = txtHoraSaida.Text;
            estac.valorPago = txtValorPago.Text;
            estac.status = RadioButtonListStatus.SelectedValue;

            if (txtID.Text == "")
            {
                estac.Salvar();

                Response.Write("<script>alert('Veículo " + txtVeiculo.Text + " salvo com sucesso.');</script>");

                gridEstacionamento.DataSource = estac.Buscar();
                gridEstacionamento.DataBind();
            }

            //limpaCampos();
            //txtNome.Focus();
        }

        protected void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtPlaca.Text = null;
            estac.veiculo = txtVeiculo.Text = null;
            estac.cor = DropDownCor.Text = null;
            estac.dataEntrada = txtDataEntrada.Text = null;
            estac.horaEntrada = txtHoraEntrada.Text = null;
            estac.dataSaida = txtDataSaida.Text = null;
            estac.horaSaida = txtHoraSaida.Text = null;
            estac.valorPago = txtValorPago.Text = null;
            estac.status = null;
        }

        protected void gridEstacionamento_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName.Equals("Edit"))
            {
                Response.Write("<script>alert('Desejar editar " + e.Item.Cells[1].Text + "?')</script>");
                Response.Redirect("Index.aspx?id=" + e.Item.Cells[0].Text + "&nome=" + e.Item.Cells[1].Text + "&idade=" + e.Item.Cells[2].Text + "&sexo=" + e.Item.Cells[3].Text); ;
            }
            if (e.CommandName.Equals("Delete"))
            {
                Response.Write("<script>alert('Desejar excluir " + e.Item.Cells[1].Text + "?')</script>");

                estac.idEstacionamento = Convert.ToInt32(e.Item.Cells[0].Text);
                estac.Deletar();

                gridEstacionamento.DataSource = estac.Buscar();
                gridEstacionamento.DataBind();

                Response.Write("<script>alert('Veículo " + e.Item.Cells[1].Text + " excluído com sucesso.');</script>");
            }
        }

        protected void gridProfessor_ItemDataBound(object sender, DataGridItemEventArgs e)
        {

        }
    }
}