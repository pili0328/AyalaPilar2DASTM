namespace MUSIQUITA
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
            btnDuracion = new Button();
            btnLista = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(12, 12);
            DGV.Name = "DGV";
            DGV.RowHeadersWidth = 62;
            DGV.Size = new Size(690, 416);
            DGV.TabIndex = 0;
            // 
            // btnConexion
            // 
            btnConexion.Location = new Point(12, 434);
            btnConexion.Name = "btnConexion";
            btnConexion.Size = new Size(232, 57);
            btnConexion.TabIndex = 1;
            btnConexion.Text = "CONEXION";
            btnConexion.UseVisualStyleBackColor = true;
            btnConexion.Click += btnConexion_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 521);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(232, 57);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(250, 434);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(232, 57);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(250, 521);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(232, 57);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnDuracion
            // 
            btnDuracion.Location = new Point(488, 434);
            btnDuracion.Name = "btnDuracion";
            btnDuracion.Size = new Size(232, 57);
            btnDuracion.TabIndex = 5;
            btnDuracion.Text = "DURACION";
            btnDuracion.UseVisualStyleBackColor = true;
            // 
            // btnLista
            // 
            btnLista.Location = new Point(488, 521);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(232, 57);
            btnLista.TabIndex = 6;
            btnLista.Text = "EN LA LISTA?";
            btnLista.UseVisualStyleBackColor = true;
            btnLista.Click += btnLista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 628);
            Controls.Add(btnLista);
            Controls.Add(btnDuracion);
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
        private Button btnDuracion;
        private Button btnLista;
    }
}
