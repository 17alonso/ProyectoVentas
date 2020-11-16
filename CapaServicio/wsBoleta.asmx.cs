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
    /// Descripción breve de wsBoleta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsBoleta : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar datos de la tabla Boleta")]
        public DataTable Listar()
        {
            BoletaBL boletaBl = new BoletaBL();
            return boletaBl.Listar();
        }

        [WebMethod(Description = "MisVentas de la tabla Boleta")]
        public DataTable MisVentas(string usuario)
        {
            BoletaBL boletaBl = new BoletaBL();
            return boletaBl.MisVentas(usuario);
        }

        [WebMethod(Description = "Agregar Boleta de la tabla Boleta")]
        public string[] AgregarBoleta(string nroBoleta, string codProducto, string cantidad, string codCliente, string CodVendedor)
        {
            Boleta boleta = new Boleta();
            boleta.NroBoleta = nroBoleta;
            boleta.CodProducto = codProducto;
            boleta.Cantidad = cantidad;
            boleta.CodCliente = codCliente;
            boleta.CodVendedor= CodVendedor;
            BoletaBL boletaBL = new BoletaBL();
            string[] respuesta = new string[2];
            bool CodError = boletaBL.AgregarBoleta(boleta);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = boletaBL.Mensaje;
            return respuesta;
        }

        [WebMethod(Description = "Agregar Detalles Boleta de la tabla Boleta")]
        public string[] AgregarDetallesBoleta(string nroBoleta, string codProducto, string cantidad)
        {
            BoletaBL boletaBL = new BoletaBL();
            string[] respuesta = new string[2];
            bool CodError = boletaBL.AgregarDeBoleta(nroBoleta,codProducto,cantidad);
            if (CodError == true) respuesta[0] = "true";
            else respuesta[0] = "false";
            respuesta[1] = boletaBL.Mensaje;
            return respuesta;
        }

        [WebMethod(Description = "Agregar Boleta de la tabla Boleta")]
        public DataTable Buscar(string texto, string criterio)
        {
            BoletaBL boletaBl = new BoletaBL();
            return boletaBl.Buscar(texto,criterio);
        }
    }
}
