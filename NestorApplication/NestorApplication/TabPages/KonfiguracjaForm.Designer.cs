namespace NestorApplication.TabPages
{
    partial class KonfiguracjaForm
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
            this.lbKonfiguracja = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKonfiguracja
            // 
            this.lbKonfiguracja.AutoSize = true;
            this.lbKonfiguracja.Location = new System.Drawing.Point(12, 9);
            this.lbKonfiguracja.Name = "lbKonfiguracja";
            this.lbKonfiguracja.Size = new System.Drawing.Size(123, 13);
            this.lbKonfiguracja.TabIndex = 1;
            this.lbKonfiguracja.Text = "Konfiguracja urządzenia:";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZapisz.Location = new System.Drawing.Point(15, 453);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 3;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // KonfiguracjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 488);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.lbKonfiguracja);
            this.Name = "KonfiguracjaForm";
            this.Text = "KonfiguracjaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKonfiguracja;
        private System.Windows.Forms.Button btnZapisz;
    }
}