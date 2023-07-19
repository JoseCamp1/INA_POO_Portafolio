<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SitioWeb.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Menu Principal</title>

    <style type="text/css">
        h1{
            text-align:center;
        }

        #form1 {
            height: 472px;
        }
    </style>

</head>

<body>

    <header>
        <h1>Menu Principal</h1>
    </header>

    <form id="form1" runat="server">

        <asp:LinkButton ID="btnClientes" runat="server" OnClick="btnClientes_Click" BackColor="#CCCCCC" BorderColor="White" BorderWidth="5px" ForeColor="Black">Clientes</asp:LinkButton>
        <asp:LinkButton ID="btnProductos" runat="server" OnClick="btnProductos_Click" BackColor="#CCCCCC" BorderColor="White" BorderWidth="5px" ForeColor="Black">Productos</asp:LinkButton>
        <asp:LinkButton ID="btnFacturas" runat="server" OnClick="btnFacturas_Click" BackColor="#CCCCCC" BorderColor="White" BorderWidth="5px" ForeColor="Black">Facturas</asp:LinkButton>

    </form>

</body>
</html>

