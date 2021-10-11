<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JSONNET.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre" />
            <asp:TextBox ID="txtNombre" runat="server" /><br />
            <asp:Label ID="lblEdad" runat="server" Text="Edad" />
            <asp:TextBox ID="txtEdad" runat="server" Text="Edad" /><br />
            <asp:Label ID="lblEmail" runat="server" Text="Email" />
            <asp:TextBox ID="txtEmail" runat="server" /><br />
            <asp:Button ID="btnAgregarPersona" runat="server" Text="Agregar Persona" OnClick="btnAgregarPersona_Click" />
            <br />
            <asp:ListBox ID="ltbPersona" runat="server"  ></asp:ListBox>
            <br />
            <asp:Button ID="btnJSON" runat="server" Text="Generar JSON" OnClick="btnJSON_Click" />
            
        </div>
    </form>
</body>
</html>
