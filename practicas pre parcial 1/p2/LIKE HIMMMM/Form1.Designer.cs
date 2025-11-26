namespace LIKE_HIMMMM
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
            btnConexion = new Button();
            DGV = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnVista = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // btnConexion
            // 
            btnConexion.Location = new Point(838, 78);
            btnConexion.Name = "btnConexion";
            btnConexion.Size = new Size(150, 34);
            btnConexion.TabIndex = 0;
            btnConexion.Text = "CONECTADO?";
            btnConexion.UseVisualStyleBackColor = true;
            btnConexion.Click += btnConexion_Click;
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(12, 12);
            DGV.Name = "DGV";
            DGV.RowHeadersWidth = 62;
            DGV.Size = new Size(811, 437);
            DGV.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(838, 141);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 49);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(838, 210);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 49);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(838, 283);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 49);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVista
            // 
            btnVista.Location = new Point(838, 400);
            btnVista.Name = "btnVista";
            btnVista.Size = new Size(150, 49);
            btnVista.TabIndex = 5;
            btnVista.Text = "VISTAS";
            btnVista.UseVisualStyleBackColor = true;
            btnVista.Click += btnVista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 465);
            Controls.Add(btnVista);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(DGV);
            Controls.Add(btnConexion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConexion;
        private DataGridView DGV;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnVista;
    }
}
