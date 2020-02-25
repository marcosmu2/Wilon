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
    public class CondicionIVABD : Commons.BaseDAO
    {
        public DataTable SelectAll()
        {
            StringBuilder wQuery = new StringBuilder();
            SqlCommand wCmd = new SqlCommand();

            try
            {
                wQuery = new StringBuilder("SELECT Id, ");
                wQuery.Append("			Descripcion");
                wQuery.Append("			FROM [CondicionesIVA] ");


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

        private List<Condicion> TestSetCollection(SqlDataReader wDR)
        {
            List<Condicion> wRtnList = new List<Condicion>();

            while (wDR.Read())
            {
                Condicion wCondicion = new Condicion();

                // Id
                if (wDR["Id"] != DBNull.Value)
                    wCondicion.Id = Convert.ToInt32(wDR["Id"]);

                // Texto
                if (wDR["Descripcion"] != DBNull.Value)
                    wCondicion.Descripcion = Convert.ToString(wDR["Descripcion"]);

                wRtnList.Add(wCondicion);
            }

            return wRtnList;
        }
    }
}
