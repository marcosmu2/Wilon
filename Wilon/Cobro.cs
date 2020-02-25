using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wilon
{
    public class Cobro
    {
        public string test;
        public int nroDocumento;
        public string nombre;
        public int saldo;
        public int medioDePago;
        public int nro;
        public string entidad;
        public int FOrigen;
        public int FVto;
        public int importe;
        public int saldoMediosDePago;
        public int importeTotal;
        public int totalEfectivo;

        public void Guardar(int nroDocumento, string nombre, int saldo, int medioDePago, int nro, string entidad,
            int FOrigen, int FVto, int importe, int saldoMediosDePago, int importeTotal, int totalEfectivo)
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
            this.saldoMediosDePago = saldoMediosDePago;
            this.importeTotal = importeTotal;
            this.totalEfectivo = totalEfectivo;

        }
    }
}
