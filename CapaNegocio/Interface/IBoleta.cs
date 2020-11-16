using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IBoleta
    {
        DataTable Listar();
        DataTable MisVentas(string texto);
        bool AgregarBoleta(Boleta boleta);
        bool AgregarDeBoleta(string NroBoleta, string CodProducto, string cantidad);
        bool Eliminar(string CodBoleta);
        bool Actualizar(Boleta boleta);
        DataTable Buscar(string texto, string criterio);
    }
}
