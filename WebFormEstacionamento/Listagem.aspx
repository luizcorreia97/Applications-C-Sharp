<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="WebFormEstacionamento.Listagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            GERENCIAMENTO DE VEÍCULOS NO ESTACIONAMENTO<br />
            <br />

            <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" Style="margin-left: 32px" Width="26px" Enabled="False"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Placa:"></asp:Label>
            <asp:TextBox ID="txtPlaca" runat="server" Width="87px" Style="margin-left: 6px"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="Veículo:"></asp:Label>
            <asp:TextBox ID="txtVeiculo" runat="server" Width="87px" Style="margin-left: 6px"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Cor:"></asp:Label>
            <asp:DropDownList ID="DropDownCor" runat="server" Style="margin-left: 6px" Width="117px" AutoPostBack="True">
                <asp:ListItem>Preto</asp:ListItem>
                <asp:ListItem>Branco</asp:ListItem>
                <asp:ListItem>Vermelho</asp:ListItem>
                <asp:ListItem>Azul</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Data Entrada:"></asp:Label>
            <asp:TextBox ID="txtDataEntrada" runat="server" Width="87px" Style="margin-left: 6px"></asp:TextBox>
            <asp:Label ID="Label9" runat="server" Text="Hora Entrada:"></asp:Label>
            <asp:TextBox ID="txtHoraEntrada" runat="server" Width="87px" Style="margin-left: 6px"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Text="Data Saída:"></asp:Label>
            <asp:TextBox ID="txtDataSaida" runat="server" Width="87px" Style="margin-left: 6px"></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="Hora Saída:"></asp:Label>
            <asp:TextBox ID="txtHoraSaida" runat="server" Width="87px" Style="margin-left: 6px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Valor Pago:"></asp:Label>
            &nbsp;<asp:TextBox ID="txtValorPago" runat="server" Style="margin-left: 10px" Width="88px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Status:"></asp:Label>
            &nbsp;<asp:RadioButtonList ID="RadioButtonListStatus" runat="server">
                <asp:ListItem>Em Aberto</asp:ListItem>
                <asp:ListItem>Finalizado</asp:ListItem>
            </asp:RadioButtonList>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" Width="100px" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="btnLimparCampos" runat="server" OnClick="btnLimparCampos_Click" Text="Limpar Campos" Width="133px" />

            <br />
            <br />

        </div>
        <asp:DataGrid ID="gridEstacionamento" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="325px" OnItemCommand="gridEstacionamento_ItemCommand" Width="590px" AutoGenerateColumns="False" OnItemDataBound="gridProfessor_ItemDataBound" AllowPaging="True" PageSize="3">
            <AlternatingItemStyle BackColor="White" />
            <Columns>
                <asp:BoundColumn DataField="idEstacionamento" HeaderText="ID"></asp:BoundColumn>
                <asp:BoundColumn DataField="placa" HeaderText="Placa"></asp:BoundColumn>
                <asp:BoundColumn DataField="veiculo" HeaderText="Veículo"></asp:BoundColumn>
                <asp:BoundColumn DataField="cor" HeaderText="Cor"></asp:BoundColumn>
                <asp:BoundColumn DataField="dataEntrada" HeaderText="Data Entrada"></asp:BoundColumn>
                <asp:BoundColumn DataField="horaEntrada" HeaderText="Hora Entrada"></asp:BoundColumn>
                <asp:BoundColumn DataField="dataSaida" HeaderText="dataSaida"></asp:BoundColumn>
                <asp:BoundColumn DataField="valorPago" HeaderText="valorPago"></asp:BoundColumn>
                <asp:BoundColumn DataField="status" HeaderText="status"></asp:BoundColumn>
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
