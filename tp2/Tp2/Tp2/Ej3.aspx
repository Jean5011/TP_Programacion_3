<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ej3.aspx.cs" Inherits="Tp2.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:LinkButton ID="LKrojo" runat="server" OnClick="LKrojo_Click">Rojo</asp:LinkButton>
        </p>
        <p>
            <asp:LinkButton ID="Lkazul" runat="server" OnClick="Lkazul_Click">Azul</asp:LinkButton>
        </p>
        <p>
            <asp:LinkButton ID="LKverde" runat="server" OnClick="LKverde_Click">Verde</asp:LinkButton>
        </p>
        <p>
            <asp:Label ID="Label" runat="server" Text="Texto coloreado"></asp:Label>
        </p>
    </form>
</body>
</html>
