using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryGimnasioSigloCadoppi
{
    public partial class frmConsulta : Form
    {
        private string[] clientes;

        public frmConsulta(string[] listaClientes)
        {
            InitializeComponent();

            clientes = listaClientes;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lstConsulta.Items.Clear();

            for (int i = 0; i < clientes.Length; i++)
            {
                if (!string.IsNullOrEmpty(clientes[i])){
                    lstConsulta.Items.Add(clientes[i].Replace("\n"," | "));
                }
            }
        }
    }
}
