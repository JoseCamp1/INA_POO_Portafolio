<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frm_NuevoCliente.aspx.cs" Inherits="SitioWeb.Frm_NuevoCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mantenimiento de Cliente</title>

    <style>
        #form1{
            margin: 10px auto;
            width: 60%;
        }
    </style>

    <script type="text/javascript">
        function mostrarMensaje(mensaje) {
            alert(mensaje);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <h1>Mantenimiento de Cliente</h1>          
                <hr /><br />
                <br />

                <div>                    
                    &nbsp;<asp:Label ID="lblid" runat="server" Text="Id:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtId" runat="server" ReadOnly="True"></asp:TextBox>
                    <br />                    
                    Nombre:&nbsp; <asp:TextBox ID="txtNombre" runat="server" Width="300px"></asp:TextBox>
                    <br />                    
                    Telefono:&nbsp; <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    <br />                    
                    Direccion: <asp:TextBox ID="txtDireccion" runat="server" Width="300px"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                </div>

                <div>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </div>

            </div>
    </form>
</body>
</html>
