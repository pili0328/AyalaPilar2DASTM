namespace SeguimosPracticando
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
            ((System.ComponentModel.ISupportInitialize)DGVmayores).BeginInit();
            SuspendLayout();
            // 
            // DGVmayores
            // 
            DGVmayores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmayores.Location = new Point(12, 12);
            DGVmayores.Name = "DGVmayores";
            DGVmayores.RowHeadersWidth = 62;
            DGVmayores.Size = new Size(884, 542);
            DGVmayores.TabIndex = 0;
            // 
            // FormMayores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 566);
            Controls.Add(DGVmayores);
            Name = "FormMayores";
            Text = "FormMayores";
            Load += FormMayores_Load;
            ((System.ComponentModel.ISupportInitialize)DGVmayores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVmayores;
    }
}