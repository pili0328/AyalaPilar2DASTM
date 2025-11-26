namespace TP01CRUDSQL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.conectadoBTN = new System.Windows.Forms.Button();
            this.AgregarBTN = new System.Windows.Forms.Button();
            this.EditarBTN = new System.Windows.Forms.Button();
            this.BorrarBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(24, 38);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.RowHeadersWidth = 62;
            this.DGV1.RowTemplate.Height = 28;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(747, 553);
            this.DGV1.TabIndex = 0;
            // 
            // conectadoBTN
            // 
            this.conectadoBTN.Location = new System.Drawing.Point(796, 115);
            this.conectadoBTN.Name = "conectadoBTN";
            this.conectadoBTN.Size = new System.Drawing.Size(148, 41);
            this.conectadoBTN.TabIndex = 1;
            this.conectadoBTN.Text = "CONECTADO?";
            this.conectadoBTN.UseVisualStyleBackColor = true;
            this.conectadoBTN.Click += new System.EventHandler(this.conectadoBTN_Click);
            // 
            // AgregarBTN
            // 
            this.AgregarBTN.Location = new System.Drawing.Point(796, 178);
            this.AgregarBTN.Name = "AgregarBTN";
            this.AgregarBTN.Size = new System.Drawing.Size(148, 41);
            this.AgregarBTN.TabIndex = 2;
            this.AgregarBTN.Text = "AGREGAR";
            this.AgregarBTN.UseVisualStyleBackColor = true;
            this.AgregarBTN.Click += new System.EventHandler(this.AgregarBTN_Click);
            // 
            // EditarBTN
            // 
            this.EditarBTN.Location = new System.Drawing.Point(796, 244);
            this.EditarBTN.Name = "EditarBTN";
            this.EditarBTN.Size = new System.Drawing.Size(148, 41);
            this.EditarBTN.TabIndex = 3;
            this.EditarBTN.Text = "EDITAR";
            this.EditarBTN.UseVisualStyleBackColor = true;
            this.EditarBTN.Click += new System.EventHandler(this.EditarBTN_Click);
            // 
            // BorrarBTN
            // 
            this.BorrarBTN.Location = new System.Drawing.Point(796, 312);
            this.BorrarBTN.Name = "BorrarBTN";
            this.BorrarBTN.Size = new System.Drawing.Size(148, 41);
            this.BorrarBTN.TabIndex = 4;
            this.BorrarBTN.Text = "ELIMINAR";
            this.BorrarBTN.UseVisualStyleBackColor = true;
            this.BorrarBTN.Click += new System.EventHandler(this.BorrarBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 624);
            this.Controls.Add(this.BorrarBTN);
            this.Controls.Add(this.EditarBTN);
            this.Controls.Add(this.AgregarBTN);
            this.Controls.Add(this.conectadoBTN);
            this.Controls.Add(this.DGV1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Button conectadoBTN;
        private System.Windows.Forms.Button AgregarBTN;
        private System.Windows.Forms.Button EditarBTN;
        private System.Windows.Forms.Button BorrarBTN;
    }
}

