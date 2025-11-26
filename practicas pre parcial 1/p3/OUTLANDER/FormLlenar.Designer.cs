namespace OUTLANDER
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
            lblFecha = new Label();
            lblTemporadas = new Label();
            txtNombre = new TextBox();
            txtTemporadas = new TextBox();
            dtpFechaEstreno = new DateTimePicker();
            btnLlenar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(57, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(16, 118);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(146, 25);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "FECHA ESTRENO";
            // 
            // lblTemporadas
            // 
            lblTemporadas.AutoSize = true;
            lblTemporadas.Location = new Point(34, 170);
            lblTemporadas.Name = "lblTemporadas";
            lblTemporadas.Size = new Size(128, 25);
            lblTemporadas.TabIndex = 2;
            lblTemporadas.Text = "TEMPORADAS";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(168, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtTemporadas
            // 
            txtTemporadas.Location = new Point(168, 170);
            txtTemporadas.Name = "txtTemporadas";
            txtTemporadas.Size = new Size(300, 31);
            txtTemporadas.TabIndex = 4;
            // 
            // dtpFechaEstreno
            // 
            dtpFechaEstreno.Location = new Point(168, 112);
            dtpFechaEstreno.Name = "dtpFechaEstreno";
            dtpFechaEstreno.Size = new Size(300, 31);
            dtpFechaEstreno.TabIndex = 5;
            // 
            // btnLlenar
            // 
            btnLlenar.Location = new Point(276, 217);
            btnLlenar.Name = "btnLlenar";
            btnLlenar.Size = new Size(192, 47);
            btnLlenar.TabIndex = 6;
            btnLlenar.Text = "LLENAR";
            btnLlenar.UseVisualStyleBackColor = true;
            btnLlenar.Click += btnLlenar_Click;
            // 
            // FormLlenar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 300);
            Controls.Add(btnLlenar);
            Controls.Add(dtpFechaEstreno);
            Controls.Add(txtTemporadas);
            Controls.Add(txtNombre);
            Controls.Add(lblTemporadas);
            Controls.Add(lblFecha);
            Controls.Add(lblNombre);
            Name = "FormLlenar";
            Text = "FormLlenar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblFecha;
        private Label lblTemporadas;
        private TextBox txtNombre;
        private TextBox txtTemporadas;
        private DateTimePicker dtpFechaEstreno;
        private Button btnLlenar;
    }
}