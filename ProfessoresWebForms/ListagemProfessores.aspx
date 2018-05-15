<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListagemProfessores.aspx.cs" Inherits="ProfessoresWebForms.ListagemProfessores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            LISTAGEM DE PROFESSORES<br />
            <br />
            Filtros:<br />
            <br />
            Sexo:<asp:RadioButtonList ID="rbListSexo" runat="server" AutoPostBack="True" Width="130px">
                    <asp:ListItem Value="M','F">Todos</asp:ListItem>
                    <asp:ListItem Value="M">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Feminino</asp:ListItem>
                </asp:RadioButtonList>

            <br />

            Idade:<asp:CheckBoxList ID="chkListIdade" runat="server" AutoPostBack="True">
                <asp:ListItem>&lt; 20</asp:ListItem>
                <asp:ListItem>&gt;= 20</asp:ListItem>
                <asp:ListItem>&gt;= 40</asp:ListItem>
                <asp:ListItem>&gt; 60</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="btnAdicionar" runat="server" OnClick="btnAdicionar_Click" Text="Adicionar" />
            <br />
            <br />
        </div>
        <asp:DataGrid ID="gridProfessor" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="325px" OnItemCommand="gridProfessor_ItemCommand" Width="590px" AutoGenerateColumns="False" OnItemDataBound="gridProfessor_ItemDataBound">
            <AlternatingItemStyle BackColor="White" />
            <Columns>
                <asp:BoundColumn DataField="idProfessor" HeaderText="ID"></asp:BoundColumn>
                <asp:BoundColumn DataField="nome" HeaderText="Nome"></asp:BoundColumn>
                <asp:BoundColumn DataField="idade" HeaderText="Idade"></asp:BoundColumn>
                <asp:BoundColumn DataField="Sexo" HeaderText="Sexo"></asp:BoundColumn>
                <asp:EditCommandColumn CancelText="Cancel" EditText="Editar" HeaderText="Editar" UpdateText="Editar"></asp:EditCommandColumn>
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
