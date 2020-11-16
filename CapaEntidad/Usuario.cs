using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public string _Usuario
        { get; set; }

        [DataMember]
        public string _Contrasena
        { get; set; }

        [DataMember]
        public string _Tipo
        { get; set; }
    }

}
