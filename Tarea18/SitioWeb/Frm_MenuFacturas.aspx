<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_MenuFacturas.aspx.cs" Inherits="SitioWeb.Frm_MenuFacturas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menu Facturas</title>

    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <header class="container">
        <h1 class="bg-secondary p-3 text-center">Menu Facturas</h1>
    </header>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" CssClass="btn btn-outline-secondary" />
        </div>
    </form>
</body>
</html>
