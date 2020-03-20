using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wilon;
using WIlonBD.Class;

namespace WilonBussines
{
    public class TercerosBS
    {
        public void Guardar(string razonSocial, string documento, int condicionIva, string direccion, int nro, int cp, int localidad,
            int provincia, string nroTelefono, string cel, string email, int condicionIIBB, string nroIIBB, bool calculaIntereses, decimal tasa,
            string cbu)
        {
            var obTerceros = new Terceros();

            obTerceros.razonSocial = razonSocial;         //iguala las variables a sus respectivos parametros
            obTerceros.documento = documento;
            obTerceros.condicionIva = condicionIva;
            obTerceros.direccion = direccion;
            obTerceros.nro = nro;
            obTerceros.cp = cp;
            obTerceros.localidad = localidad;
            obTerceros.provincia = provincia;
            obTerceros.nroTelefono = nroTelefono;
            obTerceros.cel = cel;
            obTerceros.email = email;
            obTerceros.condicionIIBB = condicionIIBB;
            obTerceros.nroIIBB = nroIIBB;
            obTerceros.calculaIntereses = calculaIntereses;
            obTerceros.tasa = tasa;
            obTerceros.cbu = cbu;

            var obTercerobd = new TerceroBD();

            obTercerobd.Save(obTerceros);

        }

        public DataTable SeleccionarTodosDT()
        {
            var wLstCondicion = new DataTable();
            var wBD = new TerceroBD();
            wLstCondicion = wBD.SelectAll();
            return wLstCondicion;

        }

    }
}
