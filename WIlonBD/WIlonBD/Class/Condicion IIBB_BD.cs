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
    public class Condicion_IIBB_BD : Commons.BaseDAO
    {

        public DataTable SelectAll()
        {
            StringBuilder wQuery = new StringBuilder();
            SqlCommand wCmd = new SqlCommand();

            try
            {
                wQuery = new StringBuilder("SELECT Id, ");
                wQuery.Append("			Descripcion");
                wQuery.Append("			FROM [CondicionesIIBB] ");


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

        //private List<Condicion_IIBB> TestSetCollection(SqlDataReader wDR)
        //{
        //    List<Condicion_IIBB> wRtnList = new List<Condicion_IIBB>();

        //    while (wDR.Read())
        //    {
        //        Condicion_IIBB wCondicionIIBB = new Condicion_IIBB();

        //        // Id
        //        if (wDR["Id"] != DBNull.Value)
        //            wCondicionIIBB.Id = Convert.ToInt32(wDR["Id"]);

        //        // Texto
        //        if (wDR["Descripcion"] != DBNull.Value)
        //            wCondicionIIBB.Descripcion = Convert.ToString(wDR["Descripcion"]);

        //        wRtnList.Add(wCondicionIIBB);
        //    }

        //    return wRtnList;
        //}
    }
}
