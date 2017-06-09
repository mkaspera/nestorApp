namespace NestorApplication
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpKonfiguracja = new System.Windows.Forms.TabPage();
            this.tpKlienci = new System.Windows.Forms.TabPage();
            this.tpParametryProduktow = new System.Windows.Forms.TabPage();
            this.tpParametrySprezyn = new System.Windows.Forms.TabPage();
            this.tpParametryDrutu = new System.Windows.Forms.TabPage();
            this.tpPomiar = new System.Windows.Forms.TabPage();
            this.tpRaport = new System.Windows.Forms.TabPage();
            this.tpListaPomiarow = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpKonfiguracja);
            this.tabControl.Controls.Add(this.tpKlienci);
            this.tabControl.Controls.Add(this.tpParametryProduktow);
            this.tabControl.Controls.Add(this.tpParametrySprezyn);
            this.tabControl.Controls.Add(this.tpParametryDrutu);
            this.tabControl.Controls.Add(this.tpPomiar);
            this.tabControl.Controls.Add(this.tpRaport);
            this.tabControl.Controls.Add(this.tpListaPomiarow);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1084, 661);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpKonfiguracja
            // 
            this.tpKonfiguracja.Location = new System.Drawing.Point(4, 22);
            this.tpKonfiguracja.Name = "tpKonfiguracja";
            this.tpKonfiguracja.Size = new System.Drawing.Size(1076, 635);
            this.tpKonfiguracja.TabIndex = 0;
            this.tpKonfiguracja.Text = "Konfiguracja";
            this.tpKonfiguracja.UseVisualStyleBackColor = true;
            // 
            // tpKlienci
            // 
            this.tpKlienci.Location = new System.Drawing.Point(4, 22);
            this.tpKlienci.Name = "tpKlienci";
            this.tpKlienci.Size = new System.Drawing.Size(1076, 635);
            this.tpKlienci.TabIndex = 1;
            this.tpKlienci.Text = "Klienci";
            this.tpKlienci.UseVisualStyleBackColor = true;
            // 
            // tpParametryProduktow
            // 
            this.tpParametryProduktow.Location = new System.Drawing.Point(4, 22);
            this.tpParametryProduktow.Name = "tpParametryProduktow";
            this.tpParametryProduktow.Size = new System.Drawing.Size(1076, 635);
            this.tpParametryProduktow.TabIndex = 2;
            this.tpParametryProduktow.Text = "Parametry produktów";
            this.tpParametryProduktow.UseVisualStyleBackColor = true;
            // 
            // tpParametrySprezyn
            // 
            this.tpParametrySprezyn.Location = new System.Drawing.Point(4, 22);
            this.tpParametrySprezyn.Name = "tpParametrySprezyn";
            this.tpParametrySprezyn.Size = new System.Drawing.Size(1076, 635);
            this.tpParametrySprezyn.TabIndex = 3;
            this.tpParametrySprezyn.Text = "Parametry sprężyn";
            this.tpParametrySprezyn.UseVisualStyleBackColor = true;
            // 
            // tpParametryDrutu
            // 
            this.tpParametryDrutu.Location = new System.Drawing.Point(4, 22);
            this.tpParametryDrutu.Name = "tpParametryDrutu";
            this.tpParametryDrutu.Size = new System.Drawing.Size(1076, 635);
            this.tpParametryDrutu.TabIndex = 4;
            this.tpParametryDrutu.Text = "Parametry drutu";
            this.tpParametryDrutu.UseVisualStyleBackColor = true;
            // 
            // tpPomiar
            // 
            this.tpPomiar.Location = new System.Drawing.Point(4, 22);
            this.tpPomiar.Name = "tpPomiar";
            this.tpPomiar.Size = new System.Drawing.Size(1076, 635);
            this.tpPomiar.TabIndex = 5;
            this.tpPomiar.Text = "Pomiar";
            this.tpPomiar.UseVisualStyleBackColor = true;
            // 
            // tpRaport
            // 
            this.tpRaport.Location = new System.Drawing.Point(4, 22);
            this.tpRaport.Name = "tpRaport";
            this.tpRaport.Size = new System.Drawing.Size(1076, 635);
            this.tpRaport.TabIndex = 6;
            this.tpRaport.Text = "Raport";
            this.tpRaport.UseVisualStyleBackColor = true;
            // 
            // tpListaPomiarow
            // 
            this.tpListaPomiarow.Location = new System.Drawing.Point(4, 22);
            this.tpListaPomiarow.Name = "tpListaPomiarow";
            this.tpListaPomiarow.Size = new System.Drawing.Size(1076, 635);
            this.tpListaPomiarow.TabIndex = 7;
            this.tpListaPomiarow.Text = "Lista pomiarów";
            this.tpListaPomiarow.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nestor";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpKonfiguracja;
        private System.Windows.Forms.TabPage tpKlienci;
        private System.Windows.Forms.TabPage tpParametryProduktow;
        private System.Windows.Forms.TabPage tpParametrySprezyn;
        private System.Windows.Forms.TabPage tpParametryDrutu;
        private System.Windows.Forms.TabPage tpPomiar;
        private System.Windows.Forms.TabPage tpRaport;
        private System.Windows.Forms.TabPage tpListaPomiarow;
    }
}

