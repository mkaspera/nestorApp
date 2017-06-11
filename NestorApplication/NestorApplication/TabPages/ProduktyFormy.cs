using NestorApplication.Common;
using NestorRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class ProduktyForm : Form
    {
        private DataTable _dataTable;
        private List<int> recordsToDeleted = new List<int>();

        public ProduktyForm()
        {
            InitializeComponent();
        }

        public void SetFocus()
        {
            dgvProdukty.Focus();
        }

        private void ProduktyForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Add(_dataTable, dgvProdukty, btnZapisz);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Edit(dgvProdukty, btnZapisz);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Delete(dgvProdukty, recordsToDeleted, btnZapisz);
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Save(dgvProdukty, "Produkty", _dataTable, recordsToDeleted, btnZapisz, DatabaseHelper.AddProdukt, DatabaseHelper.UpdateProdukt);
        }

        private void LoadData()
        {
            _dataTable = DatabaseHelper.ReadDataTable(Produkty.SelectQuery);
            dgvProdukty.DataSource = _dataTable;
            DataGridViewHelper.SetGridProperties(dgvProdukty);
        }
    }
}