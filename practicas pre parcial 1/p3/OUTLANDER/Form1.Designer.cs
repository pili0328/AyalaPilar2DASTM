namespace OUTLANDER
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
            btnELiminar = new Button();
            btnTemporadas = new Button();
            btnEstreno = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(12, 12);
            DGV.Name = "DGV";
            DGV.RowHeadersWidth = 62;
            DGV.Size = new Size(665, 400);
            DGV.TabIndex = 0;
            // 
            // btnConexion
            // 
            btnConexion.Location = new Point(12, 418);
            btnConexion.Name = "btnConexion";
            btnConexion.Size = new Size(223, 72);
            btnConexion.TabIndex = 1;
            btnConexion.Text = "CONEXION?";
            btnConexion.UseVisualStyleBackColor = true;
            btnConexion.Click += btnConexion_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 514);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(223, 72);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(241, 418);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(223, 72);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnELiminar
            // 
            btnELiminar.Location = new Point(241, 514);
            btnELiminar.Name = "btnELiminar";
            btnELiminar.Size = new Size(223, 72);
            btnELiminar.TabIndex = 4;
            btnELiminar.Text = "ELIMINAR";
            btnELiminar.UseVisualStyleBackColor = true;
            btnELiminar.Click += btnELiminar_Click;
            // 
            // btnTemporadas
            // 
            btnTemporadas.Location = new Point(470, 418);
            btnTemporadas.Name = "btnTemporadas";
            btnTemporadas.Size = new Size(223, 72);
            btnTemporadas.TabIndex = 5;
            btnTemporadas.Text = "TEMPORADAS";
            btnTemporadas.UseVisualStyleBackColor = true;
            btnTemporadas.Click += btnTemporadas_Click;
            // 
            // btnEstreno
            // 
            btnEstreno.Location = new Point(470, 514);
            btnEstreno.Name = "btnEstreno";
            btnEstreno.Size = new Size(223, 72);
            btnEstreno.TabIndex = 6;
            btnEstreno.Text = "ESTRENO";
            btnEstreno.UseVisualStyleBackColor = true;
            btnEstreno.Click += btnEstreno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 624);
            Controls.Add(btnEstreno);
            Controls.Add(btnTemporadas);
            Controls.Add(btnELiminar);
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
        private Button btnELiminar;
        private Button btnTemporadas;
        private Button btnEstreno;
    }
}
