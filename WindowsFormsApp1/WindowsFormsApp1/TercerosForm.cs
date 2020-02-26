using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wilon;
using WilonBussines;

namespace WindowsFormsApp1
{
    public partial class TercerosForm : Form
    {
        public TercerosForm()
        {
            InitializeComponent();
            LlenarCombos();
        }

        private void LlenarCombos()
        {
            //Combo condicion IVA
            var obCondicion = new CondicionBS();

            cmbCondIva.DisplayMember = "Descripcion";
            cmbCondIva.ValueMember = "Id";
            cmbCondIva.DataSource = obCondicion.SeleccionarTodosDT();
            cmbCondIva.SelectedValue = -1;

            //Combo Provincias
            var obProvincia = new ProvinciaBS();

            cmbProvincia.DisplayMember = "Nombre";
            cmbProvincia.ValueMember = "Id";
            cmbProvincia.DataSource = obProvincia.SeleccionarTodosDT();
            cmbProvincia.SelectedValue = -1;

            //Combo IIBB
            var obCondicionIIBB = new CondicionIIBB_BS();

            cmbCondIIBB.DisplayMember = "Descripcion";
            cmbCondIIBB.ValueMember = "Id";
            cmbCondIIBB.DataSource = obCondicionIIBB.SeleccionarTodosDT();
            cmbCondIIBB.SelectedValue = -1;

            //Combo Intereses
            List<Item> lista = new List<Item>();

            lista.Add(new Item("SI", true));
            lista.Add(new Item("NO", false));

            cmbCalculaIntereses.DisplayMember = "Name";
            cmbCalculaIntereses.ValueMember = "Value";
            cmbCalculaIntereses.DataSource = lista;
            cmbCalculaIntereses.SelectedValue = -1;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int documento;
            decimal tasa;
            int nrodomicilio; 
            int cp;
            int CondIVA = 0;
            int provincia = 0;
            int localidad = 0;
            int CondIIBB = 0;
            bool calculaInteres = false;
            var obTerceros = new TercerosBS();      //crea objeto tipo Terceros        

            if (txtNombre.Text != "")       //obliga a ingresar razon social
            {

            }
            else
            {
                MessageBox.Show("Ingrese Razón Social");
                return;
            }

            if (int.TryParse(txtDocumento.Text, out documento))              //validacion numero de CUIL/CUIT
            {

            }
            else
            {
                MessageBox.Show("Debe escribir el numero de CUIL/CUIT sin guiones");
                return;
            }

            int.TryParse(txtNro.Text, out nrodomicilio);      //Convierte a Int todos los datos que ingregas (string)
            int.TryParse(txtCp.Text, out cp);
            decimal.TryParse(txtTasa.Text, out tasa);
            if(cmbCondIva.SelectedValue != null)
                int.TryParse(cmbCondIva.SelectedValue.ToString(), out CondIVA);
            if (cmbCalculaIntereses.SelectedValue != null)
                bool.TryParse(cmbCalculaIntereses.SelectedValue.ToString(), out calculaInteres);
            if (cmbProvincia.SelectedValue != null)
                provincia = retornarIdProvincia(cmbProvincia.SelectedValue.ToString());
            if (cmbLocalidad.SelectedValue != null)
                int.TryParse(cmbLocalidad.SelectedValue.ToString(), out localidad);       //convierte en int el valor del combo
            if (cmbCondIIBB.SelectedValue != null)
                int.TryParse(cmbCondIIBB.SelectedValue.ToString(), out CondIIBB);

            obTerceros.Guardar(txtNombre.Text, documento, CondIVA, txtDireccion.Text, nrodomicilio, cp, provincia, localidad, txtNroTelefono.Text, txtCel.Text,
                txtEmail.Text, CondIIBB, txtNroIIBB.Text, calculaInteres, tasa, TxtCbu.Text);      //llama al metodo guardar

            Close();
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)  //cargar combo localidades depende provincia
        {
            if (cmbProvincia.SelectedValue != null)
            {
                var localidad = new LocalidadBS();

                cmbLocalidad.DisplayMember = "Nombre";
                cmbLocalidad.ValueMember = "Id";
                cmbLocalidad.DataSource = localidad.SeleccionarPorProvinciaDT(retornarIdProvincia(cmbProvincia.SelectedValue.ToString()));
                cmbLocalidad.SelectedValue = -1;
            }

        }

        private int retornarIdProvincia(string provinciastr)
        {

            int provincia = int.Parse(provinciastr);
            return provincia;
        }

        private void CmbCalculaIntereses_SelectedIndexChanged(object sender, EventArgs e)   
        {
            if (cmbCalculaIntereses.SelectedValue != null)      //bloquea la opcion tasa si se indica "NO"
            {
                bool calculaInteres;
                bool.TryParse(cmbCalculaIntereses.SelectedValue.ToString(), out calculaInteres);

                if (calculaInteres)
                {
                    txtTasa.Enabled = true;
                }
                else
                {
                    txtTasa.Enabled = false;
                    txtTasa.Text = "";      //Convierte tasa en "" si eligen opcion "NO"
                }
            }
            else {
                txtTasa.Enabled = false;
                txtTasa.Text = "";
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
