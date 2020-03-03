using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wilon;

namespace WIlonBD.Class
{
    public class ViajesBD : Commons.BaseDAO
    {

        public bool SaveList(List<Viajes> listViajes)
        {
            StringBuilder wQuery = new StringBuilder();
            SqlCommand wCmd = new SqlCommand();

            SqlTransaction sqlT = base.TransactionBegin();

            try
            {


                foreach (var objeto in listViajes)
                {
                    wQuery = new StringBuilder();
                    wCmd = new SqlCommand();

                    wQuery = new StringBuilder("INSERT INTO [Viajes] (");
                    wQuery.Append("			[Documento] ");
                    wQuery.Append("			,[Fecha] ");
                    wQuery.Append("			,[ComprobanteTipo] ");
                    wQuery.Append("			,[ComprobantePV] ");
                    wQuery.Append("			,[ComprobanteNumero] ");
                    wQuery.Append("			,[Detalle] ");
                    wQuery.Append("			,[Unidad] ");
                    wQuery.Append("			,[Cantidad] ");
                    wQuery.Append("			,[PrecioUnitario] ");
                    wQuery.Append("			,[ImporteDebe] ");
                    wQuery.Append("			,[ImporteHaber] ");
                    wQuery.Append("			,[DetalleAnio] ");
                    wQuery.Append("			,[DetalleNumero] ");
                    wQuery.Append("			,[PagoCobroAnio] ");
                    wQuery.Append("			,[PagoCobroNumero] ");
                    wQuery.Append("			,[FacturadoPV] ");
                    wQuery.Append("			,[FacturadoNumero] ");
                    wQuery.Append("			,[IdTipoDestinatario] ");
                    wQuery.Append("			,[IdTipoTransportista] ");
                    wQuery.Append(") VALUES (");
                    wQuery.Append("			@Documento ");
                    wQuery.Append("			,@Fecha ");
                    wQuery.Append("			,@ComprobanteTipo ");
                    wQuery.Append("			,@ComprobantePV ");
                    wQuery.Append("			,@ComprobanteNumero ");
                    wQuery.Append("			,@Detalle ");
                    wQuery.Append("			,@Unidad ");
                    wQuery.Append("			,@Cantidad ");
                    wQuery.Append("			,@PrecioUnitario ");
                    wQuery.Append("			,@ImporteDebe ");
                    wQuery.Append("			,@ImporteHaber ");
                    wQuery.Append("			,@DetalleAnio ");
                    wQuery.Append("			,@DetalleNumero ");
                    wQuery.Append("			,@PagoCobroAnio ");
                    wQuery.Append("			,@PagoCobroNumero ");
                    wQuery.Append("			,@FacturadoPV ");
                    wQuery.Append("			,@FacturadoNumero ");
                    wQuery.Append("			,@IdTipoDestinatario ");
                    wQuery.Append("			,@IdTipoTransportista ");
                    wQuery.Append(")");
                    wQuery.Append("SELECT @@identity");

                    #region Parameters

                    // Documento
                    wCmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.NVarChar)).Value = objeto.cuil.ToString();

                    // Fecha
                    wCmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.DateTime)).Value = objeto.fecha;

                    // ComprobanteTipo
                    wCmd.Parameters.Add(new SqlParameter("@ComprobanteTipo", SqlDbType.Char)).Value = "R";

                    // ComprobantePV
                    wCmd.Parameters.Add(new SqlParameter("@ComprobantePV", SqlDbType.NVarChar)).Value = "0000";

                    // ComprobanteNumero
                    wCmd.Parameters.Add(new SqlParameter("@ComprobanteNumero", SqlDbType.NVarChar)).Value = objeto.numeroComprobante;

                    // Detalle
                    wCmd.Parameters.Add(new SqlParameter("@Detalle", SqlDbType.NVarChar)).Value = objeto.detalle;

                    // Detalle
                    wCmd.Parameters.Add(new SqlParameter("@Unidad", SqlDbType.NVarChar)).Value = objeto.unidad;

                    //Cantidad
                    wCmd.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int)).Value = objeto.cantidad;

                    //PrecioUnitario
                    wCmd.Parameters.Add(new SqlParameter("@PrecioUnitario", SqlDbType.Int)).Value = objeto.precioUnitario;

                    // ImporteDebe
                    if (objeto.debeImporte != 0)
                        wCmd.Parameters.Add(new SqlParameter("@ImporteDebe", SqlDbType.Int)).Value = objeto.debeImporte;
                    else
                        wCmd.Parameters.Add(new SqlParameter("@ImporteDebe", SqlDbType.Int)).Value = 0;

                    // ImporteDebe
                    if (objeto.haberImporte != 0)
                        wCmd.Parameters.Add(new SqlParameter("@ImporteHaber", SqlDbType.Int)).Value = objeto.haberImporte;
                    else
                        wCmd.Parameters.Add(new SqlParameter("@ImporteHaber", SqlDbType.Int)).Value = 0;

                    // DetalleAnio
                    if (objeto.detalleAnio != 0)
                        wCmd.Parameters.Add(new SqlParameter("@DetalleAnio", SqlDbType.Int)).Value = objeto.detalleAnio;
                    else
                        wCmd.Parameters.Add(new SqlParameter("@DetalleAnio", SqlDbType.Int)).Value = DBNull.Value;

                    // DetalleNumero
                    wCmd.Parameters.Add(new SqlParameter("@DetalleNumero", SqlDbType.NVarChar)).Value = objeto.detalleNumero;

                    // PagoCobroAnio
                    if (objeto.detalleAnio != 0)
                        wCmd.Parameters.Add(new SqlParameter("@PagoCobroAnio", SqlDbType.Int)).Value = objeto.pagoCobroAnio;
                    else
                        wCmd.Parameters.Add(new SqlParameter("@PagoCobroAnio", SqlDbType.Int)).Value = DBNull.Value;

                    // PagoCobroNumero
                    wCmd.Parameters.Add(new SqlParameter("@PagoCobroNumero", SqlDbType.NVarChar)).Value = objeto.pagoCobroNumero;

                    wCmd.Parameters.Add(new SqlParameter("@FacturadoPV", SqlDbType.NVarChar)).Value = objeto.facturadoPV;

                    wCmd.Parameters.Add(new SqlParameter("@FacturadoNumero", SqlDbType.NVarChar)).Value = objeto.facturadoNumero;

                    // IdTipoDestinatario
                    if (objeto.tipoDest != 0)
                        wCmd.Parameters.Add(new SqlParameter("@IdTipoDestinatario", SqlDbType.Int)).Value = objeto.tipoDest;
                    else
                        wCmd.Parameters.Add(new SqlParameter("@IdTipoDestinatario", SqlDbType.Int)).Value = DBNull.Value;

                    // IdTipoTransportista
                    if (objeto.tipoDest != 0)
                        wCmd.Parameters.Add(new SqlParameter("@IdTipoTransportista", SqlDbType.Int)).Value = objeto.tipoTrans;
                    else
                        wCmd.Parameters.Add(new SqlParameter("@IdTipoTransportista", SqlDbType.Int)).Value = DBNull.Value;

                    #endregion

                    wCmd.CommandText = wQuery.ToString();

                    wCmd.Connection = (SqlConnection)sqlT.Connection;
                    wCmd.Transaction = (SqlTransaction)sqlT;

                    wCmd.CommandTimeout = wCmd.Connection.ConnectionTimeout;

                    wCmd.ExecuteScalar();
                }

                sqlT.Commit();

                return true;
            }
            catch (SqlException exp)
            {
                sqlT.Rollback();

                return false;
            }
            finally {
                
                sqlT.Dispose();
            }
        }
    }
}
