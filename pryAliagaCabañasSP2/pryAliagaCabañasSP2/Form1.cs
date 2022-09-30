using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAliagaCabañasSP2
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cargar los items en el primer control combobox
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Tipo A");
            cmbTipo.Items.Add("Tipo B");
            // esta acción provocará el disparo del evento "SelectedIndexChanged"
            cmbTipo.SelectedIndex = 0;
            // se inicializa la cantidad de días en 1
            txtDias.Text = "1";
            // inicialzar los demás controles de la interfaz
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevision.Checked = false;
            // en los radiobuttons se asigna sólo el que debe quedar en true
            optEfectivo.Checked = true;
            txtNombres.Text = "";
            txtTelefonos.Text = "";
            // cargar los items del combo de tarjetas
            cmbTarjeta.Items.Clear();
            cmbTarjeta.Items.Add("Card Red");
            cmbTarjeta.Items.Add("Card Green");
            cmbTarjeta.Items.Add("Card Blue");
            // deshabiliar el botón "Aceptar"
            btnAceptar.Enabled = false;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cuando ocurra el evento se debe actualizar el 
            // contenido del combo de personas
            int i = 0;
            // limpiar los items de personas
            cmbPersonas.Items.Clear();
            // si es tipo de cabaña A ->> cargar los items del 1 al 4
            if (cmbTipo.SelectedIndex == 0) // o cmbTipo.SelectedItem == "Tipo A"
            {
                for (i = 1; i <= 4; i++)
                {
                    cmbPersonas.Items.Add(i);
                }
            }
            else
            { // si es tipo de cabaña B ->> cargar los items del 1 al 8
                for (i = 1; i <= 8; i++)
                {
                    cmbPersonas.Items.Add(i);
                }
            }
            // establecer como preseleccionado el item 0 del combo
            cmbPersonas.SelectedIndex = 0;
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            // se deshabilita el combo y no se muestra nada
            cmbTarjeta.Enabled = false;
            cmbTarjeta.SelectedIndex = -1;
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            // se habilita el combo y se muestra el primer item
            cmbTarjeta.Enabled = true;
            cmbTarjeta.SelectedIndex = 0;
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el botón "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
                txtNombres.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el botón "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
                txtNombres.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtTelefonos_TextChanged(object sender, EventArgs e)
        {
            // condiciones para habilitar o no el botón "Aceptar"
            if (txtDias.Text != "" && txtDias.Text != "0" &&
                txtNombres.Text != "" && txtTelefonos.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccionaste la cabaña " + cmbTipo.Text + " para " + cmbPersonas.Text + " personas, por " + txtDias.Text + " dia/s");
            MessageBox.Show(" Titular de la reserva: " + txtNombres.Text + " - Teléfono de contacto: " + txtTelefonos.Text);


            // inicialzar los controles de la interfaz al estado inicial del formulario
            cmbTipo.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevision.Checked = false;
            // en los radiobuttons se asigna sólo el que debe quedar en true
            optEfectivo.Checked = true;
            txtNombres.Text = "";
            txtTelefonos.Text = "";
        }
    }
}

   