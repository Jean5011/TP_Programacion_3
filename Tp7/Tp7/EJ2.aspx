<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EJ2.aspx.cs" Inherits="Tp7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Ej1.aspx">Selección de sucursales</asp:HyperLink>
                </td>
                <td class="auto-style6">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="EJ2.aspx">Listado de sucursales seleccionadas</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
