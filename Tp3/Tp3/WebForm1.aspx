<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Tp3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 260px;
            height: 64px;
        }
        .auto-style3 {
            width: 270px;
            height: 64px;
        }
        .auto-style5 {
            width: 231px;
            height: 64px;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        .auto-style7 {
            height: 29px;
        }
        .auto-style8 {
            height: 28px;
        }
        .auto-style9 {
            width: 270px;
        }
        .auto-style10 {
            height: 29px;
            width: 270px;
        }
        .auto-style11 {
            height: 28px;
            width: 270px;
        }
        .auto-style15 {
            width: 260px;
            height: 80px;
        }
        .auto-style16 {
            width: 270px;
            height: 80px;
        }
        .auto-style18 {
            width: 260px;
            height: 14px;
        }
        .auto-style19 {
            width: 270px;
            height: 14px;
        }
        .auto-style20 {
            height: 24px;
        }
        .auto-style21 {
            height: 24px;
            width: 270px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th class="auto-style2"></th>
                    <th class="auto-style3">
                        <h1>Localidades</h1>
                    </th>
                    <th class="auto-style3"></th>
                </tr>
                <tr>
                    <th class="auto-style18">
                        <p>Nombre de localidad:</p>
                    </th>
                    <th class="auto-style19">
                        <asp:TextBox ID="textLocalidad" runat="server"  Width="249px" ValidationGroup="Grupo1"></asp:TextBox>
                    </th>
                    <th class="auto-style19">
                        <asp:RequiredFieldValidator ID="Nlocalidad" runat="server" ControlToValidate="textLocalidad" ErrorMessage="Ingrese Nombre de localidad" ValidationGroup="Grupo1">Ingrese localidad</asp:RequiredFieldValidator>
                        <br />
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="textLocalidad" OnServerValidate="CustomValidator1_ServerValidate" ValidationGroup="Grupo1">Localidad ya existente</asp:CustomValidator>
                        <br />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <th class="auto-style15">&nbsp;</th>
                    <th class="auto-style16">
                        <asp:Button ID="Button1" runat="server" Text="Guardar localidad" ValidationGroup="Grupo1" Width="148px" OnClick="Button1_Click" />
                   </th>
                    <th class="auto-style16">&nbsp;</th>
                </tr>
                <tr>
                    <th>
                        <p>Nombre de usuario:</p>
                    </th><th>
                        <asp:TextBox ID="TextBox2" runat="server"  Width="249px" ValidationGroup="Grupo2"></asp:TextBox>
                    </th><th class="auto-style9">
                        <asp:RequiredFieldValidator ID="Nusuario" runat="server" ControlToValidate="TextBox3" EnableTheming="True" ErrorMessage="Ingrese usuario" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
                    </th>
                </tr>
                <tr>
                    <th>
                        <p>Contraseña:</p>
                    </th><th>
                        <asp:TextBox ID="TextBox3" runat="server"  Width="249px" ValidationGroup="Grupo2"></asp:TextBox>
                    </th><th class="auto-style9">
                        <asp:RequiredFieldValidator ID="Contraseña" runat="server" ControlToValidate="TextBox4" ErrorMessage="Ingrese contraseña" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
                    </th>
                </tr>
                <tr>
                    <th class="auto-style7">
                        <p>Repetir Contraseña:</p>
                    </th><th class="auto-style7">
                        <asp:TextBox ID="TextBox4" runat="server" type="password" Width="249px" ValidationGroup="Grupo2"></asp:TextBox>
                    </th><th class="auto-style10">
                        &nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="RRContra" runat="server" ControlToValidate="TextBox4" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
                    &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="Ingrese la contraseña anterior mente escrita" ValidationGroup="Grupo2">*</asp:CompareValidator>
                    </th>
                </tr>
                <tr>
                    <th class="auto-style20">
                        <p>Correo electronico:</p>
                    </th><th class="auto-style20">
                        <asp:TextBox ID="TextBox5" runat="server" Width="249px" ValidationGroup="Grupo2"></asp:TextBox>
                    </th><th class="auto-style21">&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="Correo" runat="server" ControlToValidate="TextBox5" ErrorMessage="Ingrese correo electronico" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Ingrese su correo electronico" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Grupo2">*</asp:RegularExpressionValidator>
                    </th>
                </tr>
                <tr>
                    <th class="auto-style8">
                        <p>CP:</p>
                    </th><th class="auto-style8">
                        <asp:TextBox ID="TextBox6" runat="server" Width="249px" ValidationGroup="Grupo2"></asp:TextBox>
                    </th><th class="auto-style11">
                        &nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="cd" runat="server" ControlToValidate="TextBox6" ErrorMessage="Ingrese codigo postal" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
                    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox6" ErrorMessage="Ingrese su correo electronico" ValidationExpression="\d{4}(-\d{4})?" ValidationGroup="Grupo2">*</asp:RegularExpressionValidator>
                    </th>
                </tr>
                <tr>
                    <th>
                        <p>Localidad:</p>
                    </th><th>
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style6" Width="176px" ValidationGroup="Grupo2">
                        </asp:DropDownList>
                    </th><th class="auto-style9">
                        <asp:RequiredFieldValidator ID="La" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Eliga una localidad" ValidationGroup="Grupo2">*</asp:RequiredFieldValidator>
                    </th>
                </tr>
                <tr>
                    <th class="auto-style5"></th><th class="auto-style5">
                    <asp:Button ID="Button2" runat="server" Text="Guardar usuario" ValidationGroup="Grupo2" />
                    </th><th class="auto-style3">&nbsp;</th>
                </tr>
                <tr>
                    <th>
                        <p>
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Ir a inicio.aspx" />
                        </p>
                    </th><th></th><th class="auto-style9">&nbsp;</th>
                </tr>
            </table>
        </div>
    <p>
        &nbsp;</p>
    </form>
    </body>
</html>
