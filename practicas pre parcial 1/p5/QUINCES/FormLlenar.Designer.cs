namespace QUINCES
{
    partial class FormLlenar
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
            lblFecha = new Label();
            lblNumInvitado = new Label();
            btnLlenar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cbxINVITADO = new CheckBox();
            dtpFecha = new DateTimePicker();
            nudInvitado = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudInvitado).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(44, 127);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(44, 211);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // lblNumInvitado
            // 
            lblNumInvitado.AutoSize = true;
            lblNumInvitado.Location = new Point(12, 294);
            lblNumInvitado.Name = "lblNumInvitado";
            lblNumInvitado.Size = new Size(171, 25);
            lblNumInvitado.TabIndex = 3;
            lblNumInvitado.Text = "Numero de invitado";
            // 
            // btnLlenar
            // 
            btnLlenar.Location = new Point(476, 326);
            btnLlenar.Name = "btnLlenar";
            btnLlenar.Size = new Size(150, 61);
            btnLlenar.TabIndex = 5;
            btnLlenar.Text = "LLENAR";
            btnLlenar.UseVisualStyleBackColor = true;
            btnLlenar.Click += btnLlenar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(212, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(212, 124);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 7;
            // 
            // cbxINVITADO
            // 
            cbxINVITADO.AutoSize = true;
            cbxINVITADO.Location = new Point(241, 358);
            cbxINVITADO.Name = "cbxINVITADO";
            cbxINVITADO.Size = new Size(141, 29);
            cbxINVITADO.TabIndex = 8;
            cbxINVITADO.Text = "Te invitaron? ";
            cbxINVITADO.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(149, 206);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(329, 31);
            dtpFecha.TabIndex = 9;
            // 
            // nudInvitado
            // 
            nudInvitado.Location = new Point(212, 288);
            nudInvitado.Name = "nudInvitado";
            nudInvitado.Size = new Size(150, 31);
            nudInvitado.TabIndex = 10;
            // 
            // FormLlenar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 450);
            Controls.Add(nudInvitado);
            Controls.Add(dtpFecha);
            Controls.Add(cbxINVITADO);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnLlenar);
            Controls.Add(lblNumInvitado);
            Controls.Add(lblFecha);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "FormLlenar";
            Text = "FormLlenar";
            ((System.ComponentModel.ISupportInitialize)nudInvitado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblFecha;
        private Label lblNumInvitado;
        private Button btnLlenar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private CheckBox cbxINVITADO;
        private DateTimePicker dtpFecha;
        private NumericUpDown nudInvitado;
    }
}