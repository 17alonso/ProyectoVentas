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
    /// Descripción breve de wsVendedor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsVendedor : System.Web.Services.WebService
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

        [WebMethod(Description = "Listar datos de la tabla Vendedor")]
        public DataTable Listar()
        {
            VendedorBL vendedor = new VendedorBL();
            return vendedor.Listar();
        }

        [WebMethod(Description = "Buscar un Producto a la tabla Vendedor")]
        public DataTable Buscar(string texto, string criterio)
        {

            VendedorBL vendedor = new VendedorBL();
            return vendedor.Buscar(texto, criterio);

        }

        [WebMethod(Description = "Agregar un Producto a la tabla Vendedor")]
        public string[] Agregar(string codVendedor, string nombres, string apellidos, string usuario, string contrasenia)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.CodVendedor = codVendedor;
            vendedor.Nombres = nombres;
            vendedor.Apellidos = apellidos;
            vendedor.Usuario = usuario;
            vendedor.Contrasena = generarClaveSHA1(contrasenia);
            VendedorBL vendedorBL = new VendedorBL();
            string[] respuesta = new string[2];
            bool CodError = vendedorBL.Agregar(vendedor);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = vendedorBL.Mensaje;
            return respuesta;
        }
        [WebMethod(Description = "Actualizar un Producto a la tabla Vendedor")]
        public string[] Actualizar(string codVendedor, string nombres, string apellidos, string usuario, string contrasena)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.CodVendedor = codVendedor;
            vendedor.Nombres = nombres;
            vendedor.Usuario = usuario;
            vendedor.Apellidos = apellidos;
            vendedor.Contrasena = generarClaveSHA1(contrasena);
            VendedorBL vendedorBL = new VendedorBL();
            string[] respuesta = new string[2];
            bool CodError = vendedorBL.Actualizar(vendedor);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = vendedorBL.Mensaje;
            return respuesta;
        }

        [WebMethod(Description = "Eliminar un Producto a la tabla Producto")]
        public string[] Eliminar(string codVendedor)
        {

            VendedorBL vendedorBL = new VendedorBL();
            string[] respuesta = new string[2];
            bool CodError = vendedorBL.Eliminar(codVendedor);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = vendedorBL.Mensaje;
            return respuesta;
        }
    }
}
