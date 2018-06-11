<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProfessoresWebForms.Index" %>

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
    <form id="form2" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand"href="~/LoginCookie.aspx">Professores</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/ListagemProfessores.aspx">Listagem</a></li>
                        <li><a runat="server" href="~/Index.aspx">Adicionar</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container">
           <h1 style="margin-top: 60px;">Gerenciar Professor</h1>
                <%--<asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click" Text="Voltar" />--%>
            <br />
            <br />
            <div class="row">
                <div class="col-md-1">
                    <label>ID:</label>
                    <asp:TextBox ID="txtID" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                </div>
                <div class="col-md-7">
                    <label>Nome:</label>
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" Width="380px"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-1">
                    <label>Idade:</label>
                    <asp:TextBox ID="txtIdade" type="number" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-2">
                    <label>Sexo:</label>
                    <asp:DropDownList ID="DropDownSexo" runat="server" CssClass="form-control" Style="margin-left: 6px" Width="117px">
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-3" style="margin-top: 25px; margin-left: -10px;"">
                    <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-success" OnClick="btnSalvar_Click" Text="Salvar"/>
                    <asp:Button ID="btnLimparCampos" CssClass="btn btn-warning" runat="server" OnClick="btnLimparCampos_Click" Text="Limpar Campos"/>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-2">
                    <label>Matérias:</label>
                    <asp:DropDownList ID="dropDownMaterias" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <div class="col-md-2" style="margin-top: 25px;">
                    <asp:Button ID="btnAddMateria" runat="server" CssClass="btn btn-primary" OnClick="btnAddMateria_Click" Text="Adicionar"/>
                </div>
            </div>
            
            <br />
            <%--<asp:DataGrid ID="gridProfessor" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="273px" OnEditCommand="gridProfessor_EditCommand" OnItemCommand="gridProfessor_ItemCommand" OnItemDataBound="gridProfessor_ItemDataBound" PageSize="3" Width="679px">
                <AlternatingItemStyle BackColor="White" />
                <Columns>
                    <asp:BoundColumn DataField="idProfessor" HeaderText="ID"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Nome" HeaderText="Nome"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Idade" HeaderText="Idade"></asp:BoundColumn>
                    <asp:BoundColumn DataField="Sexo" HeaderText="Sexo"></asp:BoundColumn>
                    <asp:EditCommandColumn CancelText="Cancel" EditText="Editar" HeaderText="Editar" UpdateText="Update"></asp:EditCommandColumn>
                    <asp:ButtonColumn CommandName="Delete" HeaderText="Excluir" Text="Excluir"></asp:ButtonColumn>
                </Columns>
                <EditItemStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#E3EAEB" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>--%>
            <asp:DataGrid ID="dgMaterias" runat="server" CssClass="table" CellPadding="4" ForeColor="#333333" GridLines="None" Height="157px" Width="324px" AutoGenerateColumns="False" OnItemCommand="dgMaterias_ItemCommand">
                <AlternatingItemStyle BackColor="White" />
                <Columns>
                    <asp:BoundColumn DataField="idMateria" HeaderText="Código"></asp:BoundColumn>
                    <asp:BoundColumn DataField="nome" HeaderText="Matéria"></asp:BoundColumn>
                    <asp:ButtonColumn CommandName="Delete" Text="Excluir" HeaderText="Ação"></asp:ButtonColumn>
                </Columns>
                <EditItemStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#EFF3FB" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>
        </div>
     </form>   
</body>
</html>
