<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Seleccionar.aspx.cs" Inherits="Tp6.Selecionar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                    <asp:GridView ID="grPrducto" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="grPrducto_PageIndexChanging" PageSize="14" AutoGenerateSelectButton="True" OnSelectedIndexChanging="grPrducto_SelectedIndexChanging">
                        <Columns>
                            <asp:TemplateField HeaderText="Id">
                                <ItemTemplate>
                                    <asp:Label ID="Lb_ID" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nombre">
                                <ItemTemplate>
                                    <asp:Label ID="LB_Nombre" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Unidades">
                                <ItemTemplate>
                                    <asp:Label ID="LB_Unidad" runat="server" Text='<%# Bind("CantidadPorUnidad") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Precio">
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Ej2.aspx">VolVer a inicio</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
