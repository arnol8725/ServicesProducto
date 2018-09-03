using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Elektra.Servicios.WSSistemasInfProducto.DAO
{
    [DataContract]
    public class DetalleProducto : Respuesta
    {
        [DataMember]
        public List<DetalleBusqueda> detBusquesa { get; set; }
    }
}