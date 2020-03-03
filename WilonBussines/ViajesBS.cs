using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wilon;
using WIlonBD.Class;

namespace WilonBussines
{
    public class ViajesBS
    {

        public Viajes crearObjeto( int cuil, DateTime fecha, char tipoComprobante, int PVComprobante, int numeroComprobante,
            string detalle, string unidad, decimal cantidad, decimal precioUnitario, decimal debeImporte, decimal haberImporte,
            int detalleAnio, int detalleNumero, int pagoCobroAnio, int pagoCobroNumero, int facturadoPV, int facturadoNumero,
            int tipoDest,int tipoTrans, SqlTransaction sqlTransaction = null)
        {
            var obDestinatario = new Viajes();

            obDestinatario.cuil=cuil;
            obDestinatario.fecha = fecha;
            obDestinatario.tipoComprobante = tipoComprobante;
            obDestinatario.PVComprobante = PVComprobante;
            obDestinatario.numeroComprobante = numeroComprobante;
            obDestinatario.detalle = detalle;
            obDestinatario.unidad = unidad;
            obDestinatario.cantidad = cantidad;
            obDestinatario.precioUnitario = precioUnitario;
            obDestinatario.debeImporte = debeImporte;
            obDestinatario.haberImporte = haberImporte;
            obDestinatario.detalleAnio = detalleAnio;
            obDestinatario.detalleNumero = detalleNumero;
            obDestinatario.pagoCobroAnio = pagoCobroAnio;
            obDestinatario.pagoCobroNumero = pagoCobroNumero;
            obDestinatario.facturadoPV = facturadoPV;
            obDestinatario.facturadoNumero = facturadoNumero;
            obDestinatario.tipoDest = tipoDest;
            obDestinatario.tipoTrans = tipoTrans;

            return obDestinatario;
        }

        public bool guardarLista(List<Viajes> listViajes) {

            ViajesBD viajesBD = new ViajesBD();
            return viajesBD.SaveList(listViajes);

        }



        //public void guardarTransportista(int cuil, DateTime fecha, char tipoComprobante, int PVComprobante, int numeroComprobante,
        //    string detalle, string unidad, decimal cantidad, decimal precioUnitario, decimal debeImporte, decimal haberImporte,
        //    int detalleAnio, int detalleNumero, int pagoCobroAnio, int pagoCobroNumero, int facturadoPV, int facturadoNumero,
        //    int tipoDest, int tipoTrans)
        //{
        //    var obTransportista = new Viajes();

        //    obTransportista.cuil = cuil;
        //    obTransportista.fecha = fecha;
        //    obTransportista.tipoComprobante = tipoComprobante;
        //    obTransportista.PVComprobante = PVComprobante;
        //    obTransportista.numeroComprobante = numeroComprobante;
        //    obTransportista.detalle = detalle;
        //    obTransportista.unidad = unidad;
        //    obTransportista.cantidad = cantidad;
        //    obTransportista.precioUnitario = precioUnitario;
        //    obTransportista.debeImporte = debeImporte;
        //    obTransportista.haberImporte = haberImporte;
        //    obTransportista.detalleAnio = detalleAnio;
        //    obTransportista.detalleNumero = detalleNumero;
        //    obTransportista.pagoCobroAnio = pagoCobroAnio;
        //    obTransportista.pagoCobroNumero = pagoCobroNumero;
        //    obTransportista.facturadoPV = facturadoPV;
        //    obTransportista.facturadoNumero = facturadoNumero;
        //    obTransportista.tipoDest = tipoDest;
        //    obTransportista.tipoTrans = tipoTrans;
        //}

        //public void guardarTransportista2(int cuil, DateTime fecha, char tipoComprobante, int PVComprobante, int numeroComprobante,
        //    string detalle, string unidad, decimal cantidad, decimal precioUnitario, decimal debeImporte, decimal haberImporte,
        //    int detalleAnio, int detalleNumero, int pagoCobroAnio, int pagoCobroNumero, int facturadoPV, int facturadoNumero,
        //    int tipoDest, int tipoTrans)
        //{
        //    var obTransporitista2 = new Viajes();

        //    obTransporitista2.cuil = cuil;
        //    obTransporitista2.fecha = fecha;
        //    obTransporitista2.tipoComprobante = tipoComprobante;
        //    obTransporitista2.PVComprobante = PVComprobante;
        //    obTransporitista2.numeroComprobante = numeroComprobante;
        //    obTransporitista2.detalle = detalle;
        //    obTransporitista2.unidad = unidad;
        //    obTransporitista2.cantidad = cantidad;
        //    obTransporitista2.precioUnitario = precioUnitario;
        //    obTransporitista2.debeImporte = debeImporte;
        //    obTransporitista2.haberImporte = haberImporte;
        //    obTransporitista2.detalleAnio = detalleAnio;
        //    obTransporitista2.detalleNumero = detalleNumero;
        //    obTransporitista2.pagoCobroAnio = pagoCobroAnio;
        //    obTransporitista2.pagoCobroNumero = pagoCobroNumero;
        //    obTransporitista2.facturadoPV = facturadoPV;
        //    obTransporitista2.facturadoNumero = facturadoNumero;
        //    obTransporitista2.tipoDest = tipoDest;
        //    obTransporitista2.tipoTrans = tipoTrans;
        //}

    }
}
