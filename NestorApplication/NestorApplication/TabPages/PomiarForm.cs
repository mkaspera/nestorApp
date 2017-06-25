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
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Data;

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
                    List<DanePomiaru> filteredMeasures = MeasureHelper.PrepareMeasuresBySzymon(_measures, count);
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
                IList<DanePomiaru> pomiary = (IList<DanePomiaru>)_bindingSource.List;

                string message = string.Empty;
                bool valid = MeasureHelper.Validate(true, klient, produkt, sprezyna, drut, pomiary, out message);
                if (!valid)
                {
                    MessageBox.Show(message, "Poprawność danych");
                    return;
                }

                const string FolderName = "Wydruki";
                DateTime now = DateTime.Now;
                string executablePath = Environment.CurrentDirectory + Path.DirectorySeparatorChar;
                string date = DateTime.Now.ToShortDateString();

                ReportViewer reportViewer = new ReportViewer();
                reportViewer.LocalReport.ReportPath = executablePath + "Report\\MeasureReport.rdlc";

                ReportParameter data = new ReportParameter("Data", date);
                ReportParameter nazwaKlienta = new ReportParameter("NazwaKlienta", klient.Nazwa);
                ReportParameter logoKlienta = new ReportParameter("LogoKlienta", klient.Logo);
                ReportParameter nazwaProduktu = new ReportParameter("NazwaProduktu", produkt.Nazwa);
                ReportParameter wysokoscPoczatkowa = new ReportParameter("WysokoscPoczatkowa", produkt.Wysokość.ToString());
                ReportParameter wysokoscPoczatkowaSprezyn = new ReportParameter("WysokoscPoczatkowaSprezyn", sprezyna.WysokośćPoczątkowa.ToString());
                ReportParameter liczbaZwoi = new ReportParameter("LiczbaZwoi", sprezyna.LiczbaZwoi.ToString());
                ReportParameter srednicaDrutu = new ReportParameter("SrednicaDrutu", drut.Średnica.ToString());

                reportViewer.LocalReport.SetParameters(
                    new ReportParameter[] { data, nazwaKlienta, logoKlienta, nazwaProduktu, wysokoscPoczatkowa, wysokoscPoczatkowaSprezyn, liczbaZwoi, srednicaDrutu }
                );

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Measures", _bindingSource));

                if (!Directory.Exists(executablePath + FolderName))
                {
                    Directory.CreateDirectory(executablePath + FolderName);
                }

                byte[] byteViewer = reportViewer.LocalReport.Render("PDF");
                string fileName = string.Concat(now.ToString("yyyyMMdd_HHmmss"), ".pdf");

                string path = executablePath + FolderName + Path.DirectorySeparatorChar + fileName;
                FileStream reportFile = new FileStream(path, FileMode.Create);
                reportFile.Write(byteViewer, 0, byteViewer.Length);
                reportFile.Flush();
                reportFile.Close();

                DialogResult dr = MessageBox.Show("Czy otworzyć zapisany wydruk ?", "Wydruk", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(@path);
                }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}