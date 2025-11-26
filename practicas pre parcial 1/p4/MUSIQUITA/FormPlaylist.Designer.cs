namespace MUSIQUITA
{
    partial class FormPlaylist
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
            DGVplay = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVplay).BeginInit();
            SuspendLayout();
            // 
            // DGVplay
            // 
            DGVplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVplay.Location = new Point(12, 12);
            DGVplay.Name = "DGVplay";
            DGVplay.RowHeadersWidth = 62;
            DGVplay.Size = new Size(631, 426);
            DGVplay.TabIndex = 0;
            // 
            // FormPlaylist
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 450);
            Controls.Add(DGVplay);
            Name = "FormPlaylist";
            Text = "FormPlaylist";
            Load += FormPlaylist_Load;
            ((System.ComponentModel.ISupportInitialize)DGVplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVplay;
    }
}