<!DOCTYPE html>
<html>
   <head>
      <meta charset="utf-8" />
      <meta name="viewport" content="width=device-width, initial-scale=1.0" />
      <link rel="icon" href="https://avatars0.githubusercontent.com/u/22556132?s=460&v=4">
      <title>Professores</title>
       <%-- <environment names="Development">
         <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.css" />
         <link rel="stylesheet" href="~/css/site.css" />
      </environment>--%>
      <environment names="Staging,Production">
         <link rel="stylesheet" href="https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.6/css/bootstrap.min.css" />
       <%--<asp-fallback-href="~/lib/bootstrap/dist/css/bootstrap.min.css" />--%>            <%--asp-fallback-test-class="sr-only" asp-fallback-test-property="position" asp-fallback-test-value="absolute" />--%>            <%--<link rel="stylesheet" href="~/css/site.min.css" asp-append-version="true" />--%>
      </environment>
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
               <a asp-area="" asp-controller="Home" asp-action="Index" class="navbar-brand">Professores</a>
            </div>
            <div class="navbar-collapse collapse">
               <ul class="nav navbar-nav">
                  <li><a asp-area="" asp-controller="Home" asp-action="Index">Home</a></li>
                  <li><a asp-area="" asp-controller="Home" asp-action="About">About</a></li>
                  <li><a asp-area="" asp-controller="Home" asp-action="Contact">Contact</a></li>
               </ul>
                <%--@await Html.PartialAsync("_LoginPartial")--%>
            </div>
         </div>
      </div>
      <form id="form1" runat="server" style="margin-top: 80px;">
         <div class="container">
             <div class="col-md-11">
                 <div class="row">
                    <div class="col-xs-10 col-md-10">
                      <h2 class="form-signin-heading">Cadastro</h2>
                     </div>
                 </div>
                 <br />
                 <div class="row">
                     <div class="col-xs-10 col-md-8">
                          <label>Nome</label>
                          <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" placeholder="Digite o nome" required />
                     </div>
                 </div>
                 <br />
                 <div class="row">
                     <div class="col-xs-10 col-md-4">
                           <label>Idade</label>
                            <asp:TextBox ID="txtIdade" runat="server" TextMode="Number" CssClass="form-control" placeholder="Digite a idade" required />
                     </div>
                     <div class="col-xs-10 col-md-3">
                        <label for="txtPassword">Sexo</label>
                        <asp:DropDownList ID="drdSexo" CssClass="form-control" runat="server">
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-xs-10 col-md-1">
                       <label style="display: block"> &nbsp;</label>
                       <asp:Button ID="Button1" Text="Salvar" style="float: right;" runat="server" Class="btn btn-success" />
                    </div>
                 </div>
                <br />
                <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
                   <strong>Error!</strong>
                   <asp:Label ID="lblMessage" runat="server" />
                </div>
             </div>
          </div>
      </form>
      <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-2.2.0.min.js"
         asp-fallback-src="~/lib/jquery/dist/jquery.min.js"
         asp-fallback-test="window.jQuery"></script>
      <script src="https://ajax.aspnetcdn.com/ajax/bootstrap/3.3.6/bootstrap.min.js"
         asp-fallback-src="~/lib/bootstrap/dist/js/bootstrap.min.js"
         asp-fallback-test="window.jQuery && window.jQuery.fn && window.jQuery.fn.modal"></script>
       <%--<script src="~/js/site.min.js" asp-append-version="true"></script>--%>
   </body>
</html>