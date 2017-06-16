using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using NestorRepository.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class RaportForm : Form
    {
        MainForm _mainForm;

        public RaportForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        public void LoadData()
        {
            lbKlient.Text = _mainForm.Pomiar.Klient.Nazwa;
            lbProdukt.Text = _mainForm.Pomiar.Produkt.Nazwa;
            lbSprezyna.Text = _mainForm.Pomiar.Sprezyna.Nazwa;
            lbDrut.Text = _mainForm.Pomiar.Drut.Nazwa;
            lbIloscPunktowPomiarowych.Text = _mainForm.Pomiar.IloscPunktowPomiarowych.ToString();

            PrepareCharts();
        }

        private void PrepareCharts()
        {
            LineSeries seriaSiła = new LineSeries();
            seriaSiła.Title = "Siła";
            seriaSiła.Values = new ChartValues<int>();

            LineSeries seriaUgięcie = new LineSeries();
            seriaUgięcie.Title = "Ugięcie";
            seriaUgięcie.Values = new ChartValues<int>();

            Axis axUgiecie = new Axis();
            axUgiecie.Title = "Ugięcie";
            axUgiecie.Separator = new Separator
            {
                Step = 1,
                IsEnabled = false
            };
            axUgiecie.Labels = new List<string>();
            axUgiecie.MinValue = 0;
            axUgiecie.MaxValue = 20;

            Axis axSila = new Axis();
            axSila.Title = "Siła";
            axSila.Separator = new Separator
            {
                Step = 1,
                IsEnabled = false
            };
            axSila.Labels = new List<string>();
            axSila.MinValue = 0;
            axSila.MaxValue = 20;

            foreach (DanePomiaru pomiar in _mainForm.Pomiar.Pomiary)
            {
                seriaSiła.Values.Add(pomiar.Siła);
                seriaUgięcie.Values.Add(pomiar.Ugięcie);
                axSila.Labels.Add(pomiar.Siła.ToString());
                axUgiecie.Labels.Add(pomiar.Ugięcie.ToString());
            }

            chartSilaDoUgiecia.Series.Add(seriaSiła);
            chartSilaDoUgiecia.AxisX.Add(axUgiecie);
            chartSilaDoUgiecia.LegendLocation = LegendLocation.Right;

            chartUgiecieDoSily.Series.Add(seriaUgięcie);
            chartUgiecieDoSily.AxisX.Add(axSila);
            chartUgiecieDoSily.LegendLocation = LegendLocation.Right;
        }

        private void btnWydruk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wydruk ? Wzór ?", "Wydruk");
        }
    }
}