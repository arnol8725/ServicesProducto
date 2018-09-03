using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Elekta.Negocio.SistnformacionEpos;

namespace Elektra.Servicios.WSSistemasInfProducto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSSistemasInfProducto
    {

        [OperationContract]
        [WebInvoke(Method = "OPTIONS", UriTemplate = "*")]
        void OpcionesPreflight();

        [OperationContract]
        string GetData(int value);


        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/BusquedaProductos?tipoBusqueda={tipoBusqueda}&descrip={descrip}")]
        //[WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GenerarPedido?folio={folio}&empleado={empleado}&estacionTrabajo={estacionTrabajo}&ipWS={ipWS}")]
        [OperationContract]
        DAO.DetalleProducto BusquedaProductos(int tipoBusqueda, string descrip);

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DetalleProductos?sku={sku}&empleado={empleado}")]
        //[WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GenerarPedido?folio={folio}&empleado={empleado}&estacionTrabajo={estacionTrabajo}&ipWS={ipWS}")]
        [OperationContract]
        DetalleProductoxSKU DetalleProductos(int sku, string empleado);

        // TODO: Add your service operations here
    }


    
}
