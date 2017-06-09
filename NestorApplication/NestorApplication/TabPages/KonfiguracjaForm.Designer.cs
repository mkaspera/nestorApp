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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPortCOM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBaudrate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSkalaTensometr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSkalaDroga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCzuloscStart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDrogaStop = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTimeoutStop = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port COM:";
            // 
            // tbPortCOM
            // 
            this.tbPortCOM.Location = new System.Drawing.Point(124, 38);
            this.tbPortCOM.Name = "tbPortCOM";
            this.tbPortCOM.Size = new System.Drawing.Size(64, 20);
            this.tbPortCOM.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baudrate:";
            // 
            // tbBaudrate
            // 
            this.tbBaudrate.Location = new System.Drawing.Point(124, 67);
            this.tbBaudrate.Name = "tbBaudrate";
            this.tbBaudrate.Size = new System.Drawing.Size(64, 20);
            this.tbBaudrate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Skala tensometr:";
            // 
            // tbSkalaTensometr
            // 
            this.tbSkalaTensometr.Location = new System.Drawing.Point(124, 97);
            this.tbSkalaTensometr.Name = "tbSkalaTensometr";
            this.tbSkalaTensometr.Size = new System.Drawing.Size(64, 20);
            this.tbSkalaTensometr.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Skala droga:";
            // 
            // tbSkalaDroga
            // 
            this.tbSkalaDroga.Location = new System.Drawing.Point(124, 126);
            this.tbSkalaDroga.Name = "tbSkalaDroga";
            this.tbSkalaDroga.Size = new System.Drawing.Size(64, 20);
            this.tbSkalaDroga.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "(dzielnik do wyliczenia kilogramów)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "(1 mm = x impulsów)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Czułość:";
            // 
            // tbCzuloscStart
            // 
            this.tbCzuloscStart.Location = new System.Drawing.Point(124, 156);
            this.tbCzuloscStart.Name = "tbCzuloscStart";
            this.tbCzuloscStart.Size = new System.Drawing.Size(64, 20);
            this.tbCzuloscStart.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "(start po zdetektowaniu siły)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Droga:";
            // 
            // tbDrogaStop
            // 
            this.tbDrogaStop.Location = new System.Drawing.Point(124, 185);
            this.tbDrogaStop.Name = "tbDrogaStop";
            this.tbDrogaStop.Size = new System.Drawing.Size(64, 20);
            this.tbDrogaStop.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "(stop po zdetektowaniu, że droga się nie zmienia)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Timeout:";
            // 
            // tbTimeoutStop
            // 
            this.tbTimeoutStop.Location = new System.Drawing.Point(124, 215);
            this.tbTimeoutStop.Name = "tbTimeoutStop";
            this.tbTimeoutStop.Size = new System.Drawing.Size(64, 20);
            this.tbTimeoutStop.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "(stop po zdetektowaniu, że droga się nie zmienia)";
            // 
            // KonfiguracjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 488);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbTimeoutStop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDrogaStop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbCzuloscStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSkalaDroga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSkalaTensometr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBaudrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPortCOM);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPortCOM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBaudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSkalaTensometr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSkalaDroga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCzuloscStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDrogaStop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTimeoutStop;
        private System.Windows.Forms.Label label12;
    }
}