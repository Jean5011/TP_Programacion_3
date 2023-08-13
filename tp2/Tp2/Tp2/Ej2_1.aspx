<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ej2_1.aspx.cs" Inherits="Tp2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:<asp:TextBox ID="TBnombre" runat="server" style="margin-left: 8px; margin-top: 9px" Width="194px"></asp:TextBox>
            <br />
            <br />
            Apellido:
            <asp:TextBox ID="TBapellido" runat="server" Width="188px"></asp:TextBox>
            <br />
            <br />
            Ciudad:
            <asp:DropDownList ID="DDzona" runat="server" AutoPostBack="True" Width="147px">
                <asp:ListItem Value=" zona norte">Gral. Pacheco</asp:ListItem>
                <asp:ListItem Value=" zona oeste">San Miguel </asp:ListItem>
                <asp:ListItem Value="zona sur">Boedo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Temas:<br />
            <asp:CheckBoxList ID="CBtemas" runat="server" Height="17px" style="margin-left: 70px; margin-top: 1px" Width="313px">
                <asp:ListItem>Ciencias</asp:ListItem>
                <asp:ListItem>Literatura</asp:ListItem>
                <asp:ListItem>Historia</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 118px" Text="Ver resumen" Width="170px" />
        </p>
    </form>
</body>
</html>
