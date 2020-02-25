using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIlonBD.Commons
{
    public abstract class BaseDAO
    {
        protected const string COLLATE_QUERY = " "; //" COLLATE Latin1_General_CI_AI "; //ATENCION: Debe tener espacios al principio y final de la cadena!!!
        protected static string mCadenaConexion = "";

        #region --[ Constructor / Destructor ]--
        public BaseDAO()
        {
        }
        #endregion --[ Constructor / Destructor ]--


        #region --[ Variables y Propiedades Privadas ]--

        internal SqlConnection mSqlConnection = null;
        internal SqlTransaction mSqlTransaction = null;

        private string GetCadenaConexion()
        {
            if (string.IsNullOrWhiteSpace(mCadenaConexion))
            {
                mCadenaConexion = Parameters.GetConnectionString();
            }

            return mCadenaConexion;
        }

        #endregion --[ Variables y Propiedades Privadas ]--

        #region --[ Funciones Publicas: Conexion ]--

        public SqlConnection GetOpenedConection()
        {
            try
            {
                if (mSqlConnection == null)
                    mSqlConnection = new SqlConnection(this.GetCadenaConexion());

                mSqlConnection.Open();
                return (mSqlConnection);
            }
            catch (Exception wEx)
            {
                //CerrarConexion();
                throw new Exception("Error al conectarse con la Base de Datos. No se pudo Abrir la Conexion.", wEx);
            }
        }

        public void CloseConection()
        {
            if (mSqlConnection != null && mSqlConnection.State.Equals(ConnectionState.Open))
            {
                mSqlConnection.Close();
                mSqlConnection.Dispose();
                mSqlConnection = null;
            }
        }

        #endregion --[ Funciones Publicas: Conexion ]--

        #region --[ Funciones Publicas: Transacciones ]--

        public SqlTransaction TransactionBegin()
        {
            if (mSqlTransaction == null)
            {
                SqlConnection wSqlConnection = new SqlConnection(this.GetCadenaConexion());
                wSqlConnection.Open();
                mSqlTransaction = wSqlConnection.BeginTransaction();
            }

            return (mSqlTransaction);
        }

        public void TransactionCommit()
        {
            if (mSqlTransaction != null)
            {
                mSqlTransaction.Commit();
                mSqlTransaction.Dispose();
                mSqlTransaction = null;
            }
            else
                throw new Exception("No se puede hacer Commit a la Transaccion porque no fue Iniciada.");
        }

        public void TransactionRollback()
        {
            if (mSqlTransaction != null)
            {
                mSqlTransaction.Rollback();
                mSqlTransaction.Dispose();
                mSqlTransaction = null;
            }
            else
                throw new Exception("No se puede hacer Rollback a la Transaccion porque no fue Iniciada.");
        }

        #endregion --[ Funciones Publicas: Transacciones ]--
    }
}
