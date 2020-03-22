using System;
using System.Collections.Generic;
using System.Data;
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

        public Viajes crearObjeto( string cuil, DateTime fecha, char tipoComprobante, int PVComprobante, int numeroComprobante,
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

        public bool guardarLista(List<Viajes> listViajes) 
        {

            ViajesBD viajesBD = new ViajesBD();
            return viajesBD.SaveList(listViajes);

        }

        public DataTable SeleccionarPorDocumento(string documento)       //trae el parametro de CuentasCorrientesForm/Buscar_Click
        {
            var wLstCondicion = new DataTable();
            var wBD = new ViajesBD();
            wLstCondicion = wBD.SelectByDocument(documento);   //lleva el parametro a la base de datos
            return wLstCondicion;
        }
    }
}
