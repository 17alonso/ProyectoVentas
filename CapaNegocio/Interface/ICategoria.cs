using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface ICategoria
    {
        DataTable Listar();
        bool Agregar(Categoria categoria);
        bool Eliminar(string codCategoria);
        bool Actualizar(Categoria categoria);
        DataTable Buscar(string texto, string criterio);
    }
}
