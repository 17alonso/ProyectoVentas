using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeguridadFrontEnd.Intranet
{
    public partial class Vendedor : System.Web.UI.Page
    {
        ServiceReferenceVendedor.wsVendedorSoapClient servicio = new ServiceReferenceVendedor.wsVendedorSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvVendedor.DataSource = servicio.Listar();
                gvVendedor.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codVendedor = txtIdCodigoVendedor.Text;
            string nombres = txtNombre.Text;
            string apellidos = txtApellidosV.Text;
            string usuario = txtCorreo.Text;
            string contrasenia = txtContraseña.Text;

            string[] rsta = servicio.Agregar(codVendedor, nombres, apellidos, usuario, contrasenia).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Vendedor.aspx';</script>");

            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string codven = txtIdCodigoVendedor.Text;
            string[] rsta = servicio.Eliminar(codven).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Vendedor.aspx';</script>");

            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string codVendedor = txtIdCodigoVendedor.Text;
            string nombres = txtNombre.Text;
            string apellidos = txtApellidosV.Text;
            string usuario = txtCorreo.Text;
            string contrasenia = txtContraseña.Text;

            string[] rsta = servicio.Actualizar(codVendedor, nombres, apellidos, usuario, contrasenia).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Vendedor.aspx';</script>");

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
                gvVendedor.DataSource = servicio.Buscar(texto, "CodVendedor");
                gvVendedor.DataBind();
            }
            else if (criterio == 1)
            {
                gvVendedor.DataSource = servicio.Buscar(texto, "Apellidos");
                gvVendedor.DataBind();
            }
        }
    }
}