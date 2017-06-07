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
            this.dgvSprezyny = new System.Windows.Forms.DataGridView();
            this.średnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.sprezynaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dostawca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSprezyny)).BeginInit();
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
            this.średnicaDataGridViewTextBoxColumn,
            this.Dostawca});
            this.dgvSprezyny.DataSource = this.drutBindingSource;
            this.dgvSprezyny.Location = new System.Drawing.Point(12, 34);
            this.dgvSprezyny.Name = "dgvSprezyny";
            this.dgvSprezyny.ReadOnly = true;
            this.dgvSprezyny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSprezyny.Size = new System.Drawing.Size(1060, 388);
            this.dgvSprezyny.TabIndex = 1;
            // 
            // średnicaDataGridViewTextBoxColumn
            // 
            this.średnicaDataGridViewTextBoxColumn.DataPropertyName = "Średnica";
            this.średnicaDataGridViewTextBoxColumn.HeaderText = "Średnica";
            this.średnicaDataGridViewTextBoxColumn.Name = "średnicaDataGridViewTextBoxColumn";
            this.średnicaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Dostawca
            // 
            this.Dostawca.DataPropertyName = "Dostawca";
            this.Dostawca.HeaderText = "Dostawca";
            this.Dostawca.Name = "Dostawca";
            this.Dostawca.ReadOnly = true;
            // 
            // DrutyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvSprezyny);
            this.Controls.Add(this.lbDruty);
            this.Name = "DrutyForm";
            this.Text = "DrutyForm";
            this.Load += new System.EventHandler(this.DrutyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSprezyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprezynaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDruty;
        private System.Windows.Forms.DataGridView dgvSprezyny;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.BindingSource sprezynaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn średnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource drutBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostawca;
    }
}