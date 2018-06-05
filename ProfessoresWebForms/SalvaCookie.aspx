<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalvaCookie.aspx.cs" Inherits="ProfessoresWebForms.SalvaCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Button ID="btn_salva_cookies" runat="server" OnClick="btn_salva_cookies_Click" Text="Salva Cookie" />
        <asp:Button ID="btn_recupera_cookie" runat="server" Text="Recupera Cookie" OnClick="btn_recupera_cookie_Click" />
    </form>
</body>
</html>
