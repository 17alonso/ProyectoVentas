using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IVendedor
    {
        DataTable Listar();
        bool Agregar(Vendedor vendedor);
        bool Eliminar(string CodVendedor);
        bool Actualizar(Vendedor vendedor);
        DataTable Buscar(string texto, string criterio);



    }
}
