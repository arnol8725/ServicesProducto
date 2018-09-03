using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace Elektra.Servicios.WSSistemasInfProducto.DAO
{
    [DataContract]
    public class VentaGeneral
    {
        [DataMember]
        public int marcadas { get; set; }
        [DataMember]
        public int surtidas { get; set; }
        [DataMember]
        public int canceladasADE { get; set; }
        [DataMember]
        public int canceladasDDE { get; set; }
    }
}