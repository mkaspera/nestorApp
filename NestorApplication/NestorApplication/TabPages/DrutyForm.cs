using NestorApplication.Common;
using NestorRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class DrutyForm : Form
    {
        MainForm _mainForm;
        private DataTable _dataTable;
        private List<int> recordsToDeleted = new List<int>();

        public DrutyForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        public void SetFocus()
        {
            dgvDruty.Focus();
        }

        private void DrutyForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Add(_dataTable, dgvDruty, btnZapisz);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Edit(dgvDruty, btnZapisz);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Delete(dgvDruty, recordsToDeleted, btnZapisz, CanDeleteRecord);
        }

        private bool CanDeleteRecord(int id)
        {
            return DatabaseHelper.CountRecords("idDrut", id) == 0;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Save(dgvDruty, "Druty", _dataTable, recordsToDeleted, btnZapisz, DatabaseHelper.AddDrut, DatabaseHelper.UpdateDrut);
            _mainForm.RefreshListDruty();
        }

        private void LoadData()
        {
            _dataTable = DatabaseHelper.ReadDataTable(Druty.SelectQuery);
            dgvDruty.DataSource = _dataTable;
            DataGridViewHelper.SetGridProperties(dgvDruty);
        }
    }
}