namespace pryGimnasioSigloCadoppi
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            lstConsulta = new ListBox();
            btnVolver = new Button();
            btnVer = new Button();
            SuspendLayout();
            // 
            // lstConsulta
            // 
            lstConsulta.FormattingEnabled = true;
            lstConsulta.Location = new Point(12, 12);
            lstConsulta.Name = "lstConsulta";
            lstConsulta.Size = new Size(509, 184);
            lstConsulta.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(433, 202);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(352, 202);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 23);
            btnVer.TabIndex = 2;
            btnVer.Text = "VER";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // frmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 239);
            Controls.Add(btnVer);
            Controls.Add(btnVolver);
            Controls.Add(lstConsulta);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmConsulta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Consulta Clientes";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstConsulta;
        private Button btnVolver;
        private Button btnVer;
    }
}