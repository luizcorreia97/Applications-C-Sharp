<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListagemProfessores.aspx.cs" Inherits="ProfessoresWebForms.ListagemProfessores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Professores</title>
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
            <a class="navbar-brand" href="LoginCookie.aspx">Professores</a>
        </div>
        <div class="navbar-collapse collapse">
            <ul class="nav navbar-nav">
                <li><a runat="server" href="~/ListagemProfessores.aspx">Listagem</a></li>
                <li><a runat="server" href="~/Index.aspx">Adicionar</a></li>
            </ul>
        </div>
        </div>
    </div>
    <form id="form1" runat="server">
        <div class="container">
            <h1 style="margin-top: 60px;">Listagem Professor</h1>
            <%--<asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click" Text="Voltar" />--%>
            <br />
            <h4>Filtros</h4>
            <div class="row">
                <div class="col-md-3">
                    <label>Sexo</label>
                    <asp:RadioButtonList ID="rbListSexo" runat="server" AutoPostBack="True" Width="130px" RepeatDirection="Horizontal">
                        <asp:ListItem Value="M','F">Todos</asp:ListItem>
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div class="col-md-3">
                    <label>Idade</label>
                    <asp:CheckBoxList ID="chkListIdade" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                        <asp:ListItem>&lt; 20</asp:ListItem>
                        <asp:ListItem>&gt;= 20</asp:ListItem>
                        <asp:ListItem>&gt;= 40</asp:ListItem>
                        <asp:ListItem>&gt; 60</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
            </div>
            <br />
            <%--<asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />--%>
            <asp:DataGrid ID="gridProfessor" runat="server" CssClass="table" CellPadding="4" GridLines="Horizontal" Height="325px" OnItemCommand="gridProfessor_ItemCommand" Width="590px" AutoGenerateColumns="False" OnItemDataBound="gridProfessor_ItemDataBound" OnPageIndexChanged="gridProfessor_PageIndexChanged" PageSize="3" AllowPaging="True" OnItemCreated="gridProfessor_ItemCreated" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
                <Columns>
                    <asp:BoundColumn DataField="idProfessor" HeaderText="ID"></asp:BoundColumn>
                    <asp:BoundColumn DataField="nome" HeaderText="Nome"></asp:BoundColumn>
                    <asp:BoundColumn DataField="idade" HeaderText="Idade"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Sexo" HeaderText="Sexo"></asp:BoundColumn>
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
