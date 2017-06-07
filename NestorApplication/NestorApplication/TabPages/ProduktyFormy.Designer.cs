namespace NestorApplication.TabPages
{
    partial class ProduktyForm
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
            this.lbProdukty = new System.Windows.Forms.Label();
            this.dgvProdukty = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.długośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szerokośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wysokośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProdukty
            // 
            this.lbProdukty.AutoSize = true;
            this.lbProdukty.Location = new System.Drawing.Point(12, 9);
            this.lbProdukty.Name = "lbProdukty";
            this.lbProdukty.Size = new System.Drawing.Size(135, 13);
            this.lbProdukty.TabIndex = 0;
            this.lbProdukty.Text = "Lista parametrów produktu:";
            // 
            // dgvProdukty
            // 
            this.dgvProdukty.AllowUserToAddRows = false;
            this.dgvProdukty.AllowUserToDeleteRows = false;
            this.dgvProdukty.AllowUserToOrderColumns = true;
            this.dgvProdukty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdukty.AutoGenerateColumns = false;
            this.dgvProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdukty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.długośćDataGridViewTextBoxColumn,
            this.szerokośćDataGridViewTextBoxColumn,
            this.wysokośćDataGridViewTextBoxColumn,
            this.typDataGridViewTextBoxColumn});
            this.dgvProdukty.DataSource = this.produktBindingSource;
            this.dgvProdukty.Location = new System.Drawing.Point(12, 34);
            this.dgvProdukty.Name = "dgvProdukty";
            this.dgvProdukty.ReadOnly = true;
            this.dgvProdukty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProdukty.Size = new System.Drawing.Size(1060, 388);
            this.dgvProdukty.TabIndex = 1;
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
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // długośćDataGridViewTextBoxColumn
            // 
            this.długośćDataGridViewTextBoxColumn.DataPropertyName = "Długość";
            this.długośćDataGridViewTextBoxColumn.HeaderText = "Długość";
            this.długośćDataGridViewTextBoxColumn.Name = "długośćDataGridViewTextBoxColumn";
            this.długośćDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szerokośćDataGridViewTextBoxColumn
            // 
            this.szerokośćDataGridViewTextBoxColumn.DataPropertyName = "Szerokość";
            this.szerokośćDataGridViewTextBoxColumn.HeaderText = "Szerokość";
            this.szerokośćDataGridViewTextBoxColumn.Name = "szerokośćDataGridViewTextBoxColumn";
            this.szerokośćDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wysokośćDataGridViewTextBoxColumn
            // 
            this.wysokośćDataGridViewTextBoxColumn.DataPropertyName = "Wysokość";
            this.wysokośćDataGridViewTextBoxColumn.HeaderText = "Wysokość";
            this.wysokośćDataGridViewTextBoxColumn.Name = "wysokośćDataGridViewTextBoxColumn";
            this.wysokośćDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typDataGridViewTextBoxColumn
            // 
            this.typDataGridViewTextBoxColumn.DataPropertyName = "Typ";
            this.typDataGridViewTextBoxColumn.HeaderText = "Typ";
            this.typDataGridViewTextBoxColumn.Name = "typDataGridViewTextBoxColumn";
            this.typDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataSource = typeof(NestorRepository.Entities.Produkt);
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataSource = typeof(NestorRepository.Entities.Klient);
            // 
            // ProduktyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvProdukty);
            this.Controls.Add(this.lbProdukty);
            this.Name = "ProduktyForm";
            this.Text = "ProduktyForm";
            this.Load += new System.EventHandler(this.ProduktyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdukty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProdukty;
        private System.Windows.Forms.DataGridView dgvProdukty;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn długośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerokośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wysokośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produktBindingSource;
    }
}