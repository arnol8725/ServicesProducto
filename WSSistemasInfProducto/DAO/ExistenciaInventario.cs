using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace Elektra.Servicios.WSSistemasInfProducto.DAO
{
    [DataContract]
    public class ExistenciaInventario
    {
        [DataMember]
        public int ubicacion { get; set; }
        [DataMember]
        public string descripcion { get; set; }
        [DataMember]
        public int existencia { get; set; }
    }

    [DataContract]
    public class ExistenciaInventarioxTipo
    {
        [DataMember]
        public int Contado_sin_surtir  { get; set; }
        [DataMember]
        public int Apartado_con_90_pagado { get; set; }
        [DataMember]
        public int Apartado_con_menos_de_90_pagado { get; set; }
        [DataMember]
        public int Crédito_con_90_de_enganche_pagado { get; set; }
    }
}