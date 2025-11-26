namespace REPASOPARCIALCRUD
{
    partial class FormCuotaAlDia
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
            DGVcuota = new DataGridView();
            btnCerrar = new Button();
            btnCargarDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVcuota).BeginInit();
            SuspendLayout();
            // 
            // DGVcuota
            // 
            DGVcuota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVcuota.Location = new Point(32, 34);
            DGVcuota.Name = "DGVcuota";
            DGVcuota.RowHeadersWidth = 62;
            DGVcuota.Size = new Size(1092, 372);
            DGVcuota.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(953, 441);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(201, 34);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Location = new Point(32, 441);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(201, 34);
            btnCargarDatos.TabIndex = 2;
            btnCargarDatos.Text = "CARGAR DATOS";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // FormCuotaAlDia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 511);
            Controls.Add(btnCargarDatos);
            Controls.Add(btnCerrar);
            Controls.Add(DGVcuota);
            Name = "FormCuotaAlDia";
            Text = "FormCuotaAlDia";
            ((System.ComponentModel.ISupportInitialize)DGVcuota).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVcuota;
        private Button btnCerrar;
        private Button btnCargarDatos;
    }
}