﻿namespace NestorApplication.TabPages
{
    partial class ListaPomiarowForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPomiarNaglowki = new System.Windows.Forms.DataGridView();
            this.dgvPomiarSzczegoly = new System.Windows.Forms.DataGridView();
            this.proba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugiecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDrut = new System.Windows.Forms.ComboBox();
            this.cbSprezyna = new System.Windows.Forms.ComboBox();
            this.cbProdukt = new System.Windows.Forms.ComboBox();
            this.cbKlient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnFiltruj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnDrukuj = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKlient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdukt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSprezyna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDrut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produkt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprezyna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPomiaru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscPunktow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomiarNaglowki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomiarSzczegoly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPomiarNaglowki
            // 
            this.dgvPomiarNaglowki.AllowUserToAddRows = false;
            this.dgvPomiarNaglowki.AllowUserToDeleteRows = false;
            this.dgvPomiarNaglowki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPomiarNaglowki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPomiarNaglowki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idKlient,
            this.idProdukt,
            this.idSprezyna,
            this.idDrut,
            this.klient,
            this.produkt,
            this.sprezyna,
            this.drut,
            this.dataPomiaru,
            this.iloscPunktow});
            this.dgvPomiarNaglowki.Location = new System.Drawing.Point(0, 0);
            this.dgvPomiarNaglowki.Name = "dgvPomiarNaglowki";
            this.dgvPomiarNaglowki.Size = new System.Drawing.Size(1084, 175);
            this.dgvPomiarNaglowki.TabIndex = 0;
            this.dgvPomiarNaglowki.SelectionChanged += new System.EventHandler(this.dgvPomiarNaglowki_SelectionChanged);
            // 
            // dgvPomiarSzczegoly
            // 
            this.dgvPomiarSzczegoly.AllowUserToAddRows = false;
            this.dgvPomiarSzczegoly.AllowUserToDeleteRows = false;
            this.dgvPomiarSzczegoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPomiarSzczegoly.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proba,
            this.sila,
            this.ugiecie,
            this.Procent});
            this.dgvPomiarSzczegoly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPomiarSzczegoly.Location = new System.Drawing.Point(0, 0);
            this.dgvPomiarSzczegoly.Name = "dgvPomiarSzczegoly";
            this.dgvPomiarSzczegoly.Size = new System.Drawing.Size(1084, 204);
            this.dgvPomiarSzczegoly.TabIndex = 1;
            // 
            // proba
            // 
            this.proba.DataPropertyName = "proba";
            this.proba.HeaderText = "Próba";
            this.proba.Name = "proba";
            this.proba.ReadOnly = true;
            this.proba.Width = 50;
            // 
            // sila
            // 
            this.sila.DataPropertyName = "sila";
            this.sila.HeaderText = "Siła";
            this.sila.Name = "sila";
            this.sila.ReadOnly = true;
            // 
            // ugiecie
            // 
            this.ugiecie.DataPropertyName = "ugiecie";
            this.ugiecie.HeaderText = "Ugięcie";
            this.ugiecie.Name = "ugiecie";
            this.ugiecie.ReadOnly = true;
            // 
            // Procent
            // 
            this.Procent.DataPropertyName = "procent";
            dataGridViewCellStyle6.Format = "N2";
            this.Procent.DefaultCellStyle = dataGridViewCellStyle6;
            this.Procent.HeaderText = "Procentowa Wartość Ugięcia";
            this.Procent.Name = "Procent";
            this.Procent.ReadOnly = true;
            // 
            // cbDrut
            // 
            this.cbDrut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrut.FormattingEnabled = true;
            this.cbDrut.Location = new System.Drawing.Point(575, 13);
            this.cbDrut.Name = "cbDrut";
            this.cbDrut.Size = new System.Drawing.Size(125, 21);
            this.cbDrut.TabIndex = 19;
            // 
            // cbSprezyna
            // 
            this.cbSprezyna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSprezyna.FormattingEnabled = true;
            this.cbSprezyna.Location = new System.Drawing.Point(411, 13);
            this.cbSprezyna.Name = "cbSprezyna";
            this.cbSprezyna.Size = new System.Drawing.Size(125, 21);
            this.cbSprezyna.TabIndex = 18;
            // 
            // cbProdukt
            // 
            this.cbProdukt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdukt.FormattingEnabled = true;
            this.cbProdukt.Location = new System.Drawing.Point(224, 13);
            this.cbProdukt.Name = "cbProdukt";
            this.cbProdukt.Size = new System.Drawing.Size(125, 21);
            this.cbProdukt.TabIndex = 17;
            // 
            // cbKlient
            // 
            this.cbKlient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKlient.FormattingEnabled = true;
            this.cbKlient.Location = new System.Drawing.Point(44, 13);
            this.cbKlient.Name = "cbKlient";
            this.cbKlient.Size = new System.Drawing.Size(125, 21);
            this.cbKlient.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(544, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Drut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(357, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sprężyna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(177, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produkt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Klient:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpStop);
            this.splitContainer1.Panel1.Controls.Add(this.cbDrut);
            this.splitContainer1.Panel1.Controls.Add(this.dtpStart);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnFiltruj);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.cbKlient);
            this.splitContainer1.Panel1.Controls.Add(this.cbProdukt);
            this.splitContainer1.Panel1.Controls.Add(this.cbSprezyna);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 461);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 20;
            // 
            // dtpStop
            // 
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStop.Location = new System.Drawing.Point(863, 14);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(91, 20);
            this.dtpStop.TabIndex = 25;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(741, 14);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(91, 20);
            this.dtpStart.TabIndex = 24;
            // 
            // btnFiltruj
            // 
            this.btnFiltruj.Location = new System.Drawing.Point(975, 13);
            this.btnFiltruj.Name = "btnFiltruj";
            this.btnFiltruj.Size = new System.Drawing.Size(75, 23);
            this.btnFiltruj.TabIndex = 23;
            this.btnFiltruj.Text = "Filtruj";
            this.btnFiltruj.UseVisualStyleBackColor = true;
            this.btnFiltruj.Click += new System.EventHandler(this.btnFiltruj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(838, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(714, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Od";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnDrukuj);
            this.splitContainer2.Panel1.Controls.Add(this.dgvPomiarNaglowki);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvPomiarSzczegoly);
            this.splitContainer2.Size = new System.Drawing.Size(1084, 413);
            this.splitContainer2.SplitterDistance = 205;
            this.splitContainer2.TabIndex = 2;
            // 
            // btnDrukuj
            // 
            this.btnDrukuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDrukuj.Location = new System.Drawing.Point(3, 178);
            this.btnDrukuj.Name = "btnDrukuj";
            this.btnDrukuj.Size = new System.Drawing.Size(75, 23);
            this.btnDrukuj.TabIndex = 26;
            this.btnDrukuj.Text = "Drukuj";
            this.btnDrukuj.UseVisualStyleBackColor = true;
            this.btnDrukuj.Click += new System.EventHandler(this.btnDrukuj_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // idKlient
            // 
            this.idKlient.DataPropertyName = "idKlient";
            dataGridViewCellStyle2.Format = "N0";
            this.idKlient.DefaultCellStyle = dataGridViewCellStyle2;
            this.idKlient.HeaderText = "idKlient";
            this.idKlient.Name = "idKlient";
            this.idKlient.Visible = false;
            // 
            // idProdukt
            // 
            this.idProdukt.DataPropertyName = "idProdukt";
            dataGridViewCellStyle3.Format = "N0";
            this.idProdukt.DefaultCellStyle = dataGridViewCellStyle3;
            this.idProdukt.HeaderText = "idProdukt";
            this.idProdukt.Name = "idProdukt";
            this.idProdukt.Visible = false;
            // 
            // idSprezyna
            // 
            this.idSprezyna.DataPropertyName = "idSprezyna";
            dataGridViewCellStyle4.Format = "N0";
            this.idSprezyna.DefaultCellStyle = dataGridViewCellStyle4;
            this.idSprezyna.HeaderText = "idSprezyna";
            this.idSprezyna.Name = "idSprezyna";
            this.idSprezyna.Visible = false;
            // 
            // idDrut
            // 
            this.idDrut.DataPropertyName = "idDrut";
            dataGridViewCellStyle5.Format = "N0";
            this.idDrut.DefaultCellStyle = dataGridViewCellStyle5;
            this.idDrut.HeaderText = "idDrut";
            this.idDrut.Name = "idDrut";
            this.idDrut.Visible = false;
            // 
            // klient
            // 
            this.klient.DataPropertyName = "klient";
            this.klient.HeaderText = "Klient";
            this.klient.Name = "klient";
            this.klient.ReadOnly = true;
            this.klient.Width = 150;
            // 
            // produkt
            // 
            this.produkt.DataPropertyName = "produkt";
            this.produkt.HeaderText = "Produkt";
            this.produkt.Name = "produkt";
            this.produkt.ReadOnly = true;
            this.produkt.Width = 150;
            // 
            // sprezyna
            // 
            this.sprezyna.DataPropertyName = "sprezyna";
            this.sprezyna.HeaderText = "Sprężyna";
            this.sprezyna.Name = "sprezyna";
            this.sprezyna.ReadOnly = true;
            this.sprezyna.Width = 150;
            // 
            // drut
            // 
            this.drut.DataPropertyName = "drut";
            this.drut.HeaderText = "Drut";
            this.drut.Name = "drut";
            this.drut.ReadOnly = true;
            this.drut.Width = 150;
            // 
            // dataPomiaru
            // 
            this.dataPomiaru.DataPropertyName = "dataPomiaru";
            this.dataPomiaru.HeaderText = "Data Pomiaru";
            this.dataPomiaru.Name = "dataPomiaru";
            this.dataPomiaru.ReadOnly = true;
            this.dataPomiaru.Width = 125;
            // 
            // iloscPunktow
            // 
            this.iloscPunktow.DataPropertyName = "iloscPunktow";
            this.iloscPunktow.HeaderText = "Ilość Punktów";
            this.iloscPunktow.Name = "iloscPunktow";
            this.iloscPunktow.ReadOnly = true;
            // 
            // ListaPomiarowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ListaPomiarowForm";
            this.Text = "ListaPomiarowForm";
            this.Load += new System.EventHandler(this.ListaPomiarowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomiarNaglowki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomiarSzczegoly)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPomiarNaglowki;
        private System.Windows.Forms.DataGridView dgvPomiarSzczegoly;
        private System.Windows.Forms.ComboBox cbDrut;
        private System.Windows.Forms.ComboBox cbSprezyna;
        private System.Windows.Forms.ComboBox cbProdukt;
        private System.Windows.Forms.ComboBox cbKlient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFiltruj;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnDrukuj;
        private System.Windows.Forms.DataGridViewTextBoxColumn proba;
        private System.Windows.Forms.DataGridViewTextBoxColumn sila;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugiecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procent;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdukt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSprezyna;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDrut;
        private System.Windows.Forms.DataGridViewTextBoxColumn klient;
        private System.Windows.Forms.DataGridViewTextBoxColumn produkt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprezyna;
        private System.Windows.Forms.DataGridViewTextBoxColumn drut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPomiaru;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscPunktow;
    }
}