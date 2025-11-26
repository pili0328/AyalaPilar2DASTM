namespace SeguimosPracticando
{
    partial class FormAyala
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
            DGVayala = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVayala).BeginInit();
            SuspendLayout();
            // 
            // DGVayala
            // 
            DGVayala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVayala.Location = new Point(36, 33);
            DGVayala.Name = "DGVayala";
            DGVayala.RowHeadersWidth = 62;
            DGVayala.Size = new Size(735, 389);
            DGVayala.TabIndex = 0;
            // 
            // FormAyala
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DGVayala);
            Name = "FormAyala";
            Text = "FormAyala";
            Load += FormAyala_Load;
            ((System.ComponentModel.ISupportInitialize)DGVayala).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGVayala;
    }
}