namespace SeguimosPracticando
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
            lblEdad = new Label();
            lblNacimiento = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            ndEdad = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            btnLLenar = new Button();
            ((System.ComponentModel.ISupportInitialize)ndEdad).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(63, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(63, 125);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(401, 48);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(59, 25);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "EDAD";
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Location = new Point(350, 125);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(177, 25);
            lblNacimiento.TabIndex = 3;
            lblNacimiento.Text = "FECHA NACIMIENTO";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(177, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(177, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 5;
            // 
            // ndEdad
            // 
            ndEdad.Location = new Point(523, 48);
            ndEdad.Name = "ndEdad";
            ndEdad.Size = new Size(180, 31);
            ndEdad.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(549, 123);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(349, 31);
            dtpFecha.TabIndex = 7;
            // 
            // btnLLenar
            // 
            btnLLenar.Location = new Point(401, 197);
            btnLLenar.Name = "btnLLenar";
            btnLLenar.Size = new Size(188, 52);
            btnLLenar.TabIndex = 8;
            btnLLenar.Text = "LLENAR";
            btnLLenar.UseVisualStyleBackColor = true;
            btnLLenar.Click += btnLLenar_Click;
            // 
            // FormLlenar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 286);
            Controls.Add(btnLLenar);
            Controls.Add(dtpFecha);
            Controls.Add(ndEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNacimiento);
            Controls.Add(lblEdad);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "FormLlenar";
            Text = "FormLlenar";
            ((System.ComponentModel.ISupportInitialize)ndEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblEdad;
        private Label lblNacimiento;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private NumericUpDown ndEdad;
        private DateTimePicker dtpFecha;
        private Button btnLLenar;
    }
}