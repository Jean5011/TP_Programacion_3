<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ej5.aspx.cs" Inherits="Tp2.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Eliga su configuraciòn</h1>
        <div>
            <h4>Seleccione la cantidad de memoria</h4>
            <asp:DropDownList ID="DropDownList" runat="server" style="margin-left: 183px; margin-right: 68px;" Height="33px" Width="109px">
                <asp:ListItem Value="200">2 GB</asp:ListItem>
                <asp:ListItem Value="375">4 GB</asp:ListItem>
                <asp:ListItem Value="500">6 GB</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <h4>Seleccione la cantidad de memoria</h4>
        </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" style="margin-left: 184px">
            <asp:ListItem Value="2000,50">Monitor LCD</asp:ListItem>
            <asp:ListItem Value=" 550,50">HD 500GB</asp:ListItem>
            <asp:ListItem Value="1200 ">Grabador DVD</asp:ListItem>
        </asp:CheckBoxList>
        <p>
            <asp:Button ID="Button" runat="server" OnClick="Button_Click" style="margin-left: 213px; margin-bottom: 33px" Text="Calcular precio" />
        </p>
        <p>
            <asp:Label ID="Label" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
