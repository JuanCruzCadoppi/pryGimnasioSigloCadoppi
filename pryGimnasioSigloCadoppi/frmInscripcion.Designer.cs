namespace pryGimnasioSigloCadoppi
{
    partial class frmInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDatosPersonales = new GroupBox();
            chkEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            grpPlan = new GroupBox();
            cboTurno = new ComboBox();
            chkCasillero = new CheckBox();
            txtMeses = new TextBox();
            cboPlan = new ComboBox();
            lblMeses = new Label();
            lblTurno = new Label();
            lblPlan = new Label();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            lblFormaPago = new Label();
            grpFormaPago = new GroupBox();
            cboCuotas = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            grpDatosPersonales.SuspendLayout();
            grpPlan.SuspendLayout();
            grpFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            grpDatosPersonales.Controls.Add(chkEstudiante);
            grpDatosPersonales.Controls.Add(txtEdad);
            grpDatosPersonales.Controls.Add(txtNombre);
            grpDatosPersonales.Controls.Add(lblEdad);
            grpDatosPersonales.Controls.Add(lblNombre);
            grpDatosPersonales.Location = new Point(12, 12);
            grpDatosPersonales.Name = "grpDatosPersonales";
            grpDatosPersonales.Size = new Size(320, 134);
            grpDatosPersonales.TabIndex = 0;
            grpDatosPersonales.TabStop = false;
            grpDatosPersonales.Text = "Datos personales";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(188, 87);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(85, 83);
            txtEdad.MaxLength = 2;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(72, 23);
            txtEdad.TabIndex = 1;
            txtEdad.TextChanged += txt_TextChanged;
            txtEdad.KeyPress += txt_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(85, 43);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(207, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txt_TextChanged;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(18, 86);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // grpPlan
            // 
            grpPlan.Controls.Add(cboTurno);
            grpPlan.Controls.Add(chkCasillero);
            grpPlan.Controls.Add(txtMeses);
            grpPlan.Controls.Add(cboPlan);
            grpPlan.Controls.Add(lblMeses);
            grpPlan.Controls.Add(lblTurno);
            grpPlan.Controls.Add(lblPlan);
            grpPlan.Location = new Point(12, 152);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(320, 154);
            grpPlan.TabIndex = 1;
            grpPlan.TabStop = false;
            grpPlan.Text = "Plan Mensual";
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Location = new Point(85, 110);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(174, 23);
            cboTurno.TabIndex = 3;
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(188, 76);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(74, 19);
            chkCasillero.TabIndex = 2;
            chkCasillero.Text = "Casillero ";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(85, 72);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(72, 23);
            txtMeses.TabIndex = 1;
            txtMeses.TextChanged += txt_TextChanged;
            txtMeses.KeyPress += txt_KeyPress;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Location = new Point(85, 34);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(174, 23);
            cboPlan.TabIndex = 0;
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(18, 75);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(40, 15);
            lblMeses.TabIndex = 2;
            lblMeses.Text = "Meses";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(18, 113);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(39, 15);
            lblTurno.TabIndex = 1;
            lblTurno.Text = "Turno";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(18, 37);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(30, 15);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "Plan";
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(134, 32);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(60, 19);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            rbTarjeta.CheckedChanged += rbTarjeta_CheckedChanged;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(18, 32);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(230, 389);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(0, 15);
            lblFormaPago.TabIndex = 3;
            // 
            // grpFormaPago
            // 
            grpFormaPago.Controls.Add(cboCuotas);
            grpFormaPago.Controls.Add(rbEfectivo);
            grpFormaPago.Controls.Add(rbTarjeta);
            grpFormaPago.Location = new Point(12, 312);
            grpFormaPago.Name = "grpFormaPago";
            grpFormaPago.Size = new Size(320, 92);
            grpFormaPago.TabIndex = 8;
            grpFormaPago.TabStop = false;
            grpFormaPago.Text = "Forma de pago";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(134, 57);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(158, 23);
            cboCuotas.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(146, 410);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(230, 410);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmInscripcion
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 447);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grpFormaPago);
            Controls.Add(grpPlan);
            Controls.Add(grpDatosPersonales);
            Controls.Add(lblFormaPago);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo - Inscripción";
            Load += frmInscripcion_Load;
            grpDatosPersonales.ResumeLayout(false);
            grpDatosPersonales.PerformLayout();
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            grpFormaPago.ResumeLayout(false);
            grpFormaPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatosPersonales;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private GroupBox grpPlan;
        private Label lblFormaPago;
        private Label lblMeses;
        private Label lblTurno;
        private Label lblPlan;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
        private ComboBox cbTurno;
        private ComboBox cboPlan;
        private CheckBox chkEstudiante;
        private GroupBox grpFormaPago;
        private CheckBox chkCasillero;
        private TextBox txtMeses;
        private ComboBox cboCuotas;
        private Button btnCalcular;
        private Button btnLimpiar;
        private ComboBox cboTurno;
    }
}