using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CapaWeb
{
    public partial class Vendedor : System.Web.UI.Page
    {
        private ServiceReferenceVendedor.wsVendedorSoapClient servicio = new ServiceReferenceVendedor.wsVendedorSoapClient();
        
        private void Listar()
        {
            gvVendedor.DataSource = servicio.Listar();
            gvVendedor.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) { Listar(); }
        }

        protected void gvVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string codVendedor = txtCodVendedor.Text.Trim();
            string apellidos = txtApellido.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contrasena= txtContrasena.Text.Trim();
            if (servicio.Agregar(codVendedor, apellidos, nombres, usuario, contrasena))
            {
                Listar();
            }
        }
    }
}