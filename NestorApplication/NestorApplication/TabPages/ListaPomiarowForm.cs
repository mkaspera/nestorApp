using NestorApplication.Common;
using NestorRepository;
using NestorRepository.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class ListaPomiarowForm : Form
    {
        MainForm _mainForm;
        private DataTable _dataTableHeaders;
        private DataTable _dataTableDetails;

        public ListaPomiarowForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void ListaPomiarowForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void SetFocus()
        {
            dgvPomiarNaglowki.Focus();
        }

        public void RefreshListKlienci()
        {
            cbKlient.DataSource = _mainForm.Klienci;
        }

        public void RefreshListProdukty()
        {
            cbProdukt.DataSource = _mainForm.Produkty;
        }

        public void RefreshListSprezyny()
        {
            cbSprezyna.DataSource = _mainForm.Sprezyny;
        }

        public void RefreshListDruty()
        {
            cbDrut.DataSource = _mainForm.Druty;
        }

        public void LoadData()
        {
            cbKlient.DataSource = _mainForm.Klienci;
            cbProdukt.DataSource = _mainForm.Produkty;
            cbSprezyna.DataSource = _mainForm.Sprezyny;
            cbDrut.DataSource = _mainForm.Druty;
        }

        private void btnFiltruj_Click(object sender, EventArgs e)
        {
            Klient klient = (Klient)cbKlient.SelectedValue;
            Produkt produkt = (Produkt)cbProdukt.SelectedValue;
            Sprezyna sprezyna = (Sprezyna)cbSprezyna.SelectedValue;
            Drut drut = (Drut)cbDrut.SelectedValue;
            DateTime start = dtpStart.Value;
            DateTime stop = dtpStop.Value;

            _dataTableHeaders = DatabaseHelper.ReadDataTable(Pomiary.GetQueryHeaders(klient, produkt, sprezyna, drut, start, stop));
            dgvPomiarNaglowki.DataSource = _dataTableHeaders;

            if (_dataTableHeaders.Rows.Count == 0)
            {
                dgvPomiarSzczegoly.DataSource = null;
                dgvPomiarSzczegoly.Refresh();
            }

            DataGridViewHelper.SetGridProperties(dgvPomiarNaglowki);
            dgvPomiarNaglowki.Focus();
        }

        private void dgvPomiarNaglowki_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPomiarNaglowki.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvPomiarNaglowki.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPomiarNaglowki.Rows[selectedRowIndex];
                object idPomiar = selectedRow.Cells[0].Value;

                _dataTableDetails = DatabaseHelper.ReadDataTable(Pomiary.GetQueryDetails(idPomiar));
                dgvPomiarSzczegoly.DataSource = _dataTableDetails;

                DataGridViewHelper.SetGridProperties(dgvPomiarSzczegoly);
            }
        }
    }
}