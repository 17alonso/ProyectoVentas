using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeguridadFrontEnd.Intranet
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'Perfil.aspx';</script>");

        }

        protected void btnCliente_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'Clientes.aspx';</script>");

        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'Inicio.aspx';</script>");

        }

        protected void btnProducto_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'Productos.aspx';</script>");

        }

        protected void btnCategoria_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'Categoria.aspx';</script>");

        }

        protected void btnVendedor_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'Vendedor.aspx';</script>");
        }

        protected void btnBoletas_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'Boletas.aspx';</script>");

        }

        protected void btnMisVentas_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'MisVentas.aspx';</script>");

        }
    }
}