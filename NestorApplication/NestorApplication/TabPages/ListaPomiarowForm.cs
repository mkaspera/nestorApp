using NestorApplication.Common;
using NestorApplication.Report;
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
                object idPomiar = GetRowValue(0);
                _dataTableDetails = DatabaseHelper.ReadDataTable(Pomiary.GetQueryDetails(idPomiar));
                dgvPomiarSzczegoly.DataSource = _dataTableDetails;

                DataGridViewHelper.SetGridProperties(dgvPomiarSzczegoly);
            }
        }

        private void btnDrukuj_Click(object sender, EventArgs e)
        {
            if (dgvPomiarNaglowki.SelectedRows.Count > 0)
            {
                int idKlient = int.Parse(GetRowValue(1));
                int idProdukt = int.Parse(GetRowValue(2));
                int idSprezyna = int.Parse(GetRowValue(3));
                int idDrut = int.Parse(GetRowValue(4));

                Klient klient = Klienci.GetKlient(idKlient, _mainForm.Klienci);
                Produkt produkt = Produkty.GetProdukt(idProdukt, _mainForm.Produkty);
                Sprezyna sprezyna = Sprezyny.GetSprezyna(idSprezyna, _mainForm.Sprezyny);
                Drut drut = Druty.GetDrut(idDrut, _mainForm.Druty);

                BindingSource bs = new BindingSource();
                DataRowCollection rows = ((DataTable)dgvPomiarSzczegoly.DataSource).Rows;
                for (int i = 0; i < rows.Count; i++)
                {
                    int proba = int.Parse(rows[i].ItemArray[0].ToString());
                    double sila = double.Parse(rows[i].ItemArray[1].ToString());
                    double ugiecie = double.Parse(rows[i].ItemArray[2].ToString());
                    double procent = double.Parse(rows[i].ItemArray[3].ToString());

                    bs.Add(new DanePomiaru { Próba = proba, Siła = sila, Ugięcie = ugiecie, Procent = procent });
                }

                PrintMeasure.Print(klient, produkt, sprezyna, drut, bs);
            }
        }

        private string GetRowValue(int indx)
        {
            int selectedRowIndex = dgvPomiarNaglowki.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvPomiarNaglowki.Rows[selectedRowIndex];
            return selectedRow.Cells[indx].Value.ToString();
        }
    }
}