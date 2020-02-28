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
    public partial class CuentasCorrientesForm : Form
    {
        public CuentasCorrientesForm()
        {
            InitializeComponent();
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            var form1 = new FacturacionForm();
            form1.Show();
        }
        private void btnEgresos_Click(object sender, EventArgs e)
        {
            var form2 = new ComprasForm();
            form2.Show();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form3 = new TercerosForm();
            form3.Show();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
