using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIlonBD.Class
{
    public class TercerosBD : Commons.BaseDAO
    {

        public void guardar(object obTercero)
        {
            StringBuilder wQuery = new StringBuilder();
            SqlCommand wCmd = new SqlCommand();

            try
            {
                wQuery = new StringBuilder("INSERT INTO [Test] (");
                wQuery.Append("			[Texto] ");
                wQuery.Append("			,[FechaHora] ");
                wQuery.Append("			,[ValorBinario] ");
                wQuery.Append(") VALUES (");
                wQuery.Append("			'hola' ");
                wQuery.Append("			,'10/12/2019' ");
                wQuery.Append("			,1 ");
                wQuery.Append(")");


                wCmd.CommandText = wQuery.ToString();
                if (base.mSqlTransaction == null)
                    wCmd.Connection = base.GetOpenedConection();
                else
                {
                    wCmd.Connection = (SqlConnection)base.mSqlTransaction.Connection;
                    wCmd.Transaction = (SqlTransaction)base.mSqlTransaction;
                }
                wCmd.CommandTimeout = wCmd.Connection.ConnectionTimeout;

                Convert.ToInt32(wCmd.ExecuteScalar());
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
