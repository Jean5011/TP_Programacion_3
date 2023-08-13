<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ej2_2.aspx.cs" Inherits="Tp2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:<asp:Label ID="Nombre" runat="server" Text="Label"></asp:Label>
            <br />
            Apellido:<asp:Label ID="Apellido" runat="server" Text="Label"></asp:Label>
            <br />
            Zona:<asp:Label ID="TxtZona" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            Los temas eleguidos son:<asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
