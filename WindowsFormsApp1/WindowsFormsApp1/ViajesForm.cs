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
        //crear lista
        List<Terceros> razon = new List<Terceros>();
        List<Viajes> listaTransportista = new List<Viajes>();

        public ViajesForm()
        {
            InitializeComponent();
            LlenarCombos();

        }

        public void LlenarCombos()
        {
            var obCuilCuitDest = new TercerosBS();
            DataTable dt = obCuilCuitDest.SeleccionarTodosDT();

            //llenar lista con datatable
            foreach (DataRow row in dt.Rows)
            {
                Terceros rs = new Terceros();
                rs.documento = row["Documento"].ToString();
                rs.razonSocial = row["RazonSocial"].ToString();

                razon.Add(rs);
            }

            //Combo CUIL/CUIT Destinatario

            cmbCuilDest.DisplayMember = "Documento";
            cmbCuilDest.ValueMember = "Documento";
            cmbCuilDest.DataSource = obCuilCuitDest.SeleccionarTodosDT();
            cmbCuilDest.SelectedValue = -1;
           
            //Combo CUIL/CUIT Transportista
            var obCuilCuitTrans = new TercerosBS();

            cmbCuilTrans.DisplayMember = "Documento";
            cmbCuilTrans.ValueMember = "Documento";
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
                var cuilSeleccionado = cmbCuilDest.SelectedValue.ToString();

                foreach (Terceros item in razon)
                {
                    if (item.documento.ToString() == cuilSeleccionado) 
                    {
                        txtNombreDest.Text = item.razonSocial;
                    }
                }
            }
            else
            {
                txtNombreDest.Text = "";
            }
        }

        private void cmbCuilTrans_SelectedIndexChanged(object sender, EventArgs e)      //cambia el txtNombreDest
        {
            if (cmbCuilTrans.SelectedValue != null)
            {
                var cuilSeleccionado = cmbCuilTrans.SelectedValue.ToString();

                foreach (Terceros item in razon)
                {
                    if (item.documento.ToString() == cuilSeleccionado)
                    {
                        txtNombreTrans.Text = item.razonSocial;
                    }
                }
            }
            else
            {
                txtNombreTrans.Text = "";
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

            //Agregar a lista listaTransportista para guardar
            Viajes objetoLista = new Viajes();

            objetoLista.fecha = date2.Value;
            objetoLista.detalleNumero = int.Parse(txtComprobanteTrans.Text);
            objetoLista.detalle = txtDetalleTrans.Text;
            int importe = int.Parse(txtImporteTrans.Text);

            if (importe > 0)
            {
                objetoLista.debeImporte = importe;
            }
            else
            {
                objetoLista.haberImporte = importe;
            }

            listaTransportista.Add(objetoLista);

            ListViewItem item = new ListViewItem(date2.Value.ToString("dd/MM/yyyy"));   //crea los items
            item.SubItems.Add(txtComprobanteTrans.Text);    //crea los subitems
            item.SubItems.Add(txtDetalleTrans.Text);
            item.SubItems.Add(txtImporteTrans.Text);

            listView1.Columns.Add("Fecha",210);     //crea columnas
            listView1.Columns.Add("Comprobante Nº",115);
            listView1.Columns.Add("Detalle",250);
            listView1.Columns.Add("Importe", 125);

            listView1.Items.AddRange(new ListViewItem[] { item });  //se agregan los items al listview

            txtComprobanteTrans.Text = "";
            txtDetalleTrans.Text = "";
            txtImporteTrans.Text = "";

        }

        private void btnMenos_Click(object sender, EventArgs e)     
        {
            Viajes borrar = new Viajes();

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int a = int.Parse(item.SubItems[1].Text);
                item.Remove();          //elimina fila del listview

                foreach (Viajes objeto in listaTransportista)
                {
                    if (a == objeto.detalleNumero)
                    {
                        borrar = objeto;
                    }
                }
                listaTransportista.Remove(borrar);      //elimina objeto de la listaTransportista (para guardar)
            }
                        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string cuilDest = "";
            string cuilTrans = "";
            int tipoDest = 0;
            int tipoTrans = 0;
            char tipoComprobante = 'R';

            var viajes = new ViajesBS();
            var obDestinatario = new Viajes();
            var obTransportista = new Viajes();
            var obTransportista2 = new Viajes();

            Object selectedItem = cmbCuilDest.SelectedItem;


            //validacion para los combos
            if (cmbCuilDest.SelectedValue != null)
                cuilDest = cmbCuilDest.SelectedValue.ToString();
            if (cmbTipoDest.SelectedValue != null)
                int.TryParse(cmbTipoDest.SelectedValue.ToString(), out tipoDest);
            if (cmbCuilTrans.SelectedValue != null)
                cuilTrans = cmbCuilTrans.SelectedValue.ToString();
            if (cmbTipoTrans.SelectedValue != null)
                int.TryParse(cmbTipoTrans.SelectedValue.ToString(), out tipoTrans);

            if (string.IsNullOrWhiteSpace(txtRemito.Text))
            {
                MessageBox.Show("Ingrese un Numero de Remito");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCantidadTrans.Text)) 
            {
                MessageBox.Show("Ingrese una Cantidad para el Transportista");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtValorTrans.Text))
            {
                MessageBox.Show("Ingrese una Valor para el Transportista");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDetalleTrans2.Text))
            {
                MessageBox.Show("Ingrese una Detalle para el Transportista");
                return;
            }
            
            List<Viajes> lstViajes = new List<Viajes>();

            decimal cantidadDest = 0;
            decimal valorDest = 0;

            decimal.TryParse(txtCantidadDest.Text, out cantidadDest);
            decimal.TryParse(txtValorDest.Text, out valorDest);

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

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {           
            Close();
        }
    }
}
