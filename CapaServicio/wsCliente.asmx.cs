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
    /// Descripción breve de wsCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCliente : System.Web.Services.WebService
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


        [WebMethod(Description = "Listar datos de la tabla Cliente")]
        public DataTable Listar()
        {
            ClienteBL cliente = new ClienteBL();
            return cliente.Listar();
        }


        [WebMethod(Description = "Listar datos de la tabla Cliente")]
        public DataTable Buscar(string texto, string criterio)
        {
            ClienteBL cliente = new ClienteBL();
            return cliente.Buscar(texto, criterio);
        }
        [WebMethod(Description = "Agregar un vendedor a la tabla Cliente")]
        public string[] Agregar(string codCliente, string apellidos, string nombres,string direccion, string usuario, string contrasena)
        {
            Cliente cliente = new Cliente();
            cliente.CodCliente = codCliente;
            cliente.Apellidos = apellidos;
            cliente.Nombres = nombres;
            cliente.Direccion = direccion;
            cliente.Usuario = usuario;
            cliente.Contrasena = generarClaveSHA1(contrasena);
            ClienteBL clienteBL = new ClienteBL();
            string[] respuesta = new string[2];
            bool CodError = clienteBL.Agregar(cliente);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = clienteBL.Mensaje;
            return respuesta;
        }

        [WebMethod(Description = "Actualizar un vendedor a la tabla Cliente")]
        public string[] Actualizar(string codCliente, string apellidos, string nombres, string direccion, string usuario, string contrasena)
        {
            Cliente cliente = new Cliente();
            cliente.CodCliente = codCliente;
            cliente.Apellidos = apellidos;
            cliente.Nombres = nombres;
            cliente.Direccion = direccion;
            cliente.Usuario = usuario;
            cliente.Contrasena = generarClaveSHA1(contrasena);
            ClienteBL clienteBL = new ClienteBL();
            string[] respuesta = new string[2];
            bool CodError = clienteBL.Actualizar(cliente);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = clienteBL.Mensaje;
            return respuesta;
        }

        [WebMethod(Description = "Eliminar un Cliente a la tabla Producto")]
        public string[] Eliminar(string codcliente)
        {

            ClienteBL clienteBL = new ClienteBL();
            string[] respuesta = new string[2];
            bool CodError = clienteBL.Eliminar(codcliente);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = clienteBL.Mensaje;
            return respuesta;
        }
    }
}
