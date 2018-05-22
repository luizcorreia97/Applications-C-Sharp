<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sessao.aspx.cs" Inherits="ProfessoresWebForms.Sessao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
        <br />
    
    </div>
        <asp:DataGrid ID="dgProfessores" runat="server" Height="246px" Width="370px">
        </asp:DataGrid>
        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" />
    </form>
</body>
</html>
