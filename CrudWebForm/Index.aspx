<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProfessoresWebForms.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            PROFESSORES<br />
        </div>
        <hr />
        <div>
            <asp:HyperLink ID="HyperLink2" NavigateUrl="ListagemProfessores.aspx" runat="server">Voltar</asp:HyperLink>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" Style="margin-left: 32px" Width="88px" Enabled="False"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" Width="351px" Style="margin-left: 6px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Idade:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtIdade" runat="server" Style="margin-left: 10px" Width="88px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Sexo:"></asp:Label>
            &nbsp;<asp:DropDownList ID="DropDownSexo" runat="server" Style="margin-left: 6px" Width="117px">
                <asp:ListItem Value="M">Masculino</asp:ListItem>
                <asp:ListItem Value="F">Feminino</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" Width="100px" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="btnLimparCampos" runat="server" OnClick="btnLimparCampos_Click" Text="Limpar Campos" Width="133px" />

            <br />
        </div>
        <br />
        <asp:DataGrid ID="gridProfessor" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="273px" OnEditCommand="gridProfessor_EditCommand" OnItemCommand="gridProfessor_ItemCommand" OnItemDataBound="gridProfessor_ItemDataBound" PageSize="3" Width="679px">
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
        </asp:DataGrid>
    </form>
</body>
</html>
