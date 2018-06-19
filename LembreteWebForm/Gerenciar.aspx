<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gerenciar.aspx.cs" Inherits="LembreteWebForm.Gerenciar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gerenciar Lembrete</title>
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
                    <a class="navbar-brand"href="Login.aspx">Log Out</a>
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
           <h1 style="margin-top: 60px;">Gerenciar Lembrete</h1>
            <br />
            <div class="row">
                <div class="col-md-1">
                    <label>ID:</label>
                    <asp:TextBox ID="txtID" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                </div>
                <div class="col-md-6">
                    <label>Descrição:</label>
                    <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
             </div>
            <br />
             <div class="row">
                <div class="col-md-2">
                    <label>Dia:</label>
                    <asp:TextBox ID="txtDia" type="date" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-1">
                    <label>Hora:</label>
                    <asp:TextBox ID="txtHora" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-2">
                    <label>Status:</label>
                    <asp:DropDownList ID="dropDownStatus" runat="server" CssClass="form-control">
                        <asp:ListItem>Em Aberto</asp:ListItem>
                        <asp:ListItem>Cancelado</asp:ListItem>
                        <asp:ListItem>Finalizado</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-3" style="margin-top: 25px;">
                    <asp:Button ID="Button2" CssClass="btn btn-warning" runat="server" OnClick="btnLimparCampos_Click" Text="Limpar" Width="92px"/>
                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" OnClick="btnSalvar_Click" Text="Salvar" Width="85px"/>
                </div>
            </div>
        </div>
     </form>   
</body>
</html>
