using NestorApplication.Common;
using NestorRepository;
using NestorRepository.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class ProduktyForm : Form
    {
        List<Produkt> _produkty = new List<Produkt>();
        BindingSource _bindingSource = new BindingSource();

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
            dgvProdukty.ReadOnly = false;
            _bindingSource.Add(new Produkt { Nazwa = "", Długość = 0, Szerokość = 0, Wysokość = 0, Typ = "Materac" });
            DataGridViewHelper.SelectLastCellToEdit(dgvProdukty);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            dgvProdukty.ReadOnly = false;
            DataGridViewHelper.EditRow(dgvProdukty);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.DeleteRow(dgvProdukty);
        }

        private void LoadData()
        {
            _produkty = new Produkty().GetData();
            foreach (var produkt in _produkty)
            {
                _bindingSource.Add(produkt);
            }

            dgvProdukty.DataSource = _bindingSource;
            DataGridViewHelper.SetGridProperties(dgvProdukty);
        }
    }
}