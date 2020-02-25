using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIlonBD.Class
{
    public class LocalidadBD : Commons.BaseDAO
    {

        public DataTable SelectByProvinciaId(int idProvincia)
        {
            StringBuilder wQuery = new StringBuilder();
            SqlCommand wCmd = new SqlCommand();

            try
            {
                wQuery = new StringBuilder("SELECT Id, ");
                wQuery.Append("			Nombre");
                wQuery.Append("			FROM [Localidades] ");
                wQuery.Append("			WHERE IdProvincia = @ProvinciaId"); //"@" parametro en la base de datos
                wQuery.Append("		    ORDER BY Nombre");

                wCmd.Parameters.Add(new SqlParameter("@ProvinciaId", SqlDbType.Int)).Value=idProvincia;

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
