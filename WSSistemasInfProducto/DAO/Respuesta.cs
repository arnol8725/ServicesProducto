using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace Elektra.Servicios.WSSistemasInfProducto.DAO
{
    [DataContract]
    public class Respuesta
    {
        [DataMember]
        public bool error { get; set; }

        [DataMember]
        public string mensaje { get; set; }

        [DataMember]
        public string mensajeTecnico { get; set; }
    }
}