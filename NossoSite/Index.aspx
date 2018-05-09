<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="NossoSite.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>HOME</div>
        <hr />
        <div>
            <asp:Label ID="Label3" runat="server" Text="Campo 1:"></asp:Label>
            <asp:TextBox ID="txtCampo1" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label ID="Label4" runat="server" Text="Campo 2:"></asp:Label>
            <asp:TextBox ID="txtCampo2" runat="server"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="width: 24px" Text="+" />
            <asp:TextBox ID="txtResultado0" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
