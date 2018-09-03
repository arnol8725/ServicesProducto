using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Elekta.Negocio.SistnformacionEpos;
using Elektra.Services.Loader;
namespace Elektra.Servicios.WSSistemasInfProducto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class WSSistemasInfProducto : IWSSistemasInfProducto
    {

        public WSSistemasInfProducto()
        {
            AssemblyResolve.InitResolveEvent();
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public void OpcionesPreflight()
        {
            //  WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Origin", "*");
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Methods", "POST,OPTIONS");
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Headers", "Content-Type,Accept");
        }



        public DAO.DetalleProducto BusquedaProductos(int tipoBusqueda,string descrip)
        {
            DAO.DetalleProducto respuesta = new DAO.DetalleProducto();
            respuesta.detBusquesa = new List<DAO.DetalleBusqueda>();
            ManejadorSistemasInformacion manager = new ManejadorSistemasInformacion();
            
            try
            {
                var resp = manager.consultaProducto(tipoBusqueda, descrip);
                foreach (var det in resp.detBusquesa) {
                    DAO.DetalleBusqueda bus = new DAO.DetalleBusqueda();
                    bus.codigo = det.codigo;
                    bus.descripcion = det.descripcion;
                    bus.marca = det.marca;
                    bus.precio = det.precio;
                    respuesta.detBusquesa.Add(bus);
                }
                

            }
            catch (Exception e)
            {
                respuesta.mensaje= "Error al consulta informacion de pedido";
                respuesta.mensajeTecnico = "Error al consulta informacion de pedido: "+ e.Message;
            }
            return respuesta;
        }

        public DetalleProductoxSKU DetalleProductos(int sku, string empleado)
        {
            DetalleProductoxSKU respuesta = new DetalleProductoxSKU();
            //respuesta.detBusquesa = new List<DAO.DetalleBusqueda>();
            ManejadorSistemasInformacion manager = new ManejadorSistemasInformacion();

            try
            {
                respuesta = manager.detalleProducto(sku, empleado);              
                

            }
            catch (Exception e)
            {
                respuesta.mensaje = "Error al consulta informacion de pedido";
                respuesta.mensajeTecnico = "Error al consulta informacion de pedido: " + e.Message;
            }
            return respuesta;
        }

    }
}

