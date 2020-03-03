using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wilon;
using WilonBussines;

namespace WindowsFormsApp1
{
    public partial class ViajesForm : Form
    {
        public ViajesForm()
        {
            InitializeComponent();
            LlenarCombos();

        }

        public void LlenarCombos()
        {
            //Combo CUIL/CUIT Destinatario
            var obCuilCuitDest = new TercerosBS();

            cmbCuilDest.DisplayMember = "Documento";
            cmbCuilDest.ValueMember = "RazonSocial";
            cmbCuilDest.DataSource = obCuilCuitDest.SeleccionarTodosDT();
            cmbCuilDest.SelectedValue = -1;
           
            //Combo CUIL/CUIT Transportista
            var obCuilCuitTrans = new TercerosBS();

            cmbCuilTrans.DisplayMember = "Documento";
            cmbCuilTrans.ValueMember = "RazonSocial";
            cmbCuilTrans.DataSource = obCuilCuitTrans.SeleccionarTodosDT();
            cmbCuilTrans.SelectedValue = -1;

            //Combo Tipo Destinatario
            var obTipoDest = new TipoDestinatarioBS();

            cmbTipoDest.DisplayMember = "Descripcion";
            cmbTipoDest.ValueMember = "Id";
            cmbTipoDest.DataSource = obTipoDest.SeleccionarTodosDT();
            cmbTipoDest.SelectedValue = -1;

            //Combo Tipo Transportista
            var obTipoTrans = new TipoTransportistaBS();

            cmbTipoTrans.DisplayMember = "Descripcion";
            cmbTipoTrans.ValueMember = "Id";
            cmbTipoTrans.DataSource = obTipoTrans.SeleccionarTodosDT();
            cmbTipoTrans.SelectedValue = -1;

        }

        private void cmbCuilDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCuilDest.SelectedValue != null)      //cambia el txtNombreDest
            {
                txtNombreDest.Text = cmbCuilDest.SelectedValue.ToString();
                txtNombreDest.Enabled = false;
            }
            else
            {
                txtNombreDest.Text = "";
                txtNombreDest.Enabled = true;
            }
        }

        private void cmbCuilTrans_SelectedIndexChanged(object sender, EventArgs e)      //cambia el txtNombreDest
        {
            if (cmbCuilTrans.SelectedValue != null)      
            {
                txtNombreTrans.Text = cmbCuilTrans.SelectedValue.ToString();
                txtNombreTrans.Enabled = false;
            }
            else
            {
                txtNombreTrans.Text = "";
                txtNombreTrans.Enabled = true;
            }
        }

        private void btnMas_Click(object sender, EventArgs e)                    //CREAR LISTA
        {
            listView1.View = View.Details;      //mostrar la vista en modo detalle
            listView1.FullRowSelect = true;     //selecciona toda la fila y no solo la celda

            if (txtComprobanteTrans.Text == "")         //validacion datos que van a la lista
            {    
                MessageBox.Show("Debe ingresar un número de Comprobante antes de añadir a la lista");
                return;
            }
            if (txtDetalleTrans.Text == "")
            {
                MessageBox.Show("Debe ingresar un Detalle antes de añadir a la lista");
                return;
            }
            if (txtImporteTrans.Text == "")
            {
                MessageBox.Show("Debe ingresar un Importe antes de añadir a la lista");
                return;
            }

            ListViewItem item = new ListViewItem(date2.Value.ToString("dd/MM/yyyy"));   //crea los items
            item.SubItems.Add(txtComprobanteTrans.Text);    //crea los subitems
            item.SubItems.Add(txtDetalleTrans.Text);
            item.SubItems.Add(txtImporteTrans.Text);

            listView1.Columns.Add("Fecha",210);     //crea columnas
            listView1.Columns.Add("Comprobante Nº",115);
            listView1.Columns.Add("Detalle",250);
            listView1.Columns.Add("Importe", 125);

            listView1.Items.AddRange(new ListViewItem[] { item });  //se agregan los items al listview

        }

        private void btnMenos_Click(object sender, EventArgs e)     //elimina elementos de la lista
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                item.Remove();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cuilDest = 0;
            int cuilTrans = 0;
            int tipoDest = 0;
            int tipoTrans = 0;
            char tipoComprobante = 'R';

            var viajes = new ViajesBS();
            var obDestinatario = new Viajes();
            var obTransportista = new Viajes();
            var obTransportista2 = new Viajes();

            Object selectedItem = cmbCuilDest.SelectedItem;

            //validacion para los combos
            if (cmbCuilDest.SelectedItem.ToString() != null)
                int.TryParse(cmbCuilDest.SelectedItem.ToString(), out cuilDest);
            if (cmbTipoDest.SelectedValue != null)
                int.TryParse(cmbTipoDest.SelectedValue.ToString(), out tipoDest);
            if (cmbCuilTrans.SelectedValue != null)
                int.TryParse(cmbCuilTrans.SelectedValue.ToString(), out cuilTrans);
            if (cmbCuilTrans.SelectedValue != null)
                int.TryParse(cmbTipoTrans.SelectedValue.ToString(), out tipoTrans);

            if (txtRemito.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Ingrese un Numero de Remito");
                return;
            }

            if (txtCantidadTrans.Text != "") 
            {

            }
            else
            {
                MessageBox.Show("Ingrese una Cantidad para el Transportista");
                return;
            }

            if (txtValorTrans.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Ingrese una Valor para el Transportista");
                return;
            }
            if (txtDetalleTrans2.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Ingrese una Detalle para el Transportista");
                return;
            }

            List<Viajes> lstViajes = new List<Viajes>();

            decimal cantidadDest = 0;
            decimal valorDest = 0;

            decimal.TryParse(txtCantidadDest.Text, out cantidadDest);
            decimal.TryParse(txtCantidadDest.Text, out valorDest);

            //guarda datos del destinatario
            obDestinatario =  viajes.crearObjeto(cuilDest, date1.Value, tipoComprobante, 0, int.Parse(txtRemito.Text),
                    txtDetalleDest.Text, txtUnidadDest.Text, cantidadDest, valorDest,
                    valorDest, 0, 0, 0, 0, 0, 0, 0, tipoDest, 0);

            lstViajes.Add(obDestinatario);

            ////guarda datos de la lista transportista
            //obTransportista = viajes.crearObjeto(cuilTrans, date1.Value, tipoComprobante, 0, int.Parse(txtRemito.Text),
            //    txtDetalleDest.Text, txtUnidadDest.Text, decimal.Parse(txtCantidadDest.Text), decimal.Parse(txtValorDest.Text),
            //    decimal.Parse(txtTotalDest.Text), 0, 0, 0, 0, 0, 0, 0, tipoDest, 0);

            //lstViajes.Add(obTransportista);

            decimal cantidadTrans = 0;
            decimal valorTrans = 0;

            decimal.TryParse(txtCantidadTrans.Text, out cantidadTrans);
            decimal.TryParse(txtValorTrans.Text, out valorTrans);
            //guarda datos del transportista
            obTransportista2 = viajes.crearObjeto(cuilTrans, date1.Value, tipoComprobante, 0, int.Parse(txtRemito.Text),
                txtDetalleTrans2.Text, txtUnidadTrans.Text, cantidadTrans, valorTrans,
                0, valorTrans, 0, 0, 0, 0, 0, 0, 0, tipoTrans);

            lstViajes.Add(obTransportista2);

            viajes.guardarLista(lstViajes);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
