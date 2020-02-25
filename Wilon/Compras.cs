using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wilon
{
    public class Compras
    {

        public int documentoCC;
        public int NroDocumentoCC;
        public string NombreCC;
        public string CondicionIVACC;
        public int saldo;

        public int documentoEmisor;
        public int NroDocumentoEmisor;
        public string NombreEmisor;
        public string CondicionIVAEmisor;
        public int comprobante1;
        public int comprobante2;
        public string detalle;

        public int baseImponible1;
        public int baseImponible2;
        public int baseImponible3;
        public int alicuota1;
        public int alicuota2;
        public int alicuota3;
        public int IVA1;
        public int IVA2;
        public int IVA3;
        public double noGrabado;
        public double exento;
        public double otrosImpuestos;
        public int IVA4;
        public int IIBB;
        public int nacionales;
        public int municipales;
        public int internos;

        public int moneda;
        public int TC;
        public int total;

        public void Guardar(int documentoCC,int NroDocumentoCC, string NombreCC, string CondicionIVACC, int saldo,
            int documentoEmisor, int NroDocumentoEmisor, string NombreEmisor, string CondicionIVAEmisor, 
            int comprobante1,int comprobante2, string detalle, int baseImponible1, int baseImponible2,
            int baseImponible3, int alicuota1, int alicuota2, int alicuota3, int IVA1, int IVA2, int IVA3,
            double noGrabado, double exento, double otrosImpuestos, int IVA4, int IIBB, int nacionales, int municipales,
            int internos, int moneda, int TC, int total)
        {
            this.documentoCC = documentoCC;
            this.NroDocumentoCC = NroDocumentoCC;
            this.NombreCC = NombreCC;
            this.CondicionIVACC = CondicionIVACC;
            this.saldo = saldo;
            this.documentoEmisor = documentoEmisor;
            this.NroDocumentoEmisor = NroDocumentoEmisor;
            this.NombreEmisor = NombreEmisor;
            this.CondicionIVAEmisor = CondicionIVAEmisor;
            this.comprobante1 = comprobante1;
            this.comprobante2 = comprobante2;
            this.detalle = detalle;
            this.baseImponible1 = baseImponible1;
            this.baseImponible2 = baseImponible2;
            this.baseImponible3 = baseImponible3;
            this.alicuota1 = alicuota1;
            this.alicuota2 = alicuota2;
            this.alicuota3 = alicuota3;
            this.IVA1 = IVA1;
            this.IVA2 = IVA2;
            this.IVA3 = IVA3;
            this.noGrabado = noGrabado;
            this.exento = exento;
            this.otrosImpuestos = otrosImpuestos;
            this.IVA4 = IVA4;
            this.IIBB = IIBB;
            this.nacionales = nacionales;
            this.municipales = municipales;
            this.internos = internos;
            this.moneda = moneda;
            this.TC = TC;
            this.total = total;
    }

    }
}
