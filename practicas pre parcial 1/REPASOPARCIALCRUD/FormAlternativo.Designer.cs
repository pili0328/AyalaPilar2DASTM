namespace REPASOPARCIALCRUD
{
    partial class FormAlternativo
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblFecha = new Label();
            lblNumSocio = new Label();
            btnFin = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dtpFecha = new DateTimePicker();
            ndNumSocio = new NumericUpDown();
            ckbCuota = new CheckBox();
            txtDNI = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ndNumSocio).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(52, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(52, 117);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(52, 194);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 25);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(343, 55);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(152, 25);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha Nacimiento";
            // 
            // lblNumSocio
            // 
            lblNumSocio.AutoSize = true;
            lblNumSocio.Location = new Point(369, 123);
            lblNumSocio.Name = "lblNumSocio";
            lblNumSocio.Size = new Size(126, 25);
            lblNumSocio.TabIndex = 4;
            lblNumSocio.Text = "Numero Socio";
            // 
            // btnFin
            // 
            btnFin.Location = new Point(243, 302);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(168, 66);
            btnFin.TabIndex = 6;
            btnFin.Text = "FIN";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(175, 117);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 8;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(511, 53);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(352, 31);
            dtpFecha.TabIndex = 9;
            // 
            // ndNumSocio
            // 
            ndNumSocio.Location = new Point(528, 115);
            ndNumSocio.Name = "ndNumSocio";
            ndNumSocio.Size = new Size(150, 31);
            ndNumSocio.TabIndex = 11;
            // 
            // ckbCuota
            // 
            ckbCuota.AutoSize = true;
            ckbCuota.Location = new Point(528, 194);
            ckbCuota.Name = "ckbCuota";
            ckbCuota.Size = new Size(140, 29);
            ckbCuota.TabIndex = 12;
            ckbCuota.Text = "Cuota al dia?";
            ckbCuota.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(175, 188);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(150, 31);
            txtDNI.TabIndex = 13;
            // 
            // FormAlternativo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 450);
            Controls.Add(txtDNI);
            Controls.Add(ckbCuota);
            Controls.Add(ndNumSocio);
            Controls.Add(dtpFecha);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnFin);
            Controls.Add(lblNumSocio);
            Controls.Add(lblFecha);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "FormAlternativo";
            Text = "FormAlternativo";
            ((System.ComponentModel.ISupportInitialize)ndNumSocio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblFecha;
        private Label lblNumSocio;
        private Button btnFin;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private DateTimePicker dtpFecha;
        private NumericUpDown ndNumSocio;
        private CheckBox ckbCuota;
        private TextBox txtDNI;
    }
}