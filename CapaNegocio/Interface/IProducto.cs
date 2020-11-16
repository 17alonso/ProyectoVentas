using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IProducto
    {
        DataTable Listar();
        bool Agregar(Producto producto);
        bool Eliminar(string CodProducto);
        bool Actualizar(Producto producto);
        DataTable Buscar(string texto, string criterio);
    }
}
