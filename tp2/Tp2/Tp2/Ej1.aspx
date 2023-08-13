<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ej1.aspx.cs" Inherits="Tp2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body id="TBcant1">
    <form id="form1" runat="server">
        <div>
            Ingrese nombre el producto:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; Cantidad:<asp:TextBox ID="Cant1" runat="server"></asp:TextBox>
            <br />
            <br />
            Ingrese nombre el producto:
            <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
&nbsp; Cantidad:<asp:TextBox ID="Cant2" runat="server" OnTextChanged="Cant2_TextChanged"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generar tabla" Width="178px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
