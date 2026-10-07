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
        // Declaración de constantes 
        const decimal PRECIO_MUSCULACION = 15000;
        const decimal PRECIO_FUNCIONAL = 18000;
        const decimal PRECIO_NATACION = 22000;
        const decimal PRECIO_CASILLERO = 3000;
        const int EDAD_MINIMA = 14;
        const decimal RECARGO_TARJETA_3_CUOTAS = 0.10m;
        const decimal RECARGO_TARJETA_6_CUOTAS = 0.20m;

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void EstadoInicial()
        {
            // Valores por defecto
            txtNombre.Clear();
            txtEdad.Clear();
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            txtMeses.Text = "1";
            rbEfectivo.Checked = true;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            // Agregar los items a los comboBox

            cboPlan.Items.Add("Musculación");
            cboPlan.Items.Add("Funcional");
            cboPlan.Items.Add("Natación");

            cboTurno.Items.Add("Mañana (7 a 12 hs)");
            cboTurno.Items.Add("Tarde ( 14 a 18 hs)");
            cboTurno.Items.Add("Noche (18 a 23 hs)");

            cboCuotas.Items.Add("1 cuota sin recargo");
            cboCuotas.Items.Add("3 cuotas +10%");
            cboCuotas.Items.Add("6 cuotas +20%");
            EstadoInicial();
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked == true)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }

        //Evento para que solo se puedan ingresar números en el TextBox txtMeses y txtEdad

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //Eventos para activar el botón calcular cuando se ingresan los datos en los TextBox
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }

    

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string planElegido = cboPlan.Text;
            string horarioElegido;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);
            int cuotas = 1;
            decimal precioMensual = 0;
            decimal subtotal = 0;
            decimal porcentajeDescuento = 0;
            decimal porcentajeAjuste = 0;
            decimal total = 0;
            decimal valorCuota = 0;

            //Evento para calcular el total a pagar y mostrar un mensaje de error si la edad es
            //menor a 14 años o si el número de meses es menor a 1 o mayor a 12

            if (edad < 14)
            {
                MessageBox.Show("La edad mínima para inscribirse es de 14 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("El número de meses debe estar entre 1 y 12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Estructura para guardar plan elegido

            switch (planElegido)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;

                default:
                    MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            //Estructura para guardar horario elegido

            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horarioElegido = "Mañana (7 a 12 hs)";
                    break;
                case 1:
                    horarioElegido = "Tarde (14 a 18 hs)";
                    break;
                case 2:
                    horarioElegido = "Noche (18 a 23 hs)";
                    break;
                default:
                    MessageBox.Show("Debe seleccionar un turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            //Validación de casillero seleccionado

            if (chkCasillero.Checked) precioMensual = precioMensual + PRECIO_CASILLERO;
           
           subtotal = precioMensual * meses;
        
            //Validación para aplicar descuento correspondiente

            if (edad < 18)
            {
                porcentajeDescuento = 0.25m;
                total = subtotal - (subtotal * porcentajeDescuento);
            }
            else if (edad >= 65)
            {
                porcentajeDescuento = 0.30m;
                total = subtotal - (subtotal * porcentajeDescuento);

            }
            else if (chkEstudiante.Checked)
            {
                porcentajeDescuento = 0.15m;
                total = subtotal - (subtotal * porcentajeDescuento);
            }
            else
            {
                porcentajeDescuento = 0;
                total = subtotal - (subtotal * porcentajeDescuento);
            }

            //Validación para aplicar recargo correspondiente con tarjeta de credito
            //y número de cuotas seleccionadas

            if (rbEfectivo.Checked)
            {
                porcentajeAjuste = 0.1m;
                total = total - (total * porcentajeAjuste);
            }
            else if (rbTarjeta.Checked)
            {
                switch (cboCuotas.SelectedIndex)
                {
                    case 0:
                        porcentajeAjuste = 0;
                        cuotas = 1;
                        total = total + (total * porcentajeAjuste);
                        break;
                    case 1:
                        porcentajeAjuste = RECARGO_TARJETA_3_CUOTAS;
                        cuotas = 3;
                        total = total + (total * porcentajeAjuste);
                        break;
                    case 2:
                        porcentajeAjuste = RECARGO_TARJETA_6_CUOTAS;
                        cuotas = 6;
                        total = total + (total * porcentajeAjuste);
                        break;
                    default:
                        MessageBox.Show("Debe seleccionar un número de cuotas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
            }

            string categoria = edad < 18 ? "Menor" : "Mayor";

            string formaPago = rbEfectivo.Checked
                ? "Efectivo"
                : "Tarjeta en " + cuotas + " cuotas";

            valorCuota = rbEfectivo.Checked
                ? total
                : total / cuotas;





            MessageBox.Show($"SubTotal ${subtotal}Total a pagar: ${total:F2} Cuota: ${valorCuota:F2}", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EstadoInicial();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }
    }
}
