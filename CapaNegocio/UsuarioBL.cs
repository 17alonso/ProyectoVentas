using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidad;

namespace CapaNegocio
{
    public class UsuarioBL : Interface.IUsuario
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

        public bool CambiarContCliente(string correo, string contra, string tipo, string nuevaContra)
        {
            if (tipo == "cliente")
            {
                DataRow fila = datos.TraerDataRow("spCambiarContraseniaCliente", correo, contra, nuevaContra);
                mensaje = fila["Mensaje"].ToString();
                byte codError = Convert.ToByte(fila["CodError"]);
                if (codError == 0) return true;
                else return false;
            }
            else
            {
                DataRow fila = datos.TraerDataRow("spCambiarContraseniaVendedor", correo, contra, nuevaContra);
                mensaje = fila["Mensaje"].ToString();
                byte codError = Convert.ToByte(fila["CodError"]);
                if (codError == 0) return true;
                else return false;
            }
        }

        public bool Login(Usuario usuario, string tipo)
        {
            if (tipo=="cliente")
            {
                DataRow fila = datos.TraerDataRow("spLoginCliente", usuario._Usuario, usuario._Contrasena);
                mensaje = fila["Mensaje"].ToString();
                byte codError = Convert.ToByte(fila["CodError"]);
                if (codError == 0) return true;
                else return false;
            }
            else
            {
                DataRow fila = datos.TraerDataRow("spLoginVendedor", usuario._Usuario, usuario._Contrasena);
                mensaje = fila["Mensaje"].ToString();
                byte codError = Convert.ToByte(fila["CodError"]);
                if (codError == 0) return true;
                else return false;
            }
            
        }
    }
}
