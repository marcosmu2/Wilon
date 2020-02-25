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
    public class LocalidadBS
    {
        public DataTable SeleccionarPorProvinciaDT(int idProvincia)
        {
            var wLstCondicion = new DataTable();
            var wBD = new LocalidadBD();
            wLstCondicion = wBD.SelectByProvinciaId(idProvincia);
            return wLstCondicion;
        }
    }
}
