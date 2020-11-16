using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeguridadFrontEnd.Intranet
{
    public partial class Boletas : System.Web.UI.Page
    {
        ServiceReferenceBoleta.wsBoletaSoapClient servicio = new ServiceReferenceBoleta.wsBoletaSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                gvBoleta.DataSource = servicio.Listar();
                gvBoleta.DataBind();
            }
        }

        protected void btnAgregarBoleta_Click(object sender, EventArgs e)
        {
            string nroBoleta = txtIdNroBoleta.Text;
            string codProducto = txtCodProducto.Text;
            string cantidad = txtCantidad.Text;
            string codCliente= txtCodCliente.Text;
            string codVendedor= txtCodVendedor.Text;

            string[] rsta = servicio.AgregarBoleta(nroBoleta, codProducto, cantidad, codCliente, codVendedor).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Boletas.aspx';</script>");

            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");

        }

        protected void btnEliminarDetBoleta_Click(object sender, EventArgs e)
        {
            string nroBoleta = txtIdNroBoleta.Text;
            string codProducto = txtCodProducto.Text;
            string cantidad = txtCantidad.Text;

            string[] rsta = servicio.AgregarDetallesBoleta(nroBoleta, codProducto, cantidad).ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>alert('" + mensaje + "');</script>");
                Response.Write("<script>window.location = 'Boletas.aspx';</script>");

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
                gvBoleta.DataSource = servicio.Buscar(texto, "nroBoleta");
                gvBoleta.DataBind();
            }
            else if (criterio == 1)
            {
                gvBoleta.DataSource = servicio.Buscar(texto, "cliente");
                gvBoleta.DataBind();
            }
        }
    }
}