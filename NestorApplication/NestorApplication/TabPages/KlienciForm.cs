﻿using NestorApplication.Common;
using NestorRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class KlienciForm : Form
    {
        MainForm _mainForm;
        private DataTable _dataTable;
        private List<int> recordsToDeleted = new List<int>();

        public KlienciForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        public void SetFocus()
        {
            dgvKlienci.Focus();
        }

        private void KlienciForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Add(_dataTable, dgvKlienci, btnZapisz);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Edit(dgvKlienci, btnZapisz);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Delete(dgvKlienci, recordsToDeleted, btnZapisz, CanDeleteRecord);
        }

        private bool CanDeleteRecord(int id)
        {
            return DatabaseHelper.CountRecords("idKlient", id) == 0;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Save(dgvKlienci, "Klienci", _dataTable, recordsToDeleted, btnZapisz, DatabaseHelper.AddKlient, DatabaseHelper.UpdateKlient);
            _mainForm.RefreshListKlienci();
        }

        private void LoadData()
        {
            _dataTable = DatabaseHelper.ReadDataTable(Klienci.SelectQuery);
            dgvKlienci.DataSource = _dataTable;
            DataGridViewHelper.SetGridProperties(dgvKlienci);
        }
    }
}