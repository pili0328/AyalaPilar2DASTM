namespace OUTLANDER
{
    partial class FormFechaEstreno
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
            DGVestreno = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVestreno).BeginInit();
            SuspendLayout();
            // 
            // DGVestreno
            // 
            DGVestreno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVestreno.Location = new Point(12, 12);
            DGVestreno.Name = "DGVestreno";
            DGVestreno.RowHeadersWidth = 62;
            DGVestreno.Size = new Size(710, 426);
            DGVestreno.TabIndex = 0;
            // 
            // FormFechaEstreno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(DGVestreno);
            Name = "FormFechaEstreno";
            Text = "FormFechaEstreno";
            Load += FormFechaEstreno_Load;
            ((System.ComponentModel.ISupportInitialize)DGVestreno).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVestreno;
    }
}