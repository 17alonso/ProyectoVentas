using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CapaEntidad
{
    [DataContract]
    public class Producto
    {
        [DataMember]
        public string CodProducto
        { get; set; }

        [DataMember]
        public string Nombre
        { get; set; }

        [DataMember]
        public string UnidadMedida
        { get; set; }

        [DataMember]
        public string Precio
        { get; set; }

        [DataMember]
        public string Stock
        { get; set; }

        [DataMember]
        public string CodCategoria
        { get; set; }
    }
}
