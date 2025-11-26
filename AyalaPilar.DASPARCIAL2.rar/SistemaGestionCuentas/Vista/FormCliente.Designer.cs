namespace Vista
{
    partial class FormCliente
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
            btnVOLVER = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblTel = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtTelefono = new TextBox();
            lblClientes = new Label();
            dgvClientes = new DataGridView();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnVOLVER
            // 
            btnVOLVER.Location = new Point(98, 384);
            btnVOLVER.Name = "btnVOLVER";
            btnVOLVER.Size = new Size(185, 69);
            btnVOLVER.TabIndex = 0;
            btnVOLVER.Text = "VOLVER";
            btnVOLVER.UseVisualStyleBackColor = true;
            btnVOLVER.Click += btnVOLVER_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(34, 141);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(95, 25);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "APELLIDO:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(34, 222);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(47, 25);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(34, 309);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(101, 25);
            lblTel.TabIndex = 4;
            lblTel.Text = "TELEFONO:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(183, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(183, 141);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 31);
            txtApellido.TabIndex = 6;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(183, 222);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(150, 31);
            txtDNI.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(183, 309);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 8;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(705, 26);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(185, 25);
            lblClientes.TabIndex = 24;
            lblClientes.Text = "CLIENTES EXISTENTES";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(637, 70);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(596, 361);
            dgvClientes.TabIndex = 23;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(421, 452);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(195, 55);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "MODIFICAR DATOS";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(421, 391);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(195, 55);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "ELIMINAR CLIENTE";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(421, 330);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(195, 55);
            btnCrear.TabIndex = 20;
            btnCrear.Text = "REGISTRAR CLIENTE";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 522);
            Controls.Add(lblClientes);
            Controls.Add(dgvClientes);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(txtTelefono);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblTel);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnVOLVER);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVOLVER;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblTel;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtTelefono;
        private Label lblClientes;
        private DataGridView dgvClientes;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCrear;
    }
}