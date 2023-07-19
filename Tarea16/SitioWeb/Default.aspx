<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SitioWeb.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menu Principal</title>

    <style type="text/css">
        #form1 
        {
            height: 472px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:LinkButton ID="btnClientes" runat="server" BackColor="#CCCCCC" BorderColor="White" BorderWidth="5px" ForeColor="Black">Clientes</asp:LinkButton>
        <asp:LinkButton ID="btnProductos" runat="server" BackColor="#CCCCCC" BorderColor="White" BorderWidth="5px" ForeColor="Black">Productos</asp:LinkButton>
        <asp:LinkButton ID="btnFacturas" runat="server" BackColor="#CCCCCC" BorderColor="White" BorderWidth="5px" ForeColor="Black">Facturas</asp:LinkButton>
    </form>
</body>
</html>
