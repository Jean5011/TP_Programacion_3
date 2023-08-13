<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ej2.aspx.cs" Inherits="tp4.ej2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-top: 0px;
        }
        .auto-style6 {
            width: 99px;
            height: 62px;
        }
        .auto-style7 {
            width: 196px;
            height: 62px;
        }
        .auto-style8 {
            width: 234px;
            height: 62px;
        }
        .auto-style9 {
            width: 531px;
            height: 62px;
        }
        .auto-style10 {
            width: 99px;
            height: 29px;
        }
        .auto-style11 {
            width: 196px;
            height: 29px;
        }
        .auto-style12 {
            width: 234px;
            height: 29px;
        }
        .auto-style13 {
            width: 531px;
            height: 29px;
        }
        .auto-style14 {
            width: 99px;
            height: 28px;
        }
        .auto-style15 {
            width: 196px;
            height: 28px;
        }
        .auto-style16 {
            width: 234px;
            height: 28px;
        }
        .auto-style17 {
            width: 531px;
            height: 28px;
        }
        .auto-style18 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style10">Id producto:</td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="DDL_Producto" runat="server" Width="192px">
                            <asp:ListItem Value="=">Igual a:</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TB_Producto" runat="server" ValidationGroup="Grupo1" Width="235px"></asp:TextBox>
                    </td>
                    <td class="auto-style13">
                        <asp:RequiredFieldValidator ID="V_Producto" runat="server" ControlToValidate="TB_Producto" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RE_Producto" runat="server" ControlToValidate="TB_Producto" ValidationExpression="^\d+$" ValidationGroup="Grupo1">Ingrese numeros</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">IdCategoria:</td>
                    <td class="auto-style15">
                        <asp:DropDownList ID="DDL_Categoria" runat="server" Width="192px">
                            <asp:ListItem Value="=">Igual a:</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style16">
                        <asp:TextBox ID="TB_Categoria" runat="server" ValidationGroup="Grupo1" Width="235px"></asp:TextBox>
                    </td>
                    <td class="auto-style17">
                        <asp:RequiredFieldValidator ID="V_Categoria" runat="server" ControlToValidate="TB_Categoria" ValidationGroup="Grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RE_Categoria" runat="server" ControlToValidate="TB_Categoria" ValidationExpression="^\d+$" ValidationGroup="Grupo1">Ingrese numeros</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="Flitrar" runat="server" Text="Flitrar" ValidationGroup="Grupo1" OnClick="Flitrar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Quitar_flitro" runat="server" Text="Quitar flitro" Width="89px" OnClick="Quitar_flitro_Click" />
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style18">
            <tr>
                <td>
                    <asp:GridView ID="GRD" runat="server"  Width="302px">
                        <Columns>
                            <asp:BoundField ReadOnly="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
