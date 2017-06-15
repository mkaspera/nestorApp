using NestorRepository.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NestorApplication.Sensor;
using NestorApplication.Common;

namespace NestorApplication.TabPages
{
    public partial class PomiarForm : Form
    {
        private object _synch = new object();
        private List<DanePomiaru> _measures = new List<DanePomiaru>();
        private MainForm _mainForm;
        private BindingSource _bindingSource = new BindingSource();

        // TODO - delete
        private bool _oneLoopStart = false;
        private bool _oneLoopStop = false;

        public PomiarForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            LoadData();
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

        public void StartMeasure()
        {
            if (!_oneLoopStart)
            {
                lock (_synch)
                {
                    lbPomiarInfo.Text = "Trwa pomiar... Proszę czekać.";
                    lbPomiarInfo.ForeColor = System.Drawing.Color.Red;
                    _measures.Clear();
                    _bindingSource.Clear();
                    dgvDanePomiaru.Refresh();
                    tbIloscPunktowPomiarowych.Enabled = false;
                    btnZeruj.Enabled = false;
                    btnWydruk.Enabled = false;
                    btnZapisz.Enabled = false;
                }
            }
            _oneLoopStart = true;
        }

        public void UpdateMeasure(SensorEntry entry)
        {
            if (!_oneLoopStop)
            {
                lock (_synch)
                {
                    textBoxNacisk.Text = entry.Tens.ToString();
                    textBoxDroga.Text = entry.Offset.ToString();
                    _measures.Add(_mainForm.Processor.ProcessDataEntry(entry));
                }
            }
        }

        public void StopMeasure()
        {
            if (_oneLoopStart && !_oneLoopStop)
            {
                lock (_synch)
                {
                    int count = 20;
                    int.TryParse(tbIloscPunktowPomiarowych.Text, out count);
                    List<DanePomiaru> filteredMeasures = MeasureHelper.PrepareMeasures(_measures, count);
                    foreach (DanePomiaru measure in filteredMeasures)
                    {
                        _bindingSource.Add(measure);
                    }
                    dgvDanePomiaru.FirstDisplayedScrollingRowIndex = dgvDanePomiaru.RowCount - 1;
                    dgvDanePomiaru.Refresh();

                    lbPomiarInfo.Text = "Oczekiwanie na pomiar z urządzenia...";
                    lbPomiarInfo.ForeColor = System.Drawing.Color.Black;
                    tbIloscPunktowPomiarowych.Enabled = true;
                    btnZeruj.Enabled = true;
                    btnWydruk.Enabled = true;
                    btnZapisz.Enabled = true;
                    dgvDanePomiaru.Focus();
                }
            }
            _oneLoopStop = true;
        }

        private void LoadData()
        {
            cbKlient.DataSource = _mainForm.Klienci;
            cbProdukt.DataSource = _mainForm.Produkty;
            cbSprezyna.DataSource = _mainForm.Sprezyny;
            cbDrut.DataSource = _mainForm.Druty;

            dgvDanePomiaru.DataSource = _bindingSource;
        }

        private void btnZeruj_Click(object sender, EventArgs e)
        {
            _mainForm.Processor.SetOffsetFlag();
            _mainForm.Processor.SetTaraFlag();
        }

        private void btnWydruk_Click(object sender, EventArgs e)
        {

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            _mainForm.Pomiar = new Pomiar();
            _mainForm.Pomiar.Klient = cbKlient.Text;
            _mainForm.Pomiar.Produkt = cbProdukt.Text;
            _mainForm.Pomiar.Sprezyna = cbSprezyna.Text;
            _mainForm.Pomiar.Drut = cbDrut.Text;
            _mainForm.Pomiar.IloscPunktowPomiarowych = int.Parse(tbIloscPunktowPomiarowych.Text);
            _mainForm.Pomiar.Pomiary = (IList<DanePomiaru>)_bindingSource.List;
        }
    }
}