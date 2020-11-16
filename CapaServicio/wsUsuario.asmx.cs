using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using CapaNegocio;
using CapaEntidad;
using System.Security.Cryptography;
using System.Text;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de wsUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]


    public class wsUsuario : System.Web.Services.WebService
    {
        private string generarClaveSHA1(string cadena)
        {

            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                // Convertimos los valores en hexadecimal
                // cuando tiene una cifra hay que rellenarlo con cero
                // para que siempre ocupen dos dígitos.
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            //Devolvemos la cadena con el hash en mayúsculas para que quede más chuli :)
            return sb.ToString().ToUpper();
        }
        [WebMethod(Description = "Loguear Usuario")]
        public string[] Login(string Usuario, string Contrasena, string tipo)
        {
            Usuario usuario = new Usuario();
            usuario._Usuario = Usuario;
            usuario._Contrasena = generarClaveSHA1(Contrasena);
            UsuarioBL usuarioBL= new UsuarioBL();
            string[] respuesta = new string[2];
            bool CodError = usuarioBL.Login(usuario, tipo);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = usuarioBL.Mensaje;
            return respuesta;
        }

        [WebMethod(Description = "Cambiar Contraseña de Usuario")]
        public string[] CambiarContra(string Usuario, string Contrasena, string tipo, string nuevaContra)
        {
            string _usuario = Usuario;
            string _contrasena = generarClaveSHA1(Contrasena);
            string _nuevaContra = generarClaveSHA1(nuevaContra);
            string _tipo = tipo;
            UsuarioBL usuarioBL = new UsuarioBL();
            string[] respuesta = new string[2];
            bool CodError = usuarioBL.CambiarContCliente(_usuario, _contrasena, _tipo, _nuevaContra);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = usuarioBL.Mensaje;
            return respuesta;
        }
    }
}
