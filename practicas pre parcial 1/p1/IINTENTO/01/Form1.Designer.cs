namespace _01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsApilar = new ListBox();
            lsDesapilar = new ListBox();
            txtDato = new TextBox();
            btnApilar = new Button();
            btnDesapilar = new Button();
            lblDato = new Label();
            SuspendLayout();
            // 
            // lsApilar
            // 
            lsApilar.FormattingEnabled = true;
            lsApilar.ItemHeight = 25;
            lsApilar.Location = new Point(55, 39);
            lsApilar.Name = "lsApilar";
            lsApilar.Size = new Size(252, 254);
            lsApilar.TabIndex = 0;
            // 
            // lsDesapilar
            // 
            lsDesapilar.FormattingEnabled = true;
            lsDesapilar.ItemHeight = 25;
            lsDesapilar.Location = new Point(55, 311);
            lsDesapilar.Name = "lsDesapilar";
            lsDesapilar.Size = new Size(252, 254);
            lsDesapilar.TabIndex = 1;
            // 
            // txtDato
            // 
            txtDato.Location = new Point(440, 143);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(186, 31);
            txtDato.TabIndex = 2;
            // 
            // btnApilar
            // 
            btnApilar.Location = new Point(313, 228);
            btnApilar.Name = "btnApilar";
            btnApilar.Size = new Size(165, 65);
            btnApilar.TabIndex = 3;
            btnApilar.Text = "APILAR";
            btnApilar.UseVisualStyleBackColor = true;
            btnApilar.Click += btnApilar_Click;
            // 
            // btnDesapilar
            // 
            btnDesapilar.Location = new Point(313, 311);
            btnDesapilar.Name = "btnDesapilar";
            btnDesapilar.Size = new Size(165, 65);
            btnDesapilar.TabIndex = 4;
            btnDesapilar.Text = "DESAPILAR";
            btnDesapilar.UseVisualStyleBackColor = true;
            btnDesapilar.Click += btnDesapilar_Click;
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(440, 105);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(62, 25);
            lblDato.TabIndex = 5;
            lblDato.Text = "DATO:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 599);
            Controls.Add(lblDato);
            Controls.Add(btnDesapilar);
            Controls.Add(btnApilar);
            Controls.Add(txtDato);
            Controls.Add(lsDesapilar);
            Controls.Add(lsApilar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lsApilar;
        private ListBox lsDesapilar;
        private TextBox txtDato;
        private Button btnApilar;
        private Button btnDesapilar;
        private Label lblDato;
    }
}
