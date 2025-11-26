namespace REPASOPARCIALCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV = new DataGridView();
            btnConexion = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCuota = new Button();
            btnMayores = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(26, 34);
            DGV.Name = "DGV";
            DGV.RowHeadersWidth = 62;
            DGV.Size = new Size(1116, 497);
            DGV.TabIndex = 0;
            // 
            // btnConexion
            // 
            btnConexion.Location = new Point(1203, 63);
            btnConexion.Name = "btnConexion";
            btnConexion.Size = new Size(135, 34);
            btnConexion.TabIndex = 1;
            btnConexion.Text = "CONEXION";
            btnConexion.UseVisualStyleBackColor = true;
            btnConexion.Click += btnConexion_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1199, 126);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1199, 190);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(139, 34);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1203, 256);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(135, 34);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCuota
            // 
            btnCuota.Location = new Point(1203, 347);
            btnCuota.Name = "btnCuota";
            btnCuota.Size = new Size(135, 69);
            btnCuota.TabIndex = 5;
            btnCuota.Text = "CUOTA AL DIA";
            btnCuota.UseVisualStyleBackColor = true;
            btnCuota.Click += btnCuota_Click;
            // 
            // btnMayores
            // 
            btnMayores.Location = new Point(1203, 434);
            btnMayores.Name = "btnMayores";
            btnMayores.Size = new Size(135, 69);
            btnMayores.TabIndex = 6;
            btnMayores.Text = "MAYORES";
            btnMayores.UseVisualStyleBackColor = true;
            btnMayores.Click += btnMayores_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 561);
            Controls.Add(btnMayores);
            Controls.Add(btnCuota);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnConexion);
            Controls.Add(DGV);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV;
        private Button btnConexion;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnCuota;
        private Button btnMayores;
    }
}
