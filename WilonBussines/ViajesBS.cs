using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wilon;
using WIlonBD.Class;

namespace WilonBussines
{
    public class ViajesBS
    {

        public void guardarDestinatario( int cuil, DateTime fecha, char tipoComprobante, int PVComprobante, int numeroComprobante,
            string detalle, string unidad, decimal cantidad, decimal precioUnitario, decimal debeImporte, decimal haberImporte,
            int detalleAnio, int detalleNumero, int pagoCobroAnio, int pagoCobroNumero, int facturadoPV, int facturadoNumero,
            int tipoDest,int tipoTrans)
        {
            var obViajes = new Viajes();

            obViajes.cuil=cuil;
            obViajes.fecha = fecha;
            obViajes.tipoComprobante = tipoComprobante;
            obViajes.PVComprobante = PVComprobante;
            obViajes.numeroComprobante = numeroComprobante;
            obViajes.detalle = detalle;
            obViajes.unidad = unidad;
            obViajes.cantidad = cantidad;
            obViajes.precioUnitario = precioUnitario;
            obViajes.debeImporte = debeImporte;
            obViajes.haberImporte = haberImporte;
            obViajes.detalleAnio = detalleAnio;
            obViajes.detalleNumero = detalleNumero;
            obViajes.pagoCobroAnio = pagoCobroAnio;
            obViajes.pagoCobroNumero = pagoCobroNumero;
            obViajes.facturadoPV = facturadoPV;
            obViajes.facturadoNumero = facturadoNumero;
            obViajes.tipoDest = tipoDest;
            obViajes.tipoTrans = tipoTrans;
        }

        public void guardarTransportista(int cuil, DateTime fecha, char tipoComprobante, int PVComprobante, int numeroComprobante,
            string detalle, string unidad, decimal cantidad, decimal precioUnitario, decimal debeImporte, decimal haberImporte,
            int detalleAnio, int detalleNumero, int pagoCobroAnio, int pagoCobroNumero, int facturadoPV, int facturadoNumero,
            int tipoDest, int tipoTrans)
        {
            var obViajes = new Viajes();

            obViajes.cuil = cuil;
            obViajes.fecha = fecha;
            obViajes.tipoComprobante = tipoComprobante;
            obViajes.PVComprobante = PVComprobante;
            obViajes.numeroComprobante = numeroComprobante;
            obViajes.detalle = detalle;
            obViajes.unidad = unidad;
            obViajes.cantidad = cantidad;
            obViajes.precioUnitario = precioUnitario;
            obViajes.debeImporte = debeImporte;
            obViajes.haberImporte = haberImporte;
            obViajes.detalleAnio = detalleAnio;
            obViajes.detalleNumero = detalleNumero;
            obViajes.pagoCobroAnio = pagoCobroAnio;
            obViajes.pagoCobroNumero = pagoCobroNumero;
            obViajes.facturadoPV = facturadoPV;
            obViajes.facturadoNumero = facturadoNumero;
            obViajes.tipoDest = tipoDest;
            obViajes.tipoTrans = tipoTrans;
        }

        public void guardarTransportista2(int cuil, DateTime fecha, char tipoComprobante, int PVComprobante, int numeroComprobante,
            string detalle, string unidad, decimal cantidad, decimal precioUnitario, decimal debeImporte, decimal haberImporte,
            int detalleAnio, int detalleNumero, int pagoCobroAnio, int pagoCobroNumero, int facturadoPV, int facturadoNumero,
            int tipoDest, int tipoTrans)
        {
            var obViajes = new Viajes();

            obViajes.cuil = cuil;
            obViajes.fecha = fecha;
            obViajes.tipoComprobante = tipoComprobante;
            obViajes.PVComprobante = PVComprobante;
            obViajes.numeroComprobante = numeroComprobante;
            obViajes.detalle = detalle;
            obViajes.unidad = unidad;
            obViajes.cantidad = cantidad;
            obViajes.precioUnitario = precioUnitario;
            obViajes.debeImporte = debeImporte;
            obViajes.haberImporte = haberImporte;
            obViajes.detalleAnio = detalleAnio;
            obViajes.detalleNumero = detalleNumero;
            obViajes.pagoCobroAnio = pagoCobroAnio;
            obViajes.pagoCobroNumero = pagoCobroNumero;
            obViajes.facturadoPV = facturadoPV;
            obViajes.facturadoNumero = facturadoNumero;
            obViajes.tipoDest = tipoDest;
            obViajes.tipoTrans = tipoTrans;
        }

    }
}
