using NestorApplication.Common;
using NestorApplication.TabPages;
using NestorRepository.Entities;
using System.Windows.Forms;
using System;
using NestorRepository;
using NestorApplication.Configuration;
using System.Collections.Generic;
using NestorApplication.Sensor;

namespace NestorApplication
{
    public partial class MainForm : Form
    {
        public ConfigurationParameter ConfigurationParameter { get; set; }
        public Pomiar Pomiar { get; set; }
        public DataEntryProcessor Processor { get; set; }

        public List<Klient> Klienci = new List<Klient>();
        public List<Produkt> Produkty = new List<Produkt>();
        public List<Sprezyna> Sprezyny = new List<Sprezyna>();
        public List<Drut> Druty = new List<Drut>();

        private KonfiguracjaForm _frmKonfiguracja;
        private KlienciForm _frmKlienci;
        private ProduktyForm _frmProdukty;
        private SprezynyForm _frmSprezyny;
        private DrutyForm _frmDruty;
        private PomiarForm _frmPomiar;
        private ListaPomiarowForm _frmListaPomiarow;

        private Sensor.Sensor _sensor;

        public MainForm()
        {
            InitializeComponent();
            DatabaseHelper.CreateDatabase();

            ConfigurationParameter = new ConfigurationParameter();
            Klienci = new Klienci().GetData();
            Produkty = new Produkty().GetData();
            Sprezyny = new Sprezyny().GetData();
            Druty = new Druty().GetData();

            _frmKonfiguracja = new KonfiguracjaForm(this);
            _frmKlienci = new KlienciForm(this);
            _frmProdukty = new ProduktyForm(this);
            _frmSprezyny = new SprezynyForm(this);
            _frmDruty = new DrutyForm(this);
            _frmPomiar = new PomiarForm(this);
            _frmListaPomiarow = new ListaPomiarowForm(this);
            InitTabs();

            _sensor = new Sensor.Sensor(this);
            _sensor.Open();
            
            int tensometerScale;
            int.TryParse(ConfigurationParameter.SkalaTensometr, out tensometerScale);
            int distanceScale;
            int.TryParse(ConfigurationParameter.SkalaDroga, out distanceScale);
            int startLevelGrams;
            int.TryParse(ConfigurationParameter.CzuloscStart, out startLevelGrams);
            Processor = new DataEntryProcessor(this);
            Processor.TensometerScale = tensometerScale;
            Processor.DistanceScale = distanceScale;
            Processor.StartLevelGrams = startLevelGrams;
        }

        public void RefreshListKlienci()
        {
            Klienci = new Klienci().GetData();
            _frmPomiar.RefreshListKlienci();
            _frmListaPomiarow.RefreshListKlienci();
        }

        public void RefreshListProdukty()
        {
            Produkty = new Produkty().GetData();
            _frmPomiar.RefreshListProdukty();
            _frmListaPomiarow.RefreshListProdukty();
        }

        public void RefreshListSprezyny()
        {
            Sprezyny = new Sprezyny().GetData();
            _frmPomiar.RefreshListSprezyny();
            _frmListaPomiarow.RefreshListSprezyny();
        }

        public void RefreshListDruty()
        {
            Druty = new Druty().GetData();
            _frmPomiar.RefreshListDruty();
            _frmListaPomiarow.RefreshListDruty();
        }

        public void StartMeasure()
        {
            BeginInvoke(
                new EventHandler(delegate
                {
                    _frmPomiar.StartMeasure();
                })
            );
        }

        public void StopMeasure()
        {
            BeginInvoke(
                new EventHandler(delegate
                {
                    _frmPomiar.StopMeasure();
                })
            );
        }

        public void UpdateMeasure(SensorEntry entry)
        {
            try
            {
                BeginInvoke(
                    new EventHandler(delegate
                    {
                        _frmPomiar.UpdateMeasure(entry);
                    })
                );
            }
            catch (Exception)
            { }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            _frmKonfiguracja.SetFocus();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    _frmKonfiguracja.SetFocus();
                    break;
                case 1:
                    _frmKlienci.SetFocus();
                    break;
                case 2:
                    _frmProdukty.SetFocus();
                    break;
                case 3:
                    _frmSprezyny.SetFocus();
                    break;
                case 4:
                    _frmDruty.SetFocus();
                    break;
                case 7:
                    _frmListaPomiarow.SetFocus();
                    break;
            }
        }

        private void InitTabs()
        {
            TabControlHelper.SetTabProperties(_frmKonfiguracja, _frmKlienci, _frmProdukty, _frmSprezyny, _frmDruty, _frmPomiar, _frmListaPomiarow);
            tabControl.TabPages[0].Controls.Add(_frmKonfiguracja);
            tabControl.TabPages[1].Controls.Add(_frmKlienci);
            tabControl.TabPages[2].Controls.Add(_frmProdukty);
            tabControl.TabPages[3].Controls.Add(_frmSprezyny);
            tabControl.TabPages[4].Controls.Add(_frmDruty);
            tabControl.TabPages[5].Controls.Add(_frmPomiar);
            tabControl.TabPages[6].Controls.Add(_frmListaPomiarow);
        }
    }
}