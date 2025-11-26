namespace _2
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblDato = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCAMBIAR = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(25, 67);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(258, 244);
            this.listBox.TabIndex = 0;
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(369, 96);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(61, 20);
            this.lblDato.TabIndex = 1;
            this.lblDato.Text = "DATO: ";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(490, 96);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 26);
            this.txtDato.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(313, 190);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 50);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCAMBIAR
            // 
            this.btnCAMBIAR.Location = new System.Drawing.Point(456, 190);
            this.btnCAMBIAR.Name = "btnCAMBIAR";
            this.btnCAMBIAR.Size = new System.Drawing.Size(134, 50);
            this.btnCAMBIAR.TabIndex = 4;
            this.btnCAMBIAR.Text = "CAMBIAR";
            this.btnCAMBIAR.UseVisualStyleBackColor = true;
            this.btnCAMBIAR.Click += new System.EventHandler(this.btnCAMBIAR_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(373, 263);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(126, 48);
            this.btnFinal.TabIndex = 5;
            this.btnFinal.Text = "FINAL";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 587);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnCAMBIAR);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCAMBIAR;
        private System.Windows.Forms.Button btnFinal;
    }
}

