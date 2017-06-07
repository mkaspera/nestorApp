using NestorApplication.Common;
using NestorRepository;
using NestorRepository.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class KlienciForm : Form
    {
        List<Klient> _klienci = new List<Klient>();
        BindingSource _bindingSource = new BindingSource();

        public KlienciForm()
        {
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
            dgvKlienci.ReadOnly = false;
            _bindingSource.Add(new Klient { Nazwa = "", Logo = "" });
            DataGridViewHelper.SelectLastCellToEdit(dgvKlienci);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            dgvKlienci.ReadOnly = false;
            dgvKlienci.BeginEdit(true);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.DeleteRow(dgvKlienci);
        }

        private void LoadData()
        {
            _klienci = new Klienci().GetData();
            foreach (var klient in _klienci)
            {
                _bindingSource.Add(klient);
            }

            dgvKlienci.DataSource = _bindingSource;
            DataGridViewHelper.SetGridProperties(dgvKlienci);
        }
    }
}
