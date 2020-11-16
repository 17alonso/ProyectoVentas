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
    public class ClienteBL : Interface.ICliente
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
        public bool Actualizar(Cliente cliente)
        {
            DataRow fila = datos.TraerDataRow("spActualizarCliente", cliente.CodCliente, cliente.Nombres,
                            cliente.Apellidos, cliente.Direccion, cliente.Usuario, cliente.Contrasena);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar(Cliente cliente)
        {
            DataRow fila = datos.TraerDataRow("spAgregarCliente", cliente.CodCliente, cliente.Apellidos,
                            cliente.Nombres, cliente.Direccion, cliente.Usuario, cliente.Contrasena);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return true;
            else return false;
        }

        public DataTable Buscar(string texto, string criterio)
        {
            return datos.TraerDataTable("spBuscarCliente", texto, criterio);
        }

        public bool Eliminar(string CodCliente)
        {
            DataRow fila = datos.TraerDataRow("spEliminarCliente", CodCliente);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataTable Listar()
        {
            return datos.TraerDataTable("spListarCliente");
        }
    }
}
