namespace NestorApplication.TabPages
{
    partial class DrutyForm
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
            this.lbDruty = new System.Windows.Forms.Label();
            this.dgvDruty = new System.Windows.Forms.DataGridView();
            this.drutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.sprezynaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srednicaTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostawcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDruty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprezynaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDruty
            // 
            this.lbDruty.AutoSize = true;
            this.lbDruty.Location = new System.Drawing.Point(12, 9);
            this.lbDruty.Name = "lbDruty";
            this.lbDruty.Size = new System.Drawing.Size(125, 13);
            this.lbDruty.TabIndex = 0;
            this.lbDruty.Text = "Lista parametrów drutów:";
            // 
            // dgvDruty
            // 
            this.dgvDruty.AllowUserToAddRows = false;
            this.dgvDruty.AllowUserToDeleteRows = false;
            this.dgvDruty.AllowUserToOrderColumns = true;
            this.dgvDruty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDruty.AutoGenerateColumns = false;
            this.dgvDruty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDruty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nazwaDataGridViewTextBoxColumn,
            this.srednicaTextBoxColumn,
            this.dostawcaDataGridViewTextBoxColumn});
            this.dgvDruty.DataSource = this.drutBindingSource;
            this.dgvDruty.Location = new System.Drawing.Point(12, 34);
            this.dgvDruty.Name = "dgvDruty";
            this.dgvDruty.ReadOnly = true;
            this.dgvDruty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDruty.Size = new System.Drawing.Size(1060, 388);
            this.dgvDruty.TabIndex = 1;
            // 
            // drutBindingSource
            // 
            this.drutBindingSource.DataSource = typeof(NestorRepository.Entities.Drut);
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
            this.btnZapisz.TabIndex = 8;
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
            // srednicaTextBoxColumn
            // 
            this.srednicaTextBoxColumn.DataPropertyName = "srednica";
            this.srednicaTextBoxColumn.HeaderText = "Średnica";
            this.srednicaTextBoxColumn.Name = "srednicaTextBoxColumn";
            this.srednicaTextBoxColumn.ReadOnly = true;
            // 
            // dostawcaDataGridViewTextBoxColumn
            // 
            this.dostawcaDataGridViewTextBoxColumn.DataPropertyName = "Dostawca";
            this.dostawcaDataGridViewTextBoxColumn.HeaderText = "Dostawca";
            this.dostawcaDataGridViewTextBoxColumn.Name = "dostawcaDataGridViewTextBoxColumn";
            this.dostawcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DrutyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvDruty);
            this.Controls.Add(this.lbDruty);
            this.Name = "DrutyForm";
            this.Text = "DrutyForm";
            this.Load += new System.EventHandler(this.DrutyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDruty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprezynaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDruty;
        private System.Windows.Forms.DataGridView dgvDruty;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.BindingSource sprezynaBindingSource;
        private System.Windows.Forms.BindingSource drutBindingSource;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srednicaTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostawcaDataGridViewTextBoxColumn;
    }
}