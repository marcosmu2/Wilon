using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIlonBD.Class;
using Wilon;
using System.Data;

namespace WilonBussines
{
    public class CondicionIIBB_BS
    {
        public DataTable SeleccionarTodosDT()
        {
            var wLstCondicion = new DataTable();
            var wBD = new Condicion_IIBB_BD();
            wLstCondicion = wBD.SelectAll();
            return wLstCondicion;
        }
    }
}
