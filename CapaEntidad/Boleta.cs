using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CapaEntidad
{
    [DataContract]

    public class Boleta
    {
        [DataMember]
        public string NroBoleta
        { get; set; }

        [DataMember]
        public string CodProducto
        { get; set; }

        [DataMember]
        public string Cantidad
        { get; set; }

        [DataMember]
        public string CodCliente
        { get; set; }

        [DataMember]
        public string CodVendedor
        { get; set; }

    }
}
