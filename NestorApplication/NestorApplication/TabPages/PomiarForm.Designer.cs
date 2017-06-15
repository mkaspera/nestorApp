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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKlient = new System.Windows.Forms.ComboBox();
            this.cbProdukt = new System.Windows.Forms.ComboBox();
            this.cbSprezyna = new System.Windows.Forms.ComboBox();
            this.cbDrut = new System.Windows.Forms.ComboBox();
            this.dgvDanePomiaru = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIloscPunktowPomiarowych = new System.Windows.Forms.TextBox();
            this.btnZeruj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.textBoxNacisk = new System.Windows.Forms.TextBox();
            this.textBoxDroga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPomiarInfo = new System.Windows.Forms.Label();
            this.btnWydruk = new System.Windows.Forms.Button();
            this.danePomiaruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pomiarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.próbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siłaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugięcieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanePomiaru)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dgvDanePomiaru.Location = new System.Drawing.Point(15, 125);
            this.dgvDanePomiaru.Name = "dgvDanePomiaru";
            this.dgvDanePomiaru.ReadOnly = true;
            this.dgvDanePomiaru.Size = new System.Drawing.Size(448, 406);
            this.dgvDanePomiaru.TabIndex = 12;
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
            // btnZeruj
            // 
            this.btnZeruj.Location = new System.Drawing.Point(15, 70);
            this.btnZeruj.Name = "btnZeruj";
            this.btnZeruj.Size = new System.Drawing.Size(75, 23);
            this.btnZeruj.TabIndex = 20;
            this.btnZeruj.Text = "Zeruj";
            this.btnZeruj.UseVisualStyleBackColor = true;
            this.btnZeruj.Click += new System.EventHandler(this.btnZeruj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(177, 70);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(87, 23);
            this.btnZapisz.TabIndex = 21;
            this.btnZapisz.Text = "Zapisz pomiar";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // textBoxNacisk
            // 
            this.textBoxNacisk.AcceptsReturn = true;
            this.textBoxNacisk.Location = new System.Drawing.Point(100, 30);
            this.textBoxNacisk.Name = "textBoxNacisk";
            this.textBoxNacisk.Size = new System.Drawing.Size(100, 20);
            this.textBoxNacisk.TabIndex = 22;
            // 
            // textBoxDroga
            // 
            this.textBoxDroga.AcceptsReturn = true;
            this.textBoxDroga.Location = new System.Drawing.Point(100, 63);
            this.textBoxDroga.Name = "textBoxDroga";
            this.textBoxDroga.Size = new System.Drawing.Size(100, 20);
            this.textBoxDroga.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nacisk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Przesunięcie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDroga);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxNacisk);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(651, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 106);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live View";
            // 
            // lbPomiarInfo
            // 
            this.lbPomiarInfo.AutoSize = true;
            this.lbPomiarInfo.BackColor = System.Drawing.Color.White;
            this.lbPomiarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPomiarInfo.Location = new System.Drawing.Point(12, 101);
            this.lbPomiarInfo.Name = "lbPomiarInfo";
            this.lbPomiarInfo.Size = new System.Drawing.Size(278, 17);
            this.lbPomiarInfo.TabIndex = 27;
            this.lbPomiarInfo.Text = "Oczekiwanie na pomiar z urządzenia.";
            // 
            // btnWydruk
            // 
            this.btnWydruk.Location = new System.Drawing.Point(96, 70);
            this.btnWydruk.Name = "btnWydruk";
            this.btnWydruk.Size = new System.Drawing.Size(75, 23);
            this.btnWydruk.TabIndex = 28;
            this.btnWydruk.Text = "Wydruk";
            this.btnWydruk.UseVisualStyleBackColor = true;
            this.btnWydruk.Click += new System.EventHandler(this.btnWydruk_Click);
            // 
            // danePomiaruBindingSource
            // 
            this.danePomiaruBindingSource.DataSource = typeof(NestorRepository.Entities.DanePomiaru);
            // 
            // pomiarBindingSource
            // 
            this.pomiarBindingSource.DataSource = typeof(NestorRepository.Entities.Pomiar);
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
            this.Procent.DataPropertyName = "Procent";
            dataGridViewCellStyle1.Format = "N2";
            this.Procent.DefaultCellStyle = dataGridViewCellStyle1;
            this.Procent.HeaderText = "Procentowa Wartość Ugięcia";
            this.Procent.Name = "Procent";
            this.Procent.ReadOnly = true;
            // 
            // PomiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.btnWydruk);
            this.Controls.Add(this.lbPomiarInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnZeruj);
            this.Controls.Add(this.tbIloscPunktowPomiarowych);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDanePomiaru);
            this.Controls.Add(this.cbDrut);
            this.Controls.Add(this.cbSprezyna);
            this.Controls.Add(this.cbProdukt);
            this.Controls.Add(this.cbKlient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PomiarForm";
            this.Text = "PomiarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanePomiaru)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbKlient;
        private System.Windows.Forms.ComboBox cbProdukt;
        private System.Windows.Forms.ComboBox cbSprezyna;
        private System.Windows.Forms.ComboBox cbDrut;
        private System.Windows.Forms.DataGridView dgvDanePomiaru;
        private System.Windows.Forms.BindingSource pomiarBindingSource;
        private System.Windows.Forms.BindingSource danePomiaruBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIloscPunktowPomiarowych;
        private System.Windows.Forms.Button btnZeruj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.TextBox textBoxNacisk;
        private System.Windows.Forms.TextBox textBoxDroga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbPomiarInfo;
        private System.Windows.Forms.Button btnWydruk;
        private System.Windows.Forms.DataGridViewTextBoxColumn próbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siłaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugięcieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procent;
    }
}