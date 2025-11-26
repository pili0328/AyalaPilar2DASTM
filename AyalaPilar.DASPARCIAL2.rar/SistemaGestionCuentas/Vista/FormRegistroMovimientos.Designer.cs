namespace Vista
{
    partial class FormRegistroMovimientos
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
            dgvMovimientos = new DataGridView();
            dgvResumen = new DataGridView();
            lblHistorial = new Label();
            lblResumen = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            SuspendLayout();
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(12, 66);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.RowHeadersWidth = 62;
            dgvMovimientos.Size = new Size(837, 515);
            dgvMovimientos.TabIndex = 0;
            // 
            // dgvResumen
            // 
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(970, 68);
            dgvResumen.Name = "dgvResumen";
            dgvResumen.RowHeadersWidth = 62;
            dgvResumen.Size = new Size(410, 440);
            dgvResumen.TabIndex = 1;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Location = new Point(12, 24);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(346, 25);
            lblHistorial.TabIndex = 2;
            lblHistorial.Text = "HISTORIAL COMPLETO DE MOVIMIENTOS";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(970, 24);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(410, 25);
            lblResumen.TabIndex = 3;
            lblResumen.Text = "Resumen: total débitos, total créditos, saldo actual";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(970, 514);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(171, 67);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormRegistroMovimientos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 593);
            Controls.Add(btnSalir);
            Controls.Add(lblResumen);
            Controls.Add(lblHistorial);
            Controls.Add(dgvResumen);
            Controls.Add(dgvMovimientos);
            Name = "FormRegistroMovimientos";
            Text = "FormRegistroMovimientos";
            Load += FormRegistroMovimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMovimientos;
        private DataGridView dgvResumen;
        private Label lblHistorial;
        private Label lblResumen;
        private Button btnSalir;
    }
}