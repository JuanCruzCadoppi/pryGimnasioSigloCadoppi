using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryGimnasioSigloCadoppi
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
         

            //Carga de opciones comboBox

            cboPlan.Items.Add("Musculación $15.000");
            cboPlan.Items.Add("Funcional $18.000");
            cboPlan.Items.Add("Natación $22.000");

            cboTurno.Items.Add("Mañana (7 a 12 hs)");
            cboTurno.Items.Add("Tarde ( 14 a 18 hs)");
            cboTurno.Items.Add("Noche (18 a 23 hs)");

            cboCuotas.Items.Add("1 cuota sin recargo");
            cboCuotas.Items.Add("3 cuotas +10%");
            cboCuotas.Items.Add("6 cuotas +20%");

            // Set default selected index for combo boxes

            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;

            rbEfectivo.Checked = true;

            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
           
        }
    }
}
