namespace OUTLANDER
{
    partial class FormTemporadas
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
            DGVtemporadas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVtemporadas).BeginInit();
            SuspendLayout();
            // 
            // DGVtemporadas
            // 
            DGVtemporadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVtemporadas.Location = new Point(12, 12);
            DGVtemporadas.Name = "DGVtemporadas";
            DGVtemporadas.RowHeadersWidth = 62;
            DGVtemporadas.Size = new Size(751, 426);
            DGVtemporadas.TabIndex = 0;
            // 
            // FormTemporadas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(DGVtemporadas);
            Name = "FormTemporadas";
            Text = "FormTemporadas";
            Load += FormTemporadas_Load;
            ((System.ComponentModel.ISupportInitialize)DGVtemporadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVtemporadas;
    }
}