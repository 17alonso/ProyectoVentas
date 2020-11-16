using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Security.Cryptography;
using System.Text;

namespace SeguridadFrontEnd
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReferenceUsuario.wsUsuarioSoapClient servicio = new ServiceReferenceUsuario.wsUsuarioSoapClient();

        protected void btnEntrar_Click(object sender, EventArgs e)
        {

            string usuario = txtidUsuario.Text;
            string contrasena = txtIdContrasenia.Text;
            string[] rsta = servicio.Login(usuario, contrasena,"Vendedor").ToArray();
            string codError = rsta[0];
            string mensaje = rsta[1];
            if (codError == "true")
            {
                FormsAuthentication.RedirectFromLoginPage(mensaje, false);
            }
            else
                Response.Write("<script>alert('" + mensaje + "');</script>");
        }

        protected void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            btnCrearCliente.Visible=true;
            BtnCrearVendedor.Visible = true;
            lblIdentificar.Visible = true;
            lblO.Visible = true;
        }

        protected void btnCrearCliente_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'RegistrarCliente.aspx';</script>");

        }

        protected void BtnCrearVendedor_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'RegistrarVendedor.aspx';</script>");
        }

        protected void logCliente_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'LoginCliente.aspx';</script>");

        }

        protected void logVendedor_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'Login.aspx';</script>");

        }
    }
}