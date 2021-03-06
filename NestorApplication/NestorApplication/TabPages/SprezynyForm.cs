﻿using NestorApplication.Common;
using NestorRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class SprezynyForm : Form
    {
        MainForm _mainForm;
        private DataTable _dataTable;
        private List<int> recordsToDeleted = new List<int>();

        public SprezynyForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        public void SetFocus()
        {
            dgvSprezyny.Focus();
        }

        private void SprezynyForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Add(_dataTable, dgvSprezyny, btnZapisz);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Edit(dgvSprezyny, btnZapisz);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Delete(dgvSprezyny, recordsToDeleted, btnZapisz, CanDeleteRecord);
        }

        private bool CanDeleteRecord(int id)
        {
            return DatabaseHelper.CountRecords("idSprezyna", id) == 0;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.Save(dgvSprezyny, "Sprezyny", _dataTable, recordsToDeleted, btnZapisz, DatabaseHelper.AddSprezyna, DatabaseHelper.UpdateSprezyna);
            _mainForm.RefreshListSprezyny();
        }

        private void LoadData()
        {
            _dataTable = DatabaseHelper.ReadDataTable(Sprezyny.SelectQuery);
            dgvSprezyny.DataSource = _dataTable;
            DataGridViewHelper.SetGridProperties(dgvSprezyny);
        }
    }
}