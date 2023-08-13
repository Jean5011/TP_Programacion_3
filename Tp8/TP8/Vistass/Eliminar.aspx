<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Vistass.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 293px;
        }
        .auto-style3 {
            width: 409px;
        }
        .auto-style4 {
            width: 195px;
        }
        .auto-style5 {
            width: 223px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
               <td id="Agreagar" class="auto-style2">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Agregar.aspx">Agregar sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="HyperLink2" runat="server"  NavigateUrl="~/Ver.aspx">Listado de sucursal</asp:HyperLink>
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Eliminar.aspx">Eliminar sucursal</asp:HyperLink>
                    </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    <table class="auto-style1">
        <tr>
            <td><h1>Eliminar sucursal</h1></td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td class="auto-style4">Ingrese ID de sucursal:</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox1" runat="server" Width="208px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Eliminar" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
