<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gerenciar.aspx.cs" Inherits="AlunosWebForm.Gerenciar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gerenciar Alunos</title>
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
                    <a class="navbar-brand"href="LoginCookie.aspx">Alunos</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/Listagem.aspx">Listagem</a></li>
                        <li><a runat="server" href="~/Gerenciar.aspx">Adicionar</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container">
            <br />
           <h1 style="margin-top: 60px;">Gerenciar Aluno</h1>
            <%--<asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click" Text="Voltar" />--%>
            <br />
            <div class="row">
                <div class="col-md-1">
                    <label>ID:</label>
                    <asp:TextBox ID="txtID" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label>Nome:</label>
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-1">
                    <label>Idade:</label>
                    <asp:TextBox ID="txtIdade" type="number" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3" style="margin-top: 25px;">
                    <asp:Button ID="Button2" CssClass="btn btn-warning" runat="server" OnClick="btnLimparCampos_Click" Text="Limpar" Width="92px"/>
                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" OnClick="btnSalvar_Click" Text="Salvar" Width="85px"/>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-2">
                    <label>Matéria:</label>
                    <asp:DropDownList ID="dropDownMaterias" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <div class="col-md-2">
                    <label>Nota 2:</label>
                    <asp:TextBox ID="txtNota1" type="number" runat="server" CssClass="form-control">
                    </asp:TextBox>
                </div>
                <div class="col-md-2">
                    <label>Nota 2:</label>
                    <asp:TextBox ID="txtNota2" type="number" runat="server" CssClass="form-control">
                    </asp:TextBox>
                </div>
                <div class="col-md-2" style="margin-top: 25px;">
                    <asp:Button ID="btnAddNota" runat="server" CssClass="btn btn-primary" OnClick="btnAddMateria_Click" Text="Adicionar" Width="85px"/>
                </div>
                <div class="col-md-2" style="margin-top: 25px;">
                </div>
            </div>
            
            <br />
            <asp:DataGrid ID="dgMaterias" runat="server" CssClass="table" CellPadding="4" ForeColor="#333333" GridLines="None" Height="158px" Width="670px" AutoGenerateColumns="False" OnItemCommand="dgMaterias_ItemCommand" OnPageIndexChanged="dgMaterias_PageIndexChanged" PageSize="3">
                <AlternatingItemStyle BackColor="White" />
                <Columns>
                    <asp:BoundColumn DataField="idMateria" HeaderText="Código"></asp:BoundColumn>
                    <asp:BoundColumn DataField="nome" HeaderText="Matéria"></asp:BoundColumn>
                    <asp:BoundColumn DataField="nota1" HeaderText="Nota 1"></asp:BoundColumn>
                    <asp:BoundColumn DataField="nota2" HeaderText="Nota 2"></asp:BoundColumn>
                    <asp:EditCommandColumn CancelText="Cancel" EditText="Editar" HeaderText="Ação" UpdateText="Update"></asp:EditCommandColumn>
                    <asp:ButtonColumn CommandName="Delete" Text="Excluir" HeaderText="Ação"></asp:ButtonColumn>
                </Columns>
                <EditItemStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#EFF3FB" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" Mode="NumericPages" />
                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>
        </div>
     </form>   
</body>
</html>
