using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeguridadFrontEnd.ClientesPermitidos
{
    public partial class Perfil : System.Web.UI.Page
    {
        ServiceReferenceUsuario.wsUsuarioSoapClient servicio = new ServiceReferenceUsuario.wsUsuarioSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            string correo = Page.User.Identity.Name;
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = (Page.User.Identity.Name).ToString();
            string contrasena = txtIdContrasenia.Text;
            string nuevaContrasena = txtIdContraseniaNueva.Text;
            string nuevaContrasena2 = txtIdContraseniaNueva2.Text;
            if (nuevaContrasena == nuevaContrasena2)
            {
                string[] rsta = servicio.CambiarContra(usuario, contrasena, "cliente", nuevaContrasena).ToArray();
                string codError = rsta[0];
                string mensaje = rsta[1];
                if (codError == "true")
                {
                    Response.Write("<script>alert('" + mensaje + "');</script>");
                    Response.Write("<script>window.location = 'Inicio.aspx';</script>");
                }
                else
                    Response.Write("<script>alert('" + mensaje + "');</script>");
            }
            else
                Response.Write("<script>alert('Las constraseñas no coinciden');</script>");



        }
    }
}