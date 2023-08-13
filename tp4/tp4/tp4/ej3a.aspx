<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ej3a.aspx.cs" Inherits="tp4.ej3a" %>

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
            height: 90px;
        }
        .auto-style3 {
            width: 131px;
        }
        .auto-style4 {
            height: 90px;
            width: 131px;
        }
        .auto-style5 {
            width: 131px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Selecion tema: </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="113px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:LinkButton ID="Libro" runat="server" OnClick="Libro_Click">Ver libro</asp:LinkButton>
                    </td>
                    <td class="auto-style6">
                        <asp:Label ID="Label1" runat="server" Text="Error"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
