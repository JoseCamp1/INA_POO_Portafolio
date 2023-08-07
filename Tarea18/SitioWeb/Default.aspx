<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SitioWeb.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Menu Principal</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.min.js"></script>

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

    <header class="container">
        <h1 class="bg-secondary p-3 text-center">Menu Principal</h1>
    </header>

    <form id="form1" runat="server">

        <div class="container p-3 text-center">
            <asp:LinkButton ID="btnClientes" CssClass="btn btn-outline-secondary" runat="server" OnClick="btnClientes_Click" BorderStyle="None">Clientes</asp:LinkButton>
            <asp:LinkButton ID="btnProductos" CssClass="btn btn-outline-secondary" runat="server" OnClick="btnProductos_Click" BorderStyle="None">Productos</asp:LinkButton>
            <asp:LinkButton ID="btnFacturas" CssClass="btn btn-outline-secondary" runat="server" OnClick="btnFacturas_Click" BorderStyle="None">Facturas</asp:LinkButton>
        </div>

        

    </form>

</body>
</html>

