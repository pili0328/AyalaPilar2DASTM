namespace SeguimosPracticando
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
            btnMayores = new Button();
            btnAyala = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // btnConexion
            // 
            btnConexion.Location = new Point(25, 447);
            btnConexion.Name = "btnConexion";
            btnConexion.Size = new Size(220, 60);
            btnConexion.TabIndex = 0;
            btnConexion.Text = "CONECTADO?";
            btnConexion.UseVisualStyleBackColor = true;
            btnConexion.Click += btnConexion_Click;
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(25, 12);
            DGV.Name = "DGV";
            DGV.RowHeadersWidth = 62;
            DGV.Size = new Size(815, 429);
            DGV.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(25, 528);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(220, 60);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(327, 447);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(220, 60);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(327, 528);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(220, 60);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnMayores
            // 
            btnMayores.Location = new Point(620, 448);
            btnMayores.Name = "btnMayores";
            btnMayores.Size = new Size(220, 59);
            btnMayores.TabIndex = 5;
            btnMayores.Text = "MAYORES";
            btnMayores.UseVisualStyleBackColor = true;
            btnMayores.Click += btnMayores_Click;
            // 
            // btnAyala
            // 
            btnAyala.Location = new Point(620, 529);
            btnAyala.Name = "btnAyala";
            btnAyala.Size = new Size(220, 59);
            btnAyala.TabIndex = 6;
            btnAyala.Text = "AYALA";
            btnAyala.UseVisualStyleBackColor = true;
            btnAyala.Click += btnAyala_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 618);
            Controls.Add(btnAyala);
            Controls.Add(btnMayores);
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
        private Button btnMayores;
        private Button btnAyala;
    }
}
