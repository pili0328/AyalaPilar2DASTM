namespace LIKE_HIMMMM
{
    partial class FormVistas
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
            DGVver = new DataGridView();
            btnCargarDato = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVver).BeginInit();
            SuspendLayout();
            // 
            // DGVver
            // 
            DGVver.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVver.Location = new Point(24, 27);
            DGVver.Name = "DGVver";
            DGVver.RowHeadersWidth = 62;
            DGVver.Size = new Size(952, 440);
            DGVver.TabIndex = 0;
            // 
            // btnCargarDato
            // 
            btnCargarDato.Location = new Point(1012, 206);
            btnCargarDato.Name = "btnCargarDato";
            btnCargarDato.Size = new Size(170, 86);
            btnCargarDato.TabIndex = 1;
            btnCargarDato.Text = "CARGAR";
            btnCargarDato.UseVisualStyleBackColor = true;
            btnCargarDato.Click += btnCargarDato_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1031, 342);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(118, 63);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormVistas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 520);
            Controls.Add(btnCerrar);
            Controls.Add(btnCargarDato);
            Controls.Add(DGVver);
            Name = "FormVistas";
            Text = "FormVistas";
            ((System.ComponentModel.ISupportInitialize)DGVver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVver;
        private Button btnCargarDato;
        private Button btnCerrar;
    }
}