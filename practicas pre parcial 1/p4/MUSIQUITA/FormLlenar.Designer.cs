namespace MUSIQUITA
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
            btnRellenar = new Button();
            lblNombre = new Label();
            lblDuracion = new Label();
            ckbPlaylist = new CheckBox();
            txtNombre = new TextBox();
            txtDuracion = new TextBox();
            SuspendLayout();
            // 
            // btnRellenar
            // 
            btnRellenar.Location = new Point(79, 257);
            btnRellenar.Name = "btnRellenar";
            btnRellenar.Size = new Size(206, 47);
            btnRellenar.TabIndex = 0;
            btnRellenar.Text = "RELLENAR";
            btnRellenar.UseVisualStyleBackColor = true;
            btnRellenar.Click += btnRellenar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(62, 53);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(26, 136);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(142, 25);
            lblDuracion.TabIndex = 2;
            lblDuracion.Text = "DURACION MIN";
            // 
            // ckbPlaylist
            // 
            ckbPlaylist.AutoSize = true;
            ckbPlaylist.Location = new Point(187, 204);
            ckbPlaylist.Name = "ckbPlaylist";
            ckbPlaylist.Size = new Size(194, 29);
            ckbPlaylist.TabIndex = 3;
            ckbPlaylist.Text = "AGREGAR PLAYLIST";
            ckbPlaylist.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(187, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 4;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(187, 133);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(150, 31);
            txtDuracion.TabIndex = 5;
            // 
            // FormLlenar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 374);
            Controls.Add(txtDuracion);
            Controls.Add(txtNombre);
            Controls.Add(ckbPlaylist);
            Controls.Add(lblDuracion);
            Controls.Add(lblNombre);
            Controls.Add(btnRellenar);
            Name = "FormLlenar";
            Text = "FormLlenar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRellenar;
        private Label lblNombre;
        private Label lblDuracion;
        private CheckBox ckbPlaylist;
        private TextBox txtNombre;
        private TextBox txtDuracion;
    }
}