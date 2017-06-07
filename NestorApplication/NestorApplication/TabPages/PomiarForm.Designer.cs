namespace NestorApplication.TabPages
{
    partial class PomiarForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPomiar = new System.Windows.Forms.Button();
            this.cbKlient = new System.Windows.Forms.ComboBox();
            this.cbProdukt = new System.Windows.Forms.ComboBox();
            this.cbSprezyna = new System.Windows.Forms.ComboBox();
            this.cbDrut = new System.Windows.Forms.ComboBox();
            this.dgvDanePomiaru = new System.Windows.Forms.DataGridView();
            this.próbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siłaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugięcieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danePomiaruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRaport = new System.Windows.Forms.Button();
            this.pomiarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbRostawPunktowPomiarowych = new System.Windows.Forms.Label();
            this.lbJednostka = new System.Windows.Forms.Label();
            this.tbRozstawPunktowPomiarowych = new System.Windows.Forms.TextBox();
            this.tbJednostka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIloscPunktowPomiarowych = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanePomiaru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danePomiaruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomiarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Klient:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(262, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produkt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(530, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sprężyna:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(803, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Drut:";
            // 
            // btnPomiar
            // 
            this.btnPomiar.Location = new System.Drawing.Point(15, 70);
            this.btnPomiar.Name = "btnPomiar";
            this.btnPomiar.Size = new System.Drawing.Size(75, 23);
            this.btnPomiar.TabIndex = 7;
            this.btnPomiar.Text = "Pomiar";
            this.btnPomiar.UseVisualStyleBackColor = true;
            this.btnPomiar.Click += new System.EventHandler(this.btnPomiar_Click);
            // 
            // cbKlient
            // 
            this.cbKlient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKlient.FormattingEnabled = true;
            this.cbKlient.Location = new System.Drawing.Point(48, 12);
            this.cbKlient.Name = "cbKlient";
            this.cbKlient.Size = new System.Drawing.Size(200, 21);
            this.cbKlient.TabIndex = 8;
            // 
            // cbProdukt
            // 
            this.cbProdukt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdukt.FormattingEnabled = true;
            this.cbProdukt.Location = new System.Drawing.Point(309, 12);
            this.cbProdukt.Name = "cbProdukt";
            this.cbProdukt.Size = new System.Drawing.Size(200, 21);
            this.cbProdukt.TabIndex = 9;
            // 
            // cbSprezyna
            // 
            this.cbSprezyna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSprezyna.FormattingEnabled = true;
            this.cbSprezyna.Location = new System.Drawing.Point(584, 12);
            this.cbSprezyna.Name = "cbSprezyna";
            this.cbSprezyna.Size = new System.Drawing.Size(200, 21);
            this.cbSprezyna.TabIndex = 10;
            // 
            // cbDrut
            // 
            this.cbDrut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrut.FormattingEnabled = true;
            this.cbDrut.Location = new System.Drawing.Point(834, 12);
            this.cbDrut.Name = "cbDrut";
            this.cbDrut.Size = new System.Drawing.Size(200, 21);
            this.cbDrut.TabIndex = 11;
            // 
            // dgvDanePomiaru
            // 
            this.dgvDanePomiaru.AllowUserToAddRows = false;
            this.dgvDanePomiaru.AllowUserToDeleteRows = false;
            this.dgvDanePomiaru.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDanePomiaru.AutoGenerateColumns = false;
            this.dgvDanePomiaru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanePomiaru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.próbaDataGridViewTextBoxColumn,
            this.siłaDataGridViewTextBoxColumn,
            this.ugięcieDataGridViewTextBoxColumn,
            this.Procent});
            this.dgvDanePomiaru.DataSource = this.danePomiaruBindingSource;
            this.dgvDanePomiaru.Location = new System.Drawing.Point(15, 99);
            this.dgvDanePomiaru.Name = "dgvDanePomiaru";
            this.dgvDanePomiaru.ReadOnly = true;
            this.dgvDanePomiaru.Size = new System.Drawing.Size(637, 432);
            this.dgvDanePomiaru.TabIndex = 12;
            // 
            // próbaDataGridViewTextBoxColumn
            // 
            this.próbaDataGridViewTextBoxColumn.DataPropertyName = "Próba";
            this.próbaDataGridViewTextBoxColumn.HeaderText = "Próba";
            this.próbaDataGridViewTextBoxColumn.Name = "próbaDataGridViewTextBoxColumn";
            this.próbaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siłaDataGridViewTextBoxColumn
            // 
            this.siłaDataGridViewTextBoxColumn.DataPropertyName = "Siła";
            this.siłaDataGridViewTextBoxColumn.HeaderText = "Siła";
            this.siłaDataGridViewTextBoxColumn.Name = "siłaDataGridViewTextBoxColumn";
            this.siłaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ugięcieDataGridViewTextBoxColumn
            // 
            this.ugięcieDataGridViewTextBoxColumn.DataPropertyName = "Ugięcie";
            this.ugięcieDataGridViewTextBoxColumn.HeaderText = "Ugięcie";
            this.ugięcieDataGridViewTextBoxColumn.Name = "ugięcieDataGridViewTextBoxColumn";
            this.ugięcieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Procent
            // 
            this.Procent.DataPropertyName = "Próba";
            this.Procent.HeaderText = "Procentowa Wartość Ugięcia";
            this.Procent.Name = "Procent";
            this.Procent.ReadOnly = true;
            // 
            // danePomiaruBindingSource
            // 
            this.danePomiaruBindingSource.DataSource = typeof(NestorRepository.Entities.DanePomiaru);
            // 
            // btnRaport
            // 
            this.btnRaport.Location = new System.Drawing.Point(96, 70);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(75, 23);
            this.btnRaport.TabIndex = 13;
            this.btnRaport.Text = "Raport";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // pomiarBindingSource
            // 
            this.pomiarBindingSource.DataSource = typeof(NestorRepository.Entities.Pomiar);
            // 
            // lbRostawPunktowPomiarowych
            // 
            this.lbRostawPunktowPomiarowych.AutoSize = true;
            this.lbRostawPunktowPomiarowych.BackColor = System.Drawing.Color.White;
            this.lbRostawPunktowPomiarowych.Location = new System.Drawing.Point(206, 44);
            this.lbRostawPunktowPomiarowych.Name = "lbRostawPunktowPomiarowych";
            this.lbRostawPunktowPomiarowych.Size = new System.Drawing.Size(160, 13);
            this.lbRostawPunktowPomiarowych.TabIndex = 14;
            this.lbRostawPunktowPomiarowych.Text = "Rozstaw punktów pomiarowych:";
            // 
            // lbJednostka
            // 
            this.lbJednostka.AutoSize = true;
            this.lbJednostka.BackColor = System.Drawing.Color.White;
            this.lbJednostka.Location = new System.Drawing.Point(424, 44);
            this.lbJednostka.Name = "lbJednostka";
            this.lbJednostka.Size = new System.Drawing.Size(59, 13);
            this.lbJednostka.TabIndex = 15;
            this.lbJednostka.Text = "Jednostka:";
            // 
            // tbRozstawPunktowPomiarowych
            // 
            this.tbRozstawPunktowPomiarowych.Location = new System.Drawing.Point(372, 41);
            this.tbRozstawPunktowPomiarowych.Name = "tbRozstawPunktowPomiarowych";
            this.tbRozstawPunktowPomiarowych.Size = new System.Drawing.Size(30, 20);
            this.tbRozstawPunktowPomiarowych.TabIndex = 16;
            this.tbRozstawPunktowPomiarowych.Text = "20";
            // 
            // tbJednostka
            // 
            this.tbJednostka.Location = new System.Drawing.Point(489, 41);
            this.tbJednostka.Name = "tbJednostka";
            this.tbJednostka.Size = new System.Drawing.Size(40, 20);
            this.tbJednostka.TabIndex = 17;
            this.tbJednostka.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ilość punktów pomiarowych:";
            // 
            // tbIloscPunktowPomiarowych
            // 
            this.tbIloscPunktowPomiarowych.Location = new System.Drawing.Point(159, 41);
            this.tbIloscPunktowPomiarowych.Name = "tbIloscPunktowPomiarowych";
            this.tbIloscPunktowPomiarowych.Size = new System.Drawing.Size(27, 20);
            this.tbIloscPunktowPomiarowych.TabIndex = 19;
            this.tbIloscPunktowPomiarowych.Text = "20";
            // 
            // PomiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.tbIloscPunktowPomiarowych);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbJednostka);
            this.Controls.Add(this.tbRozstawPunktowPomiarowych);
            this.Controls.Add(this.lbJednostka);
            this.Controls.Add(this.lbRostawPunktowPomiarowych);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.dgvDanePomiaru);
            this.Controls.Add(this.cbDrut);
            this.Controls.Add(this.cbSprezyna);
            this.Controls.Add(this.cbProdukt);
            this.Controls.Add(this.cbKlient);
            this.Controls.Add(this.btnPomiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PomiarForm";
            this.Text = "PomiarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanePomiaru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danePomiaruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomiarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPomiar;
        private System.Windows.Forms.ComboBox cbKlient;
        private System.Windows.Forms.ComboBox cbProdukt;
        private System.Windows.Forms.ComboBox cbSprezyna;
        private System.Windows.Forms.ComboBox cbDrut;
        private System.Windows.Forms.DataGridView dgvDanePomiaru;
        private System.Windows.Forms.Button btnRaport;
        private System.Windows.Forms.BindingSource pomiarBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn próbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siłaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugięcieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procent;
        private System.Windows.Forms.BindingSource danePomiaruBindingSource;
        private System.Windows.Forms.Label lbRostawPunktowPomiarowych;
        private System.Windows.Forms.Label lbJednostka;
        private System.Windows.Forms.TextBox tbRozstawPunktowPomiarowych;
        private System.Windows.Forms.TextBox tbJednostka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIloscPunktowPomiarowych;
    }
}