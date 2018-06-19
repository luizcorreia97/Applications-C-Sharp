<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="LembreteWebForm.Listagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lembretes</title>
    <meta charset="utf-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <link rel="icon" href="https://avatars0.githubusercontent.com/u/22556132?s=460&v=4" />
    <link rel="stylesheet" href="https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.6/css/bootstrap.min.css" />
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="Login.aspx">Log Out</a>
        </div>
        <div class="navbar-collapse collapse">
            <ul class="nav navbar-nav">
                <li><a runat="server" href="~/Listagem.aspx">Listagem</a></li>
                <li><a runat="server" href="~/Gerenciar.aspx">Adicionar</a></li>
            </ul>
        </div>
        </div>
    </div>
    <form id="form2" runat="server">
        <div class="container">
            <br />
            <h1 style="margin-top: 60px;">Lembretes</h1>
            <br />
            <div class="row">
                <div class="col-md-2">
                    <label>Filtro Por Mês:</label>
                        <asp:DropDownList ID="dropDownMes" runat="server" CssClass="form-control" AutoPostBack="True">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem Value="01">Janeiro</asp:ListItem>
                            <asp:ListItem Value="02">Fevereiro</asp:ListItem>
                            <asp:ListItem Value="03">Março</asp:ListItem>
                            <asp:ListItem Value="04">Abril</asp:ListItem>
                            <asp:ListItem Value="05">Maio</asp:ListItem>
                            <asp:ListItem Value="06">Junho</asp:ListItem>
                            <asp:ListItem Value="07">Julho</asp:ListItem>
                            <asp:ListItem Value="08">Agosto</asp:ListItem>
                            <asp:ListItem Value="09">Setembro</asp:ListItem>
                            <asp:ListItem Value="10">Outubro</asp:ListItem>
                            <asp:ListItem Value="11">Novembro</asp:ListItem>
                            <asp:ListItem Value="12">Dezembro</asp:ListItem>
                        
                        </asp:DropDownList>
                    </div>
            </div>
            <br />
            <asp:DataGrid ID="gridLembrete" runat="server" CssClass="table table-hover table-striped" Width="100%" OnItemCommand="gridLembrete_ItemCommand" AutoGenerateColumns="False" OnPageIndexChanged="gridLembrete_PageIndexChanged" PageSize="5" AllowPaging="True" CellPadding="4" GridLines="None" OnItemDataBound="gridLembrete_ItemDataBound">
                <Columns>
                    <asp:BoundColumn DataField="idLembrete" HeaderText="ID"></asp:BoundColumn>
                    <asp:BoundColumn DataField="descricao" HeaderText="Descrição"></asp:BoundColumn>
                    <asp:BoundColumn DataField="dia" HeaderText="Dia"></asp:BoundColumn>
                    <asp:BoundColumn DataField="horario" HeaderText="Hora"></asp:BoundColumn>
                    <asp:BoundColumn DataField="status" HeaderText="Status"></asp:BoundColumn>
                    <asp:ButtonColumn CommandName="Delete" HeaderText="Ação" Text="Excluir"></asp:ButtonColumn>
                    <asp:EditCommandColumn CancelText="Cancel" EditText="Editar" HeaderText="Ação" UpdateText="Editar"></asp:EditCommandColumn>
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="White" ForeColor="#333333" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" Mode="NumericPages" />
                <SelectedItemStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            </asp:DataGrid>
        </div>
    </form>
</body>
</html>

