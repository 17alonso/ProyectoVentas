using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class VendedorBL : Interface.IVendedor
    {
        private Datos datos = new DatosSQL();
        private string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
        }
        public bool Actualizar(Vendedor vendedor)
        {
            DataRow fila = datos.TraerDataRow("spActualizarVendedor", vendedor.CodVendedor, vendedor.Apellidos,
                            vendedor.Nombres, vendedor.Usuario, vendedor.Contrasena);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar(Vendedor vendedor)
        {
            DataRow fila = datos.TraerDataRow("spAgregarVendedor", vendedor.CodVendedor, vendedor.Apellidos,
                vendedor.Nombres, vendedor.Usuario, vendedor.Contrasena);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return true;
            else return false;
        }

        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarVendedor", texto, criterio);
        }

        public bool Eliminar(string CodVendedor)
        {
            DataRow fila = datos.TraerDataRow("spEliminarvendedor", CodVendedor);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataTable Listar()
        {
            return datos.TraerDataTable("spListarVendedor");
        }
    }
}
