using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class BoletaBL : Interface.IBoleta
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
        public bool Actualizar(Boleta boleta)
        {
            throw new NotImplementedException();
        }

        public bool AgregarBoleta(Boleta boleta)
        {
            DataRow fila = datos.TraerDataRow("spAgregarBoleta", boleta.NroBoleta, boleta.CodProducto,
                            boleta.Cantidad, boleta.CodCliente, boleta.CodVendedor);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return true;
            else return false;
        }

        public bool AgregarDeBoleta(string NroBoleta, string CodProducto, string cantidad)
        {
            DataRow fila = datos.TraerDataRow("spAgregarDetalleBoleta", NroBoleta, CodProducto, cantidad);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return true;
            else return false;
        }

        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarBoleta", texto, criterio);
        }

        public bool Eliminar(string CodBoleta)
        {
            throw new NotImplementedException();
        }

        public DataTable Listar()
        {
            return datos.TraerDataTable("spListarBoleta");
        }

        public DataTable MisVentas(string texto)
        {
            return datos.TraerDataTable("pMisVentas",texto);
        }
    }
}
