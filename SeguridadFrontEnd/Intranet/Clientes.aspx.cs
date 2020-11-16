using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeguridadFrontEnd.Intranet
{
    public partial class Clientes : System.Web.UI.Page
    {
        ServiceReferenceCliente.wsClienteSoapClient servicio = new ServiceReferenceCliente.wsClienteSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvCliente.DataSource = servicio.Listar();
                gvCliente.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codCliente = txtIdCodigoCliente.Text;
            string nombres = txtNombre.Text;
            string apellidos = txtApellidosV.Text;
            string direccion = txtDireccion.Text;
            string usuario = txtCorreo.Text;
            string contrasenia = txtContrasena.Text;

            string[] rsta = servicio.Agregar(codCliente, nombres, apellidos, direccion, usuario, contrasenia).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Cliente.aspx';</script>");

            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string codCliente = txtIdCodigoCliente.Text;
            string nombres = txtNombre.Text;
            string apellidos = txtApellidosV.Text;
            string direccion = txtDireccion.Text;
            string usuario = txtCorreo.Text;
            string contrasenia = txtContrasena.Text;

            string[] rsta = servicio.Actualizar(codCliente, nombres, apellidos, direccion, usuario, contrasenia).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Cliente.aspx';</script>");

            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string codcliente = txtIdCodigoCliente.Text;
            string[] rsta = servicio.Eliminar(codcliente).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Cliente.aspx';</script>");

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
                gvCliente.DataSource = servicio.Buscar(texto, "CodCliente");
                gvCliente.DataBind();
            }
            else if (criterio == 1)
            {
                gvCliente.DataSource = servicio.Buscar(texto, "Apellidos");
                gvCliente.DataBind();
            }
        }
    }
}