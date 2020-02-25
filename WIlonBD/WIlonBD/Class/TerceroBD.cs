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
    public class TerceroBD: Commons.BaseDAO
    {

        public int Save(Terceros objeto)
        {
            StringBuilder wQuery = new StringBuilder();
            SqlCommand wCmd = new SqlCommand();

            try
            {
                wQuery = new StringBuilder("INSERT INTO [Terceros] (");
                wQuery.Append("			[RazonSocial] ");
                wQuery.Append("			,[Documento] ");
                wQuery.Append("			,[CondicionIVA] ");
                wQuery.Append("			,[Direccion] ");
                wQuery.Append("			,[NroCalle] ");
                wQuery.Append("			,[CodigoPostal] ");
                wQuery.Append("			,[Localidad] ");
                wQuery.Append("			,[Provincia] ");
                wQuery.Append("			,[NroTelefono] ");
                wQuery.Append("			,[Celular] ");
                wQuery.Append("			,[Email] ");
                wQuery.Append("			,[CondicionIIBB] ");
                wQuery.Append("			,[NumeroIIBB] ");
                wQuery.Append("			,[CalculaInteres] ");
                wQuery.Append("			,[Tasa] ");
                wQuery.Append("			,[CBU] ");
                wQuery.Append(") VALUES (");
                wQuery.Append("			@RazonSocial ");
                wQuery.Append("			,@Documento ");
                wQuery.Append("			,@CondicionIVA ");
                wQuery.Append("			,@Direccion ");
                wQuery.Append("			,@NroCalle ");
                wQuery.Append("			,@CodigoPostal ");
                wQuery.Append("			,@Localidad ");
                wQuery.Append("			,@Provincia ");
                wQuery.Append("			,@NroTelefono ");
                wQuery.Append("			,@Celular ");
                wQuery.Append("			,@Email ");
                wQuery.Append("			,@CondicionIIBB ");
                wQuery.Append("			,@NumeroIIBB ");
                wQuery.Append("			,@CalculaInteres ");
                wQuery.Append("			,@Tasa ");
                wQuery.Append("			,@CBU ");
                wQuery.Append(")");
                wQuery.Append("SELECT @@identity");

                #region Parameters

                // RazonSocial
                wCmd.Parameters.Add(new SqlParameter("@RazonSocial", SqlDbType.NVarChar)).Value = objeto.razonSocial;

                // Documento
                wCmd.Parameters.Add(new SqlParameter("@Documento", SqlDbType.Int)).Value = objeto.documento;

                // CondicionIVA
                if (objeto.condicionIva != 0)
                    wCmd.Parameters.Add(new SqlParameter("@CondicionIVA", SqlDbType.Int)).Value = objeto.condicionIva;
                else
                    wCmd.Parameters.Add(new SqlParameter("@CondicionIVA", SqlDbType.Int)).Value = DBNull.Value;

                // Direccion
                wCmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.NVarChar)).Value = objeto.direccion;

                // NroCalle
                if (objeto.nro != 0)
                    wCmd.Parameters.Add(new SqlParameter("@NroCalle", SqlDbType.Int)).Value = objeto.nro;
                 else
                    wCmd.Parameters.Add(new SqlParameter("@NroCalle", SqlDbType.Int)).Value = DBNull.Value;


                // CodigoPostal
                if (objeto.cp != 0)
                    wCmd.Parameters.Add(new SqlParameter("@CodigoPostal", SqlDbType.Int)).Value = objeto.cp;
                 else
                    wCmd.Parameters.Add(new SqlParameter("@CodigoPostal", SqlDbType.Int)).Value = DBNull.Value;

                // Localidad
                if (objeto.localidad != 0)
                    wCmd.Parameters.Add(new SqlParameter("@Localidad", SqlDbType.Int)).Value = objeto.localidad;
                 else
                    wCmd.Parameters.Add(new SqlParameter("@Localidad", SqlDbType.Int)).Value = DBNull.Value;

                // Provincia
                if (objeto.provincia != 0)
                    wCmd.Parameters.Add(new SqlParameter("@Provincia", SqlDbType.Int)).Value = objeto.provincia;
                 else
                    wCmd.Parameters.Add(new SqlParameter("@Provincia", SqlDbType.Int)).Value = DBNull.Value;

                // NroTelefono
                if (objeto.nroTelefono != string.Empty)
                    wCmd.Parameters.Add(new SqlParameter("@NroTelefono", SqlDbType.NVarChar)).Value = objeto.nroTelefono;
                else
                    wCmd.Parameters.Add(new SqlParameter("@NroTelefono", SqlDbType.NVarChar)).Value = DBNull.Value;

                // Celular
                if (objeto.cel != string.Empty)
                    wCmd.Parameters.Add(new SqlParameter("@Celular", SqlDbType.NVarChar)).Value = objeto.cel;
                else
                    wCmd.Parameters.Add(new SqlParameter("@Celular", SqlDbType.NVarChar)).Value = DBNull.Value;

                // Email
                if (objeto.email != string.Empty)
                    wCmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar)).Value = objeto.email;
                else
                    wCmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar)).Value = DBNull.Value;

                // CondicionIIBB
                if (objeto.condicionIIBB != 0)
                    wCmd.Parameters.Add(new SqlParameter("@CondicionIIBB", SqlDbType.Int)).Value = objeto.condicionIIBB;
                else
                    wCmd.Parameters.Add(new SqlParameter("@CondicionIIBB", SqlDbType.Int)).Value = DBNull.Value;

                // NumeroIIBB
                if (objeto.nroIIBB != string.Empty)
                    wCmd.Parameters.Add(new SqlParameter("@NumeroIIBB", SqlDbType.NVarChar)).Value = objeto.nroIIBB;
                else
                    wCmd.Parameters.Add(new SqlParameter("@NumeroIIBB", SqlDbType.NVarChar)).Value = DBNull.Value;

                // CalculaInteres
                    wCmd.Parameters.Add(new SqlParameter("@CalculaInteres", SqlDbType.Bit)).Value = objeto.calculaIntereses;


                // Tasa
                if (objeto.tasa != 0)
                    wCmd.Parameters.Add(new SqlParameter("@Tasa", SqlDbType.NVarChar)).Value = objeto.tasa;
                else
                    wCmd.Parameters.Add(new SqlParameter("@Tasa", SqlDbType.NVarChar)).Value = DBNull.Value;

                // CBU
                wCmd.Parameters.Add(new SqlParameter("@CBU", SqlDbType.NVarChar)).Value = objeto.cbu;

                #endregion

                wCmd.CommandText = wQuery.ToString();
                if (base.mSqlTransaction == null)
                    wCmd.Connection = base.GetOpenedConection();
                else
                {
                    wCmd.Connection = (SqlConnection)base.mSqlTransaction.Connection;
                    wCmd.Transaction = (SqlTransaction)base.mSqlTransaction;
                }
                wCmd.CommandTimeout = wCmd.Connection.ConnectionTimeout;

                int wRtn = Convert.ToInt32(wCmd.ExecuteScalar());

                return wRtn;
            }
            catch (SqlException exp)
            {
                throw new Exception(exp.Message);
            }
            finally
            {
                if (base.mSqlTransaction == null)
                    base.CloseConection();
            }
        }

        public DataTable SelectAll()
        {
            StringBuilder wQuery = new StringBuilder();
            SqlCommand wCmd = new SqlCommand();

            try
            {
                wQuery = new StringBuilder("SELECT Id, ");
                wQuery.Append("			Documento, RazonSocial");
                wQuery.Append("			FROM [Terceros] ");


                wCmd.CommandText = wQuery.ToString();
                if (base.mSqlTransaction == null)
                    wCmd.Connection = base.GetOpenedConection();
                else
                {
                    wCmd.Connection = (SqlConnection)base.mSqlTransaction.Connection;
                    wCmd.Transaction = (SqlTransaction)base.mSqlTransaction;
                }
                wCmd.CommandTimeout = wCmd.Connection.ConnectionTimeout;

                SqlDataReader wSqlDataReader = wCmd.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(wSqlDataReader);
                wSqlDataReader.Close();

                return dataTable;
            }
            catch (SqlException exp)
            {
                throw new Exception(exp.Message);
            }
            finally
            {
                if (base.mSqlTransaction == null)
                    base.CloseConection();

            }
        }

    }
}
