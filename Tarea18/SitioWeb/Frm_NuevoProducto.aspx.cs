using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Entidades;
using Capa_LogicaNegocio_02;
using System.Windows;

namespace SitioWeb
{
    public partial class Frm_NuevoProducto : System.Web.UI.Page
    {
        string MensajeScript;

        public void Limpiar()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtGravado.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Entidad_Productos producto;
            BL_Producto logica = new BL_Producto(Cls_Configuracion.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {
                    //EI ID es un dato que se genera en el otro formulario
                    //Se pueden enviar datos de un formulario a otro por QueryString o por SESION(existe muchas otras
                    //formas de enviar datos entre päginas Web)
                    //Lo enviaremos por sesiön, vamos a preguntar si lo que viene por sesiön trae algo

                    //Funcionamiento:
                    //EI formulario Default le enviarå por SESION un valor al formulario FrmClientes,
                    //esto permite que de un formulario enviemos valores hasta otro formulario.
                    //En este formulario(FrmClientes) estamos preguntando si en el valor de SESION existe algün valor
                    //llamado "id_del_cliente"
                    //Esto implica que desde el formulario Default(o cualquier otro formulario que invoque a FrmC1ientes)
                    //debemos crear una Variable de SESION y llamarla "id_del_cliente" asignåndole el ID que corresponda.
                    if (Session["id_del_producto"] != null)
                    {
                        identificacion = int.Parse(Session["id_del_producto"].ToString());
                        producto = logica.ObtenerProducto(identificacion);
                        if (producto.Existe)
                        {
                            txtId.Text = producto.Id_Producto.ToString();
                            txtDescripcion.Text = producto.Descripcion;
                            txtPrecioCompra.Text = producto.Precio_Compra.ToString();
                            txtPrecioVenta.Text = producto.Precio_Venta.ToString();
                            txtGravado.Text = producto.Gravado;

                            lblid.Visible = true;
                            txtId.Visible = true;
                        }
                        else
                        {
                            MensajeScript = string.Format("javascript:mostrarMensaje" + "('Cliente no encontrado')");
                            ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        }
                    }
                    else
                    {
                        Limpiar();
                        txtId.Text = "-1";
                        lblid.Visible = false;
                        txtId.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                Response.Redirect("Default.aspx");
            }
        }

        private Entidad_Productos GenerarEntidadProducto()
        {
            Entidad_Productos producto = new Entidad_Productos();
            // si hay algo en la variable de sesion
            if (Session["id_del_producto"] != null)
            {
                producto.Id_Producto = int.Parse(Session["id_del_producto"].ToString());
                producto.Existe = true;
            }
            //si no hay nada en la variable de sesion, es un producto nuevo
            else
            {
                producto.Id_Producto = -1;
                producto.Existe = false;
            }
            //los demas datos siempre se toman de los cuadros de texto
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio_Compra = Convert.ToSingle(txtPrecioCompra.Text);
            producto.Precio_Venta = Convert.ToSingle(txtPrecioVenta.Text);
            producto.Gravado = txtGravado.Text;
            return producto;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Productos producto;
            BL_Producto logica = new BL_Producto(Cls_Configuracion.getConnectionString);
            int resultado;
            try
            {
                producto = GenerarEntidadProducto();
                //si el producto ya existe , se modifica 
                if (producto.Existe)
                {
                    resultado = logica.Modificar(producto);
                }
                //si el producto no existe se crea
                else
                {
                    if (!string.IsNullOrEmpty(txtDescripcion.Text))
                    {
                        resultado = logica.InsertarProducto(producto);
                    }
                    else
                    {
                        MensajeScript = string.Format("javascript:mostrarMensaje" + "('Debe agregar almenos el nombre del producto')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('Operacion realizada satisfactoriamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                    Response.Redirect("Frm_MenuProductos.aspx");
                }
                else
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('No se pudo ejecutar la operacion')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                }
            }
            catch (Exception ex)
            {
                MensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuProductos.aspx");
        }
    }
}