using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using CapaNegocio;
using CapaEntidad;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de wsProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsProducto : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar datos de la tabla Producto")]
        public DataTable Listar()
        {
            ProductoBL producto= new ProductoBL();
            return producto.Listar();
        }

        [WebMethod(Description = "Buscar un Producto a la tabla Producto")]
        public DataTable Buscar(string texto, string criterio)
        {

            ProductoBL producto = new ProductoBL();
            return producto.Buscar(texto, criterio);

        }

        [WebMethod(Description = "Agregar un Producto a la tabla Producto")]
        public string[] Agregar(string codProducto, string nombre, string unidadMedida, string precio, string stock, string codCategoria)
        {
            Producto producto= new Producto();
            producto.CodProducto = codProducto;
            producto.Nombre = nombre;
            producto.UnidadMedida = unidadMedida;
            producto.Precio = precio;
            producto.Stock = stock;
            producto.CodCategoria= codCategoria;
            ProductoBL productoBL = new ProductoBL();
            string[] respuesta = new string[2];
            bool CodError = productoBL.Agregar(producto);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = productoBL.Mensaje;
            return respuesta;
        }
        [WebMethod(Description = "Actualizar un Producto a la tabla Producto")]
        public string[] Actualizar(string codProducto, string nombre, string unidadMedida, string precio, string stock, string codCategoria)
        {
            Producto producto = new Producto();
            producto.CodProducto = codProducto;
            producto.Nombre = nombre;
            producto.UnidadMedida = unidadMedida;
            producto.Precio = precio;
            producto.Stock = stock;
            producto.CodCategoria = codCategoria;
            ProductoBL productoBL = new ProductoBL();
            string[] respuesta = new string[2];
            bool CodError = productoBL.Actualizar(producto);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = productoBL.Mensaje;
            return respuesta;
        }

        [WebMethod(Description = "Eliminar un Producto a la tabla Producto")]
        public string[] Eliminar(string codProducto)
        {

            ProductoBL productoBL = new ProductoBL();
            string[] respuesta = new string[2];
            bool CodError = productoBL.Eliminar(codProducto);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = productoBL.Mensaje;
            return respuesta;
        }



    }
}
