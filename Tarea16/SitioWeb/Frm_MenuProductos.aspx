<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_MenuProductos.aspx.cs" Inherits="SitioWeb.Frm_MenuProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menu Productos</title>
</head>

    <style>

        h1{
            text-align:center
        }

        #gridview{
            margin: 10px auto;
            
        }        

    </style>

<body>

    <header>
        <h1>Menu Productos</h1>
    </header>
    
    <form id="form1" runat="server">

        <div class="campos">
            <asp:Label ID="Label1" runat="server" Text="ID Producto"></asp:Label>
            <asp:TextBox ID="txtID_Producto" runat="server" Width="60px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Precio Compra"></asp:Label>
            <asp:TextBox ID="txtPrecioCompra" runat="server" Width="60px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Precio Venta"></asp:Label>
            <asp:TextBox ID="txtPrecioVenta" runat="server" Width="60px"></asp:TextBox>
            <asp:Label ID="Label5" runat="server" Text="Gravado"></asp:Label>
            <asp:TextBox ID="txtGravado" runat="server" Width="60px"></asp:TextBox>
        </div>
        <div class="gridview">
            <asp:GridView ID="grdProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" EmptyDataText="No existen registros para mostrar" ForeColor="Black" GridLines="Horizontal" Width="80%">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="InkModificar" runat="server" CommandArgument='<%# Eval("ID_PRODUCTO").ToString() %>' CommandName="Modificar">Modificar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="InkEliminar" runat="server" CommandArgument='<%# Eval("ID_PRODUCTO").ToString() %>' CommandName="Eliminar">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ID_PRODUCTO" HeaderText="Producto" />
                    <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripcion" />
                    <asp:BoundField DataField="PRECIO_COMPRA" HeaderText="Precio Compra" />
                    <asp:BoundField DataField="PRECIO_VENTA" HeaderText="Precio Venta" />
                    <asp:BoundField DataField="GRAVADO" HeaderText="Gravado" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>

        <div class="botones">
            <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" />
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
            <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
            <asp:Button ID="btnSalir" runat="server" Text="Salir" />
            
        </div>        

    </form>
</body>
</html>
