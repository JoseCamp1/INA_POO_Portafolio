<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_MenuProductos.aspx.cs" Inherits="SitioWeb.Frm_MenuProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menu Productos</title>

    <style>

        h1{
            text-align:center
        }

        #gridview{
            margin: 10px auto;
            width: 100%;
        }

        #form1{
            margin: 10px auto;
            width: 70%;
        }

    </style>

    <script type="text/javascript">

        function mostrarMensaje(mensaje) {
            alert(mensaje);
        }

    </script>

</head> 

<body>

    <header>
        <h1>Menu Productos</h1>
    </header>
    
    <form id="form1" runat="server">

        <div class="campos">
            
            <asp:Label ID="Label2" runat="server" Text="Nombre del Producto :"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar Nuevo"/>
            <br />            
            
        </div>
        <div class="gridview">
            <asp:GridView ID="grdProductos" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" EmptyDataText="No existen registros para mostrar" ForeColor="Black" GridLines="Horizontal" Width="80%" OnPageIndexChanging="grdProductos_PageIndexChanging" PageSize="8">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="InkModificar" runat="server" CommandArgument='<%# Eval("ID_PRODUCTO").ToString() %>' CommandName="Modificar">Modificar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="InkEliminar" runat="server" CommandArgument='<%# Eval("ID_PRODUCTO").ToString() %>' CommandName="Eliminar" OnCommand="InkEliminar_Command">Eliminar</asp:LinkButton>
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
        </div>        

    </form>
</body>
</html>
