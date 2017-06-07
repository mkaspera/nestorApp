using NestorApplication.Common;
using NestorRepository;
using NestorRepository.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class DrutyForm : Form
    {
        List<Drut> _druty = new List<Drut>();
        BindingSource _bindingSource = new BindingSource();

        public DrutyForm()
        {
            InitializeComponent();
        }

        public void SetFocus()
        {
            dgvSprezyny.Focus();
        }

        private void DrutyForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dgvSprezyny.ReadOnly = false;
            _bindingSource.Add(new Drut { Średnica = 0, Dostawca = "Dostawca" });
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
            _druty = new Druty().GetData();
            foreach (var drut in _druty)
            {
                _bindingSource.Add(drut);
            }

            dgvSprezyny.DataSource = _bindingSource;
            DataGridViewHelper.SetGridProperties(dgvSprezyny);
        }
    }
}