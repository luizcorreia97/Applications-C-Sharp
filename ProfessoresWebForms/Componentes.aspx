<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Componentes.aspx.cs" Inherits="ProfessoresWebForms.Componentes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server" Height="49px" Width="98px"></asp:Table>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Sexo:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="23px" Width="234px">
            <asp:ListItem Value="M">Masculino</asp:ListItem>
            <asp:ListItem Value="F">Feminino</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Professor:"></asp:Label>
        <asp:DropDownList ID="drtProfessor" runat="server" Height="23px" Width="234px">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="152px" Width="161px">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
        </asp:RadioButtonList>
    </div>
    </form>
</body>
</html>
