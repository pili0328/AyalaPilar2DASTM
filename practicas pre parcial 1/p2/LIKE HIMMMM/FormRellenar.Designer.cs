namespace LIKE_HIMMMM
{
    partial class FormRellenar
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
            lblEstreno = new Label();
            lblPuestoTOP = new Label();
            txtNombre = new TextBox();
            cbVista = new CheckBox();
            txtTop = new TextBox();
            dtpEstreno = new DateTimePicker();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(62, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEstreno
            // 
            lblEstreno.AutoSize = true;
            lblEstreno.Location = new Point(62, 119);
            lblEstreno.Name = "lblEstreno";
            lblEstreno.Size = new Size(71, 25);
            lblEstreno.TabIndex = 1;
            lblEstreno.Text = "Estreno";
            // 
            // lblPuestoTOP
            // 
            lblPuestoTOP.AutoSize = true;
            lblPuestoTOP.Location = new Point(389, 48);
            lblPuestoTOP.Name = "lblPuestoTOP";
            lblPuestoTOP.Size = new Size(112, 25);
            lblPuestoTOP.TabIndex = 2;
            lblPuestoTOP.Text = "PUESTO TOP";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(176, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 4;
            // 
            // cbVista
            // 
            cbVista.AutoSize = true;
            cbVista.Location = new Point(536, 118);
            cbVista.Name = "cbVista";
            cbVista.Size = new Size(88, 29);
            cbVista.TabIndex = 5;
            cbVista.Text = "LA VI?";
            cbVista.UseVisualStyleBackColor = true;
            // 
            // txtTop
            // 
            txtTop.Location = new Point(507, 42);
            txtTop.Name = "txtTop";
            txtTop.Size = new Size(150, 31);
            txtTop.TabIndex = 6;
            // 
            // dtpEstreno
            // 
            dtpEstreno.Location = new Point(154, 118);
            dtpEstreno.Name = "dtpEstreno";
            dtpEstreno.Size = new Size(334, 31);
            dtpEstreno.TabIndex = 7;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(289, 203);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(154, 38);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "ENVIAR";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FormRellenar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 267);
            Controls.Add(btnEnviar);
            Controls.Add(dtpEstreno);
            Controls.Add(txtTop);
            Controls.Add(cbVista);
            Controls.Add(txtNombre);
            Controls.Add(lblPuestoTOP);
            Controls.Add(lblEstreno);
            Controls.Add(lblNombre);
            Name = "FormRellenar";
            Text = "FormRellenar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEstreno;
        private Label lblPuestoTOP;
        private TextBox txtNombre;
        private CheckBox cbVista;
        private TextBox txtTop;
        private DateTimePicker dtpEstreno;
        private Button btnEnviar;
    }
}