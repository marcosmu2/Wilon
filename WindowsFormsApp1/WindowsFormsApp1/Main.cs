using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnTerceros_Click(object sender, EventArgs e)
        {

            var form1 = new TercerosForm(); 
            form1.Show();

        }

        private void btnViajes_Click(object sender, EventArgs e)
        {

            var form2 = new ViajesForm();
            form2.Show();

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

            var form3 = new ComprasForm();
            form3.Show();

        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            var form4 = new PagoForm();
            form4.Show();
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            var form5 = new CobrosForm();
            form5.Show();
        }

    }
}
