namespace Vista
{
    partial class FormCuentaCorriente
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
            dgvListadoCuentas = new DataGridView();
            dgvEstadoActual = new DataGridView();
            lblTodasCuentas = new Label();
            lblEstado = new Label();
            lblCualCliente = new Label();
            lblDescripcion = new Label();
            lblTipo = new Label();
            dudCliente = new DomainUpDown();
            dudTipo = new DomainUpDown();
            lblMonto = new Label();
            txtMonto = new TextBox();
            btnRegistrarCuenta = new Button();
            dudDescripcion = new DomainUpDown();
            btnEliminarCuenta = new Button();
            btnClientes = new Button();
            btnMovimientos = new Button();
            lblMensaje = new Label();
            lblFecha = new Label();
            dtpFechaMov = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvListadoCuentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoActual).BeginInit();
            SuspendLayout();
            // 
            // dgvListadoCuentas
            // 
            dgvListadoCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoCuentas.Location = new Point(12, 45);
            dgvListadoCuentas.Name = "dgvListadoCuentas";
            dgvListadoCuentas.RowHeadersWidth = 62;
            dgvListadoCuentas.Size = new Size(1147, 513);
            dgvListadoCuentas.TabIndex = 0;
            dgvListadoCuentas.SelectionChanged += dgvListadoCuentas_SelectionChanged;
            // 
            // dgvEstadoActual
            // 
            dgvEstadoActual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadoActual.Location = new Point(1454, 45);
            dgvEstadoActual.Name = "dgvEstadoActual";
            dgvEstadoActual.RowHeadersWidth = 62;
            dgvEstadoActual.Size = new Size(378, 225);
            dgvEstadoActual.TabIndex = 1;
            // 
            // lblTodasCuentas
            // 
            lblTodasCuentas.AutoSize = true;
            lblTodasCuentas.Location = new Point(12, 17);
            lblTodasCuentas.Name = "lblTodasCuentas";
            lblTodasCuentas.Size = new Size(190, 25);
            lblTodasCuentas.TabIndex = 5;
            lblTodasCuentas.Text = "CUENTAS EXISTENTES:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(1454, 17);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(353, 25);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "ESTADO ACTUAL CUENTA SELECCIONADA:";
            // 
            // lblCualCliente
            // 
            lblCualCliente.AutoSize = true;
            lblCualCliente.Location = new Point(1377, 289);
            lblCualCliente.Name = "lblCualCliente";
            lblCualCliente.Size = new Size(152, 25);
            lblCualCliente.TabIndex = 7;
            lblCualCliente.Text = "Registrar cuenta:  ";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(1377, 350);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(239, 25);
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "Descripcion de movimiento: ";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(1377, 411);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(133, 25);
            lblTipo.TabIndex = 9;
            lblTipo.Text = "Tipo de cuenta:";
            // 
            // dudCliente
            // 
            dudCliente.Location = new Point(1618, 287);
            dudCliente.Name = "dudCliente";
            dudCliente.Size = new Size(215, 31);
            dudCliente.TabIndex = 11;
            dudCliente.Text = "SELECCIONA CLIENTE";
            // 
            // dudTipo
            // 
            dudTipo.Location = new Point(1618, 405);
            dudTipo.Name = "dudTipo";
            dudTipo.Size = new Size(214, 31);
            dudTipo.TabIndex = 13;
            dudTipo.Text = "SELECCIONA TIPO";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(1377, 467);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(226, 25);
            lblMonto.TabIndex = 14;
            lblMonto.Text = "Ingresar monto requerido: ";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(1618, 467);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(214, 31);
            txtMonto.TabIndex = 15;
            // 
            // btnRegistrarCuenta
            // 
            btnRegistrarCuenta.Location = new Point(1202, 576);
            btnRegistrarCuenta.Name = "btnRegistrarCuenta";
            btnRegistrarCuenta.Size = new Size(254, 50);
            btnRegistrarCuenta.TabIndex = 16;
            btnRegistrarCuenta.Text = "REGISTRAR CUENTA";
            btnRegistrarCuenta.UseVisualStyleBackColor = true;
            btnRegistrarCuenta.Click += btnRegistrarCuenta_Click;
            // 
            // dudDescripcion
            // 
            dudDescripcion.Location = new Point(1618, 350);
            dudDescripcion.Name = "dudDescripcion";
            dudDescripcion.Size = new Size(215, 31);
            dudDescripcion.TabIndex = 17;
            dudDescripcion.Text = "SELECCION QUE HARA";
            // 
            // btnEliminarCuenta
            // 
            btnEliminarCuenta.Location = new Point(1202, 641);
            btnEliminarCuenta.Name = "btnEliminarCuenta";
            btnEliminarCuenta.Size = new Size(254, 50);
            btnEliminarCuenta.TabIndex = 20;
            btnEliminarCuenta.Text = "ELIMINAR CUENTA";
            btnEliminarCuenta.UseVisualStyleBackColor = true;
            btnEliminarCuenta.Click += btnEliminarCuenta_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(667, 601);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(254, 75);
            btnClientes.TabIndex = 21;
            btnClientes.Text = "CONSULTAR CLIENTES";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnMovimientos
            // 
            btnMovimientos.Location = new Point(388, 601);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(254, 75);
            btnMovimientos.TabIndex = 22;
            btnMovimientos.Text = "CONSULTAR MOVIMIENTOS";
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = SystemColors.ControlLight;
            lblMensaje.Location = new Point(12, 563);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(352, 75);
            lblMensaje.TabIndex = 23;
            lblMensaje.Text = "los movimientos se consultan por clientes, \r\ndebe seleccionar uno para poder\r\n abrir el formulario";
            lblMensaje.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1377, 519);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(140, 25);
            lblFecha.TabIndex = 24;
            lblFecha.Text = "Fecha realizada: ";
            // 
            // dtpFechaMov
            // 
            dtpFechaMov.Location = new Point(1618, 519);
            dtpFechaMov.Name = "dtpFechaMov";
            dtpFechaMov.Size = new Size(214, 31);
            dtpFechaMov.TabIndex = 25;
            // 
            // FormCuentaCorriente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1844, 703);
            Controls.Add(dtpFechaMov);
            Controls.Add(lblFecha);
            Controls.Add(lblMensaje);
            Controls.Add(btnMovimientos);
            Controls.Add(btnClientes);
            Controls.Add(btnEliminarCuenta);
            Controls.Add(dudDescripcion);
            Controls.Add(btnRegistrarCuenta);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(dudTipo);
            Controls.Add(dudCliente);
            Controls.Add(lblTipo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblCualCliente);
            Controls.Add(lblEstado);
            Controls.Add(lblTodasCuentas);
            Controls.Add(dgvEstadoActual);
            Controls.Add(dgvListadoCuentas);
            Name = "FormCuentaCorriente";
            Text = "FormCuentaCorriente";
            Load += FormCuentaCorriente_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvListadoCuentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoActual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListadoCuentas;
        private DataGridView dgvEstadoActual;
        private Label lblTodasCuentas;
        private Label lblEstado;
        private Label lblCualCliente;
        private Label lblDescripcion;
        private Label lblTipo;
        private DomainUpDown dudCliente;
        private DomainUpDown dudTipo;
        private Label lblMonto;
        private TextBox txtMonto;
        private Button btnRegistrarCuenta;
        private DomainUpDown dudDescripcion;
        private Button btnEliminarCuenta;
        private Button btnClientes;
        private Button btnMovimientos;
        private Label lblMensaje;
        private Label lblFecha;
        private DateTimePicker dtpFechaMov;
    }
}