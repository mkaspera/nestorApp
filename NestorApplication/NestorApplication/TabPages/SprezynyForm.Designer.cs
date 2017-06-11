namespace NestorApplication.TabPages
{
    partial class SprezynyForm
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
            this.lbSprezyny = new System.Windows.Forms.Label();
            this.dgvSprezyny = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.sprezynaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wysokoscPoczatkowaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srednicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liczbaZwoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSprezyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprezynaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSprezyny
            // 
            this.lbSprezyny.AutoSize = true;
            this.lbSprezyny.Location = new System.Drawing.Point(12, 9);
            this.lbSprezyny.Name = "lbSprezyny";
            this.lbSprezyny.Size = new System.Drawing.Size(129, 13);
            this.lbSprezyny.TabIndex = 0;
            this.lbSprezyny.Text = "Lista parametrów sprężyn:";
            // 
            // dgvSprezyny
            // 
            this.dgvSprezyny.AllowUserToAddRows = false;
            this.dgvSprezyny.AllowUserToDeleteRows = false;
            this.dgvSprezyny.AllowUserToOrderColumns = true;
            this.dgvSprezyny.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSprezyny.AutoGenerateColumns = false;
            this.dgvSprezyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSprezyny.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nazwaDataGridViewTextBoxColumn,
            this.wysokoscPoczatkowaDataGridViewTextBoxColumn,
            this.srednicaDataGridViewTextBoxColumn,
            this.liczbaZwoiDataGridViewTextBoxColumn});
            this.dgvSprezyny.DataSource = this.sprezynaBindingSource;
            this.dgvSprezyny.Location = new System.Drawing.Point(12, 34);
            this.dgvSprezyny.Name = "dgvSprezyny";
            this.dgvSprezyny.ReadOnly = true;
            this.dgvSprezyny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSprezyny.Size = new System.Drawing.Size(1060, 388);
            this.dgvSprezyny.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodaj.Location = new System.Drawing.Point(13, 428);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdytuj.Location = new System.Drawing.Point(94, 428);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 3;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsun.Location = new System.Drawing.Point(175, 428);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 4;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZapisz.Enabled = false;
            this.btnZapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZapisz.ForeColor = System.Drawing.Color.Red;
            this.btnZapisz.Location = new System.Drawing.Point(256, 428);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 7;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // sprezynaBindingSource
            // 
            this.sprezynaBindingSource.DataSource = typeof(NestorRepository.Entities.Sprezyna);
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataSource = typeof(NestorRepository.Entities.Produkt);
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataSource = typeof(NestorRepository.Entities.Klient);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wysokoscPoczatkowaDataGridViewTextBoxColumn
            // 
            this.wysokoscPoczatkowaDataGridViewTextBoxColumn.DataPropertyName = "WysokoscPoczatkowa";
            this.wysokoscPoczatkowaDataGridViewTextBoxColumn.HeaderText = "Wysokość Początkowa";
            this.wysokoscPoczatkowaDataGridViewTextBoxColumn.Name = "wysokoscPoczatkowaDataGridViewTextBoxColumn";
            this.wysokoscPoczatkowaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // srednicaDataGridViewTextBoxColumn
            // 
            this.srednicaDataGridViewTextBoxColumn.DataPropertyName = "Srednica";
            this.srednicaDataGridViewTextBoxColumn.HeaderText = "Średnica";
            this.srednicaDataGridViewTextBoxColumn.Name = "srednicaDataGridViewTextBoxColumn";
            this.srednicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // liczbaZwoiDataGridViewTextBoxColumn
            // 
            this.liczbaZwoiDataGridViewTextBoxColumn.DataPropertyName = "LiczbaZwoi";
            this.liczbaZwoiDataGridViewTextBoxColumn.HeaderText = "Liczba Zwoi";
            this.liczbaZwoiDataGridViewTextBoxColumn.Name = "liczbaZwoiDataGridViewTextBoxColumn";
            this.liczbaZwoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SprezynyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvSprezyny);
            this.Controls.Add(this.lbSprezyny);
            this.Name = "SprezynyForm";
            this.Text = "SprezynyForm";
            this.Load += new System.EventHandler(this.SprezynyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSprezyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprezynaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSprezyny;
        private System.Windows.Forms.DataGridView dgvSprezyny;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.BindingSource sprezynaBindingSource;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wysokoscPoczatkowaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srednicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liczbaZwoiDataGridViewTextBoxColumn;
    }
}