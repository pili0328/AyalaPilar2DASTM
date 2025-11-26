namespace QUINCES
{
    partial class FormSi
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
            DGVsiOsi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVsiOsi).BeginInit();
            SuspendLayout();
            // 
            // DGVsiOsi
            // 
            DGVsiOsi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVsiOsi.Location = new Point(22, 12);
            DGVsiOsi.Name = "DGVsiOsi";
            DGVsiOsi.RowHeadersWidth = 62;
            DGVsiOsi.Size = new Size(979, 426);
            DGVsiOsi.TabIndex = 0;
            // 
            // FormSi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 462);
            Controls.Add(DGVsiOsi);
            Name = "FormSi";
            Text = "FormSi";
            Load += FormSi_Load;
            ((System.ComponentModel.ISupportInitialize)DGVsiOsi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVsiOsi;
    }
}