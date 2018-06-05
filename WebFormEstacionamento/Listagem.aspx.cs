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

            else
            {
                estac.Alterar();

                Response.Write("<script>alert('Veículo " + txtVeiculo.Text + " alterado com sucesso.');</script>");

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
                txtID.Text = e.Item.Cells[0].Text;
                txtPlaca.Text = e.Item.Cells[1].Text;
                txtVeiculo.Text = e.Item.Cells[2].Text;
                DropDownCor.Text = e.Item.Cells[3].Text;
                txtDataEntrada.Text = e.Item.Cells[4].Text;
                txtHoraEntrada.Text = e.Item.Cells[5].Text;
                txtDataSaida.Text = e.Item.Cells[6].Text;
                txtHoraSaida.Text = e.Item.Cells[7].Text;
                txtValorPago.Text = e.Item.Cells[8].Text;

                if (e.Item.Cells[9].Text == "Em Aberto")
                {
                    RadioButtonListStatus.Items[0].Selected.ToString();
                }
                else
                {
                    RadioButtonListStatus.Items[1].Selected.ToString();
                }

                //Response.Write("<script>alert('Desejar editar " + e.Item.Cells[1].Text + "?')</script>");
                //Response.Redirect("Index.aspx?id=" + e.Item.Cells[0].Text + "&nome=" + e.Item.Cells[1].Text + "&idade=" + e.Item.Cells[2].Text + "&sexo=" + e.Item.Cells[3].Text); ;
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
            if (e.Item.Cells[9].Text == "Em Aberto")
            {
                e.Item.Cells[9].BackColor = System.Drawing.Color.Red;
            }
            if (e.Item.Cells[9].Text == "Finalizado")
            { 
                e.Item.Cells[9].BackColor = System.Drawing.Color.Green;
            }

        }

        protected void gridEstacionamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gridEstacionamento_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            gridEstacionamento.CurrentPageIndex = e.NewPageIndex;
            gridEstacionamento.DataSource = estac.Buscar();
            gridEstacionamento.DataBind();
        }

        protected void gridEstacionamento_ItemCreated(object sender, DataGridItemEventArgs e)
        {
            e.Item.Cells[0].Attributes.Add("onmouseover", "this.style.backgroundColor='red'"); // ISSO AQUI QUE MUDA  A COR QUANDO PASSA O MOUSE
            //e.Item.Cells[0].Attributes.Add("onmouseout", "this.style.backgroundColor='white'");// VOLTA PARA A COR Q ESTAVA
        }
    }
}