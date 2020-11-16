using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;

using System.Web.UI.WebControls;

namespace SeguridadFrontEnd
{
    public partial class LoginCliente : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReferenceUsuario.wsUsuarioSoapClient servicio = new ServiceReferenceUsuario.wsUsuarioSoapClient();

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {

            string usuario = txtidUsuario.Text;
            string contrasena = txtIdContrasenia.Text;
            string[] rsta = servicio.Login(usuario, contrasena, "cliente").ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                Response.Write("<script>window.location = 'ClientesPermitidos/inicio.aspx';</script>");
            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");
        }

        protected void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            btnCrearCliente.Visible = true;
            BtnCrearVendedor.Visible = true;
            lblIdentificar.Visible = true;
            lblO.Visible = true;
        }

        protected void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'RegistrarCliente.aspx';</script>");

        }

        protected void BtnCrearVendedor_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'RegistrarVendedor.aspx';</script>");
        }

        protected void LogCliente_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'LoginCliente.aspx';</script>");

        }

        protected void LogVendedor_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'Login.aspx';</script>");

        }

    }
}