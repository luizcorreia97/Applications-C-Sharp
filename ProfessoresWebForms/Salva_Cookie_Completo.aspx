<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salva_Cookie_Completo.aspx.cs" Inherits="ProfessoresWebForms.Salva_Cookie_Completo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="btn_salva_dados" runat="server" OnClick="btn_salva_dados_Click" Text="Salvar Cookie Completo" />
        <asp:Button ID="btn_recupera_cookie_completo" runat="server" OnClick="btn_recupera_cookie_completo_Click" Text="Recupera Cookie Completo" />
    </form>
</body>
</html>
