using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wilon
{
    public class CuentasCorrientes
    {
        public int nroDocumento;
        public string nombre;
        public int saldo;

        public void Guardar(int nroDocumento, string nombre, int saldo)
        {
            this.nroDocumento = nroDocumento;
            this.nombre = nombre;
            this.saldo = saldo;
        }

    }
}
