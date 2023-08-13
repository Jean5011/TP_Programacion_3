<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ver.aspx.cs" Inherits="Tp5.WebForm1" %>

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
            width: 181px;
        }
        .auto-style3 {
            width: 180px;
        }
        .auto-style4 {
            width: 248px;
        }
        .auto-style5 {
            width: 248px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
            width: 210px;
        }
        .auto-style9 {
            width: 210px;
        }
        .auto-style10 {
            margin-left: 0px;
            margin-top: 0px;
        }
        .auto-style12 {
            width: 174px;
            height: 26px;
        }
        .auto-style13 {
            width: 174px;
        }
        .auto-style14 {
            margin-top: 0px;
        }
        .auto-style15 {
            width: 248px;
            height: 8px;
        }
        .auto-style16 {
            height: 8px;
            width: 210px;
        }
        .auto-style17 {
            width: 174px;
            height: 8px;
        }
        .auto-style18 {
            height: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
                </tr>
            </table>
        </div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style4"><h3>Listado de sucursales</h3> </td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style13">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Busqueda ingrese Id sucursal:</td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBox1" runat="server" Width="201px"></asp:TextBox>
            </td>
            <td class="auto-style12">
                <asp:Button ID="Por_Id" runat="server" Text="Filtrar" OnClick="Por_Id_Click" />
            </td>
            <td class="auto-style6">
                <asp:Button ID="Todo" runat="server" CssClass="auto-style10"  Text="Mostrar todo" OnClick="Todo_Click" />
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style15"></td>
            <td class="auto-style16">
                <br />
                <asp:Label ID="Label1" runat="server" Text="Error Id no exitente"></asp:Label>
            </td>
            <td class="auto-style17"></td>
            <td class="auto-style18"></td>
            <td class="auto-style18"></td>
        </tr>
        <tr>
            <td class="auto-style5">
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style12"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style8"></td>
            <td class="auto-style12"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
        </tr>
    </table>
                <asp:GridView ID="GridView1" runat="server" CssClass="auto-style14">
                </asp:GridView>
    </form>
    </body>
</html>
