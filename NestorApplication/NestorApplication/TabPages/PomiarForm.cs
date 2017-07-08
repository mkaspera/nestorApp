using NestorRepository.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NestorApplication.Sensor;
using NestorApplication.Common;
using LiveCharts.Wpf;
using LiveCharts;
using System.Linq;
using System.Drawing;
using NestorApplication.Report;

namespace NestorApplication.TabPages
{
    public partial class PomiarForm : Form
    {
        private object _synch = new object();
        private List<DanePomiaru> _measures = new List<DanePomiaru>();
        private MainForm _mainForm;
        private BindingSource _bindingSource = new BindingSource();
        private MovingAverage avgSiła = new MovingAverage();
        
        // TODO - delete
        // private bool _oneLoopStart = false;
        // private bool _oneLoopStop = false;

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
            // if (!_oneLoopStart)
            {
                lock (_synch)
                {
                    lbPomiarInfo.Text = "Trwa pomiar... Proszę czekać.";
                    lbPomiarInfo.ForeColor = Color.Red;
                    CleanGrid();
                    tbIloscPunktowPomiarowych.Enabled = false;
                    btnZeruj.Enabled = false;
                    btnWydruk.Enabled = false;
                    btnZapisz.Enabled = false;
                }
            }
            // _oneLoopStart = true;
        }

        public void UpdateMeasure(SensorEntry entry)
        {
            // if (!_oneLoopStop)
            {
                lock (_synch)
                {
                    var measure = _mainForm.Processor.ProcessDataEntry(entry);

                    avgSiła.ComputeAverage((int)measure.Siła);
                    textBoxNacisk.Text = avgSiła.Average.ToString();
                    textBoxDroga.Text = measure.Ugięcie.ToString();
                   
                    _measures.Add(measure);

                }
            }
        }

        public void StopMeasure()
        {
            // if (_oneLoopStart && !_oneLoopStop)
            {
                lock (_synch)
                {
                    int count = 20;
                    int.TryParse(tbIloscPunktowPomiarowych.Text, out count);
                    List<DanePomiaru> filteredMeasures = MeasureHelper.PrepareMeasures(_measures, count);
                    UpdateChart(filteredMeasures, count);
                    UpdateGrid(filteredMeasures);
                    UpdateViewStop();
                }
            }
            // _oneLoopStop = true;
        }

        private void btnZeruj_Click(object sender, EventArgs e)
        {
            _mainForm.Processor.SetOffsetFlag();
            _mainForm.Processor.SetTaraFlag();
        }

        private void btnWydruk_Click(object sender, EventArgs e)
        {
            try
            {
                lbPomiarInfo.Text = "Przygotowywanie wydruku... Proszę czekać.";
                lbPomiarInfo.ForeColor = Color.Red;

                Klient klient = (Klient)cbKlient.SelectedValue;
                Produkt produkt = (Produkt)cbProdukt.SelectedValue;
                Sprezyna sprezyna = (Sprezyna)cbSprezyna.SelectedValue;
                Drut drut = (Drut)cbDrut.SelectedValue;
                IList<DanePomiaru> pomiary = new List<DanePomiaru>();
                if (_bindingSource.List.Count > 0)
                {
                    pomiary = (IList<DanePomiaru>)_bindingSource.List;
                }

                string message = string.Empty;
                bool valid = MeasureHelper.Validate(true, klient, produkt, sprezyna, drut, pomiary, out message);
                if (!valid)
                {
                    MessageBox.Show(message, "Poprawność danych");
                    return;
                }

                PrintMeasure.Print(klient, produkt, sprezyna, drut, _bindingSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "Błąd podczas generowania wydruku.", MessageBoxButtons.OK);
            }
            lbPomiarInfo.Text = "Oczekiwanie na pomiar z urządzenia...";
            lbPomiarInfo.ForeColor = Color.Black;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            int iloscPunktowPomiarowych;
            bool resultPunktyPomiarowe = int.TryParse(tbIloscPunktowPomiarowych.Text, out iloscPunktowPomiarowych);

            Klient klient = (Klient)cbKlient.SelectedValue;
            Produkt produkt = (Produkt)cbProdukt.SelectedValue;
            Sprezyna sprezyna = (Sprezyna)cbSprezyna.SelectedValue;
            Drut drut = (Drut)cbDrut.SelectedValue;
            IList<DanePomiaru> pomiary = (IList<DanePomiaru>)_bindingSource.List;

            string message = string.Empty;
            bool valid = MeasureHelper.Validate(resultPunktyPomiarowe, klient, produkt, sprezyna, drut, pomiary, out message);
            if (!valid)
            {
                MessageBox.Show(message, "Poprawność danych");
                return;
            }

            _mainForm.Pomiar = new Pomiar();
            _mainForm.Pomiar.Klient = klient;
            _mainForm.Pomiar.Produkt = produkt;
            _mainForm.Pomiar.Sprezyna = sprezyna;
            _mainForm.Pomiar.Drut = drut;
            _mainForm.Pomiar.IloscPunktowPomiarowych = iloscPunktowPomiarowych;
            _mainForm.Pomiar.Pomiary = pomiary;

            if (MeasureHelper.Save(_mainForm.Pomiar))
            {
                CleanGrid();
            }
        }

        private void LoadData()
        {
            cbKlient.DataSource = _mainForm.Klienci;
            cbProdukt.DataSource = _mainForm.Produkty;
            cbSprezyna.DataSource = _mainForm.Sprezyny;
            cbDrut.DataSource = _mainForm.Druty;

            dgvDanePomiaru.DataSource = _bindingSource;
        }

        private void CleanGrid()
        {
            _measures.Clear();
            _bindingSource.Clear();
            dgvDanePomiaru.Refresh();
        }

        private void UpdateChart(List<DanePomiaru> filteredMeasures, int count)
        {
            LineSeries seriaSiła = new LineSeries();
            seriaSiła.Title = "Siła";
            seriaSiła.Values = new ChartValues<double>();

            LineSeries seriaUgięcie = new LineSeries();
            seriaUgięcie.Title = "Ugięcie";
            seriaUgięcie.Values = new ChartValues<double>();

            double minSiła = filteredMeasures.Min(x => Math.Abs(x.Siła));
            double maxSiła = filteredMeasures.Max(x => Math.Abs(x.Siła));
            double minUgięcie = filteredMeasures.Min(x => Math.Abs(x.Ugięcie));
            double maxUgięcie = filteredMeasures.Max(x => Math.Abs(x.Ugięcie));

            Axis axUgiecie = new Axis();
            axUgiecie.Title = "Ugięcie";
            axUgiecie.Separator = new Separator
            {
                Step = (maxUgięcie - minUgięcie) / count,
                IsEnabled = false
            };
            axUgiecie.Labels = new List<string>();
            axUgiecie.MinValue = minUgięcie;
            axUgiecie.MaxValue = maxUgięcie;

            Axis axSila = new Axis();
            axSila.Title = "Siła";
            axSila.Separator = new Separator
            {
                Step = (maxSiła - minSiła) / count,
                IsEnabled = false
            };
            axSila.Labels = new List<string>();
            axSila.MinValue = minSiła;
            axSila.MaxValue = maxSiła;

            foreach (DanePomiaru pomiar in filteredMeasures)
            {
                seriaSiła.Values.Add(Math.Abs(pomiar.Siła));
                seriaUgięcie.Values.Add(Math.Abs(pomiar.Ugięcie));
                axSila.Labels.Add(Math.Abs(pomiar.Siła).ToString());
                axUgiecie.Labels.Add(Math.Abs(pomiar.Ugięcie).ToString());
            }

            chartSilaDoUgiecia.Series.Clear();
            chartSilaDoUgiecia.Series.Add(seriaSiła);
            chartSilaDoUgiecia.AxisX.Add(axUgiecie);
            chartSilaDoUgiecia.LegendLocation = LegendLocation.Right;

            chartUgiecieDoSily.Series.Clear();
            chartUgiecieDoSily.Series.Add(seriaUgięcie);
            chartUgiecieDoSily.AxisX.Add(axSila);
            chartUgiecieDoSily.LegendLocation = LegendLocation.Right;
        }

        private void UpdateGrid(List<DanePomiaru> filteredMeasures)
        {
            foreach (DanePomiaru measure in filteredMeasures)
            {
                _bindingSource.Add(measure);
            }
            dgvDanePomiaru.FirstDisplayedScrollingRowIndex = dgvDanePomiaru.RowCount - 1;
            dgvDanePomiaru.Refresh();
        }

        private void UpdateViewStop()
        {
            lbPomiarInfo.Text = "Oczekiwanie na pomiar z urządzenia...";
            lbPomiarInfo.ForeColor = Color.Black;
            tbIloscPunktowPomiarowych.Enabled = true;
            btnZeruj.Enabled = true;
            btnWydruk.Enabled = true;
            btnZapisz.Enabled = true;
            dgvDanePomiaru.Focus();
        }
    }
}