using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wilon;
using WilonBussines;

namespace WindowsFormsApp1
{
    public partial class CuentasCorrientesForm : Form
    {

        List<Terceros> llenarCombo = new List<Terceros>();
        List<Viajes> listaCtaCte = new List<Viajes>();

        public CuentasCorrientesForm()
        {
            InitializeComponent();
            LlenarCombos();
        }
        public void LlenarCombos()
        {
            var obDocumento = new TercerosBS();
            DataTable dt = obDocumento.SeleccionarTodosDT();

            //llenar lista con datatable
            foreach (DataRow row in dt.Rows)
            {
                Terceros rs = new Terceros();
                rs.documento = row["Documento"].ToString();
                rs.razonSocial = row["RazonSocial"].ToString();

                llenarCombo.Add(rs);
            }

            //Combo Documento

            cmbDocumento.DisplayMember = "Documento";
            cmbDocumento.ValueMember = "Documento";
            cmbDocumento.DataSource = obDocumento.SeleccionarTodosDT();
            cmbDocumento.SelectedValue = -1;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            
            var obViajes = new ViajesBS();
            DataTable dt = obViajes.SeleccionarPorDocumento(cmbDocumento.SelectedValue.ToString());      //filtra por parametro
            
            if(cmbDocumento.SelectedValue != null)
            {
                listaCtaCte.Clear();

                foreach (DataRow row in dt.Rows)
                {
                        Viajes rs = new Viajes();

                        rs.fecha = Convert.ToDateTime(row["Fecha"]);
                        rs.numeroComprobante = Convert.ToInt32(row["ComprobanteNumero"]);
                        rs.detalle = row["Detalle"].ToString();
                        rs.unidad = row["Unidad"].ToString();
                        rs.cantidad = Convert.ToDecimal(row["Cantidad"]);
                        rs.precioUnitario= Convert.ToDecimal(row["PrecioUnitario"]);
                        rs.debeImporte = Convert.ToDecimal(row["ImporteDebe"]);
                        rs.haberImporte = Convert.ToDecimal(row["ImporteHaber"]);

                        listaCtaCte.Add(rs);
                }

            }

            listView1.Clear();

            listView1.View = View.Details;      //mostrar la vista en modo detalle
            listView1.FullRowSelect = true;     //selecciona toda la fila y no solo la celda

            listView1.Columns.Add("Fecha", 75);     //crea columnas
            listView1.Columns.Add("Comprobante Nº", 95);
            listView1.Columns.Add("Detalle", 250);
            listView1.Columns.Add("Unidad", 70);
            listView1.Columns.Add("Cantidad", 70);
            listView1.Columns.Add("Valor Un.", 70);
            listView1.Columns.Add("DEBE", 70);
            listView1.Columns.Add("HABER", 70);

            foreach (var objeto in listaCtaCte)
            {

                ListViewItem item = new ListViewItem(objeto.fecha.ToString("dd/MM/yyyy"));   //crea los items
                item.SubItems.Add(objeto.numeroComprobante.ToString());    //crea los subitems
                item.SubItems.Add(objeto.detalle.ToString());
                item.SubItems.Add(objeto.unidad.ToString());
                item.SubItems.Add(objeto.cantidad.ToString());
                item.SubItems.Add(objeto.precioUnitario.ToString());
                item.SubItems.Add(objeto.debeImporte.ToString());
                item.SubItems.Add(objeto.haberImporte.ToString());



                listView1.Items.AddRange(new ListViewItem[] { item });  //se agregan los items al listview
            }
            
        }
        private void cmbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtNombre.Enabled = false;

            if (cmbDocumento.SelectedValue != null)      //cambia el txtNombre
            {
                var cuilSeleccionado = cmbDocumento.SelectedValue.ToString();

                foreach (Terceros item in llenarCombo)
                {
                    if (item.documento.ToString() == cuilSeleccionado)
                    {
                        txtNombre.Text = item.razonSocial;
                    }
                }
            }
            else
            {
                txtNombre.Text = "";
            }
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
