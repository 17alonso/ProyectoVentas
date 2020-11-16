using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace CapaNegocio.Interface
{
    interface IUsuario
    {
        bool Login(Usuario usuario, string tipo);
        bool CambiarContCliente(string correo, string contra, string tipo, string nuevaContra);

    }
}
