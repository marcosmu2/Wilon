using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIlonBD.Class;
using Wilon;
using System.Data;

namespace WilonBussines
{
    public class ProvinciaBS
    {
        public DataTable SeleccionarTodosDT()
        {
            var wLstCondicion = new DataTable();
            var wBD = new ProvinciaBD();
            wLstCondicion = wBD.SelectAll();
            return wLstCondicion;
        }
    }
}
