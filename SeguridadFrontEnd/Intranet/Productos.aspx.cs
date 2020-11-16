using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeguridadFrontEnd.Intranet
{
    public partial class Productos : System.Web.UI.Page
    {
        ServiceReferenceProducto.wsProductoSoapClient servicio = new ServiceReferenceProducto.wsProductoSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvProducto.DataSource = servicio.Listar();
                gvProducto.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codProducto = txtIdCodigoProducto.Text;
            string nombre = txtNombre.Text;
            string unidadMedida = txtUnidadMedida.Text;
            string precio = txtPrecio.Text;
            string stock = txtStock.Text;
            string codCategoria = txtCodCat.Text;

                string[] rsta = servicio.Agregar(codProducto, nombre, unidadMedida, precio, stock, codCategoria).ToArray();
                string codError = rsta[0];
                string mensaje = rsta[1];
                if (codError == "true")
                {
                    Response.Write("<script>alert('" + mensaje + "');</script>");
                    Response.Write("<script>window.location = 'Productos.aspx';</script>");

                }
                else
                    Response.Write("<script>alert('" + mensaje + "');</script>");

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string codProd = txtIdCodigoProducto.Text;
            string[] rsta = servicio.Eliminar(codProd).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Productos.aspx';</script>");

            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string codProducto = txtIdCodigoProducto.Text;
            string nombre = txtNombre.Text;
            string unidadMedida = txtUnidadMedida.Text;
            string precio = txtPrecio.Text;
            string stock = txtStock.Text;
            string codCategoria = txtCodCat.Text;

            string[] rsta = servicio.Actualizar(codProducto, nombre, unidadMedida, precio, stock, codCategoria).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Productos.aspx';</script>");

            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            int criterio = ddlCriterio.SelectedIndex;
            if (criterio == 0)
            {
                gvProducto.DataSource = servicio.Buscar(texto, "CodProducto");
                gvProducto.DataBind();
            }
            else if (criterio == 1)
            {
                gvProducto.DataSource = servicio.Buscar(texto, "Nombre");
                gvProducto.DataBind();
            }
        }
    }
}