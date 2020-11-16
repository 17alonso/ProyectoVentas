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
    /// Descripción breve de wsCategoria
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCategoria : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar datos de la tabla Categoria")]
        public DataTable Listar()
        {
            CategoriaBL categoria = new CategoriaBL();
            return categoria.Listar();
        }

        [WebMethod(Description = "Buscar una Categoria a la tabla Categoria")]
        public DataTable Buscar(string texto, string criterio)
        {

            CategoriaBL categoria = new CategoriaBL();
            return categoria.Buscar(texto, criterio);

        }

        [WebMethod(Description = "Agregar una Categoria a la tabla Producto")]
        public string[] Agregar(string codCategoria, string nombre, string catpadre)
        {
            Categoria categoria = new Categoria();
            categoria.CodCategoria = codCategoria;
            categoria.Nombre = nombre;
            categoria.CategoriaPadre= catpadre;
            CategoriaBL categoriaBL = new CategoriaBL();
            string[] respuesta = new string[2];
            bool CodError = categoriaBL.Agregar(categoria);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = categoriaBL.Mensaje;
            return respuesta;
        }
        [WebMethod(Description = "Actualizar una Categoria a la tabla Categoria")]
        public string[] Actualizar(string codCategoria, string nombre, string catpadre)
        {
            Categoria categoria = new Categoria();
            categoria.CodCategoria = codCategoria;
            categoria.Nombre = nombre;
            categoria.CategoriaPadre = catpadre;
            CategoriaBL categoriaBL = new CategoriaBL();
            string[] respuesta = new string[2];
            bool CodError = categoriaBL.Actualizar(categoria);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = categoriaBL.Mensaje;
            return respuesta;
        }

        [WebMethod(Description = "Eliminar una Categoria a la tabla Categoria")]
        public string[] Eliminar(string codCategoria)
        {

            CategoriaBL categoriaBL = new CategoriaBL();
            string[] respuesta = new string[2];
            bool CodError = categoriaBL.Eliminar(codCategoria);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = categoriaBL.Mensaje;
            return respuesta;
        }


    }
}
