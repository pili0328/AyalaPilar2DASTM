namespace REPASOPARCIALCRUD
{
    partial class FormMayores
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
            DGVmayores = new DataGridView();
            btnCarga = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVmayores).BeginInit();
            SuspendLayout();
            // 
            // DGVmayores
            // 
            DGVmayores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmayores.Location = new Point(28, 22);
            DGVmayores.Name = "DGVmayores";
            DGVmayores.RowHeadersWidth = 62;
            DGVmayores.Size = new Size(1108, 425);
            DGVmayores.TabIndex = 0;
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(28, 474);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(283, 41);
            btnCarga.TabIndex = 1;
            btnCarga.Text = "CARGAR DATOS";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(853, 474);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(283, 41);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMayores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 542);
            Controls.Add(btnSalir);
            Controls.Add(btnCarga);
            Controls.Add(DGVmayores);
            Name = "FormMayores";
            Text = "FormMayores";
            ((System.ComponentModel.ISupportInitialize)DGVmayores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVmayores;
        private Button btnCarga;
        private Button btnSalir;
    }
}