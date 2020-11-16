using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface ICliente
    {
        DataTable Listar();
        bool Agregar(Cliente cliente);
        bool Eliminar(string CodCliente);
        bool Actualizar(Cliente vendedor);
        DataTable Buscar(string texto, string criterio);
    }
}
