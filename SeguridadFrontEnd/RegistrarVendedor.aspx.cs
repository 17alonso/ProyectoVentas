﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SeguridadFrontEnd
{
    public partial class RegistrarVendedor : System.Web.UI.Page
    {
        ServiceReferenceVendedor.wsVendedorSoapClient servicio = new ServiceReferenceVendedor.wsVendedorSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.location = 'Login.aspx';</script>");

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            string codCliente = txtidRVendedor.Text;
            string nombres = txtIdRNombres.Text;
            string apellidos = txtIdRApellidos.Text;
            string email = txtIdREmail.Text;
            string contrasena1 = txtIdRContrasenia.Text;
            string contrasena2 = txtIdRContrasenia2.Text;
            if (contrasena1 == contrasena2)
            {

                string[] rsta = servicio.Agregar(codCliente, apellidos, nombres, email, contrasena1).ToArray();
                string codError = rsta[0];
                string mensaje = rsta[1];
                if (codError == "true")
                {
                    Response.Write("<script>alert('" + mensaje + "');</script>");
                    Response.Write("<script>window.location = 'Login.aspx';</script>");

                }
                else
                    Response.Write("<script>alert('" + mensaje + "');</script>");

            }
            else Response.Write("<script>alert('Las contraseñas no son iguales');</script>");



        }
    }
}