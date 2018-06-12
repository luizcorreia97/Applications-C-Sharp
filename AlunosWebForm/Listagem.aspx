<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="AlunosWebForm.Listagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Alunos</title>
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
            <a class="navbar-brand" href="LoginCookie.aspx">Alunos</a>
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
            <h1 style="margin-top: 60px;">Listagem Aluno</h1>
            <br />
            <br />
            <asp:DataGrid ID="gridAluno" runat="server" CssClass="table" CellPadding="4" GridLines="Horizontal" Height="325px" OnItemCommand="gridAluno_ItemCommand" Width="590px" AutoGenerateColumns="False" OnPageIndexChanged="gridAluno_PageIndexChanged" PageSize="3" AllowPaging="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
                <Columns>
                    <asp:BoundColumn DataField="idAluno" HeaderText="ID"></asp:BoundColumn>
                    <asp:BoundColumn DataField="nome" HeaderText="Nome"></asp:BoundColumn>
                    <asp:BoundColumn DataField="idade" HeaderText="Idade"></asp:BoundColumn>
                    <asp:EditCommandColumn CancelText="Cancel" EditText="Editar" HeaderText="Editar" UpdateText="Editar"></asp:EditCommandColumn>
                    <asp:ButtonColumn CommandName="Delete" HeaderText="Excluir" Text="Excluir"></asp:ButtonColumn>
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
