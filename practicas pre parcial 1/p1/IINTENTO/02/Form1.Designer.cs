namespace _02
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
            btnDesapilar = new Button();
            btnApilar = new Button();
            listApilarIda = new ListBox();
            listDesapilarVuelta = new ListBox();
            txtPueblos = new TextBox();
            SuspendLayout();
            // 
            // btnDesapilar
            // 
            btnDesapilar.Location = new Point(464, 364);
            btnDesapilar.Name = "btnDesapilar";
            btnDesapilar.Size = new Size(156, 53);
            btnDesapilar.TabIndex = 0;
            btnDesapilar.Text = "DESAPILAR";
            btnDesapilar.UseVisualStyleBackColor = true;
            btnDesapilar.Click += btnDesapilar_Click;
            // 
            // btnApilar
            // 
            btnApilar.Location = new Point(464, 272);
            btnApilar.Name = "btnApilar";
            btnApilar.Size = new Size(156, 53);
            btnApilar.TabIndex = 1;
            btnApilar.Text = "APILAR";
            btnApilar.UseVisualStyleBackColor = true;
            btnApilar.Click += btnApilar_Click;
            // 
            // listApilarIda
            // 
            listApilarIda.FormattingEnabled = true;
            listApilarIda.ItemHeight = 25;
            listApilarIda.Location = new Point(12, 63);
            listApilarIda.Name = "listApilarIda";
            listApilarIda.Size = new Size(257, 354);
            listApilarIda.TabIndex = 2;
            // 
            // listDesapilarVuelta
            // 
            listDesapilarVuelta.FormattingEnabled = true;
            listDesapilarVuelta.ItemHeight = 25;
            listDesapilarVuelta.Location = new Point(808, 63);
            listDesapilarVuelta.Name = "listDesapilarVuelta";
            listDesapilarVuelta.Size = new Size(257, 354);
            listDesapilarVuelta.TabIndex = 3;
            // 
            // txtPueblos
            // 
            txtPueblos.Location = new Point(464, 155);
            txtPueblos.Name = "txtPueblos";
            txtPueblos.Size = new Size(156, 31);
            txtPueblos.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 574);
            Controls.Add(txtPueblos);
            Controls.Add(listDesapilarVuelta);
            Controls.Add(listApilarIda);
            Controls.Add(btnApilar);
            Controls.Add(btnDesapilar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDesapilar;
        private Button btnApilar;
        private ListBox listApilarIda;
        private ListBox listDesapilarVuelta;
        private TextBox txtPueblos;
    }
}
