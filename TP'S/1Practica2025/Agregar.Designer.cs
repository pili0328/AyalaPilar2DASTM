namespace _1Practica2025
{
    partial class Agregar
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
            lblEdad = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            btnAgrego = new Button();
            ckbMayor = new CheckBox();
            ckbMenor = new CheckBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(84, 54);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(83, 121);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(52, 25);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(216, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(216, 115);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(150, 31);
            txtEdad.TabIndex = 3;
            // 
            // btnAgrego
            // 
            btnAgrego.Location = new Point(330, 249);
            btnAgrego.Name = "btnAgrego";
            btnAgrego.Size = new Size(112, 34);
            btnAgrego.TabIndex = 4;
            btnAgrego.Text = "AGREGO";
            btnAgrego.UseVisualStyleBackColor = true;
            btnAgrego.Click += btnAgrego_Click;
            // 
            // ckbMayor
            // 
            ckbMayor.AutoSize = true;
            ckbMayor.Location = new Point(216, 164);
            ckbMayor.Name = "ckbMayor";
            ckbMayor.Size = new Size(178, 29);
            ckbMayor.TabIndex = 5;
            ckbMayor.Text = "MAYOR DE EDAD";
            ckbMayor.UseVisualStyleBackColor = true;
            // 
            // ckbMenor
            // 
            ckbMenor.AutoSize = true;
            ckbMenor.Location = new Point(215, 201);
            ckbMenor.Name = "ckbMenor";
            ckbMenor.Size = new Size(180, 29);
            ckbMenor.TabIndex = 6;
            ckbMenor.Text = "MENOR DE EDAD";
            ckbMenor.UseVisualStyleBackColor = true;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 331);
            Controls.Add(ckbMenor);
            Controls.Add(ckbMayor);
            Controls.Add(btnAgrego);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "Agregar";
            Text = "Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEdad;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Button btnAgrego;
        private CheckBox ckbMayor;
        private CheckBox ckbMenor;
    }
}