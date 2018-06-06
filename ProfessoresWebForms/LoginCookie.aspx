<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginCookie.aspx.cs" Inherits="ProfessoresWebForms.LoginCookie" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Login Cookie</title>
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
                   <a class="navbar-brand"href="~/LoginCookie.aspx">Login</a>
                </div>
                <div class="navbar-collapse collapse">
                   <ul class="nav navbar-nav">
                      <li><a runat="server" href="~/CadastroBootstrap.aspx">Home</a></li>
                      <li><a runat="server" href="~/ListagemBootstrap.aspx">Listagem</a></li>
                      <li><a runat="server" href="~/SalvaCookie.aspx">Salvar Cookie</a></li>
                      <li><a runat="server" href="~/RecuperaCookie.aspx">Recuperar Cookie</a></li>
                   </ul>
                </div>
             </div>
          </div>
        <form id="form1" runat="server">
        <div class="container">
            <div style="position: fixed; top: 50%; left: 50%; transform: translate(-50%, -50%); width: 300px; height: 320px; padding: 20px; border-style: solid; border-width:thin; border-color: gray; border-radius: 10px;">
                <h2>Logue-se</h2>
                <br />
                <label>Email</label>
                <asp:TextBox ID="txtLogin" type="email" CssClass="form-control" runat="server"></asp:TextBox>
                <label>Senha</label>
                <asp:TextBox ID="txtSenha" type="password" CssClass="form-control" runat="server"></asp:TextBox>                
                <div class="checkbox" style="margin-left: 20px;">
                    <asp:CheckBox ID="checkLembrar" runat="server" Text="Lembre-me" />
                </div>
                <asp:Button ID="btnLogin" CssClass="btn btn-primary btn-block" runat="server" OnClick="Button1_Click" Text="Login" />
            </div>
        </div>
        </form>
    </body>
</html>
