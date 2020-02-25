using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wilon
{
    public class Pago
    {

        public int nroDocumento;
        public string nombre;
        public int saldo;
        public int medioDePago;
        public int nro;
        public string entidad;
        public int FOrigen;
        public int FVto;
        public int importe;
        public int saldoPropios;
        public int saldoTerceros;
        public int importeTotal;

        public void Guardar(int nroDocumento, string nombre, int saldo, int medioDePago, int nro, string entidad,
            int FOrigen, int FVto, int importe, int saldoPropios, int saldoTerceros, int importeTotal)
        {
            this.nroDocumento = nroDocumento;
            this.nombre = nombre;
            this.saldo = saldo;
            this.medioDePago = medioDePago;
            this.nro = nro;
            this.entidad = entidad;
            this.FOrigen = FOrigen;
            this.FVto = FVto;
            this.importe = importe;
            this.saldoPropios = saldoPropios;
            this.saldoTerceros = saldoTerceros;
            this.importeTotal = importeTotal;

        }

    }
}
