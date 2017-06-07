using NestorApplication.Common;
using NestorRepository;
using NestorRepository.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class SprezynyForm : Form
    {
        List<Sprezyna> _sprezyny = new List<Sprezyna>();
        BindingSource _bindingSource = new BindingSource();

        public SprezynyForm()
        {
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
            dgvSprezyny.ReadOnly = false;
            _bindingSource.Add(new Sprezyna { WysokośćPoczątkowa = 0, Średnica = 0, LiczbaZwoi = 0 });
            DataGridViewHelper.SelectLastCellToEdit(dgvSprezyny);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            dgvSprezyny.ReadOnly = false;
            DataGridViewHelper.EditRow(dgvSprezyny);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.DeleteRow(dgvSprezyny);
        }

        private void LoadData()
        {
            _sprezyny = new Sprezyny().GetData();
            foreach (var sprezyna in _sprezyny)
            {
                _bindingSource.Add(sprezyna);
            }

            dgvSprezyny.DataSource = _bindingSource;
            DataGridViewHelper.SetGridProperties(dgvSprezyny);
        }
    }
}