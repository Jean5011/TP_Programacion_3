<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ej4-1.aspx.cs" Inherits="Tp2.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuario:<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 6px"></asp:TextBox>
            <br />
            Clave:<asp:TextBox ID="TextBox1"  type="password" runat="server" style="margin-left: 19px"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Height="36px" OnClick="Button1_Click" style="margin-left: 82px; margin-bottom: 49px" Text="Verificar" Width="116px" />
    </form>
</body>
</html>
