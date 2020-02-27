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
    public class Tipo_Destinatario_BD : Commons.BaseDAO
    {

        public DataTable SelectAll()
        {
            StringBuilder wQuery = new StringBuilder();
            SqlCommand wCmd = new SqlCommand();

            try
            {
                wQuery = new StringBuilder("SELECT Id, ");
                wQuery.Append("			Descripcion");
                wQuery.Append("			FROM [TipoDestinatarios] ");


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
