using NestorRepository;
using NestorRepository.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class PomiarForm : Form
    {
        MainForm _mainForm;

        List<Klient> _klienci = new List<Klient>();
        List<Produkt> _produkty = new List<Produkt>();
        List<Sprezyna> _sprezyny = new List<Sprezyna>();
        List<Drut> _druty = new List<Drut>();

        BindingSource _bindingSource = new BindingSource();

        public PomiarForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            _klienci = new Klienci().GetData();
            _produkty = new Produkty().GetData();
            _sprezyny = new Sprezyny().GetData();
            _druty = new Druty().GetData();

            cbKlient.DataSource = _klienci;
            cbProdukt.DataSource = _produkty;
            cbSprezyna.DataSource = _sprezyny;
            cbDrut.DataSource = _druty;

            dgvDanePomiaru.DataSource = _bindingSource;

            btnRaport.Enabled = false;
        }

        private void btnPomiar_Click(object sender, EventArgs e)
        {
            btnPomiar.Enabled = false;
            btnRaport.Enabled = false;
            _bindingSource.Clear();
            dgvDanePomiaru.Refresh();
            ReadData();
            btnPomiar.Enabled = true;
            btnRaport.Enabled = true;
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            SaveDataToReport();
            _mainForm.GotoReportTab();
        }

        private void ReadData()
        {
            int count = 20;
            int.TryParse(tbIloscPunktowPomiarowych.Text, out count);
            for (int i = 0; i < count; i++)
            {
                DanePomiaru pomiar = new DanePomiaru { Próba = i+1, Siła = 100 + i*2, Ugięcie = i };
                _bindingSource.Add(pomiar);
                dgvDanePomiaru.Refresh();
                Thread.Sleep(200);
            }
        }

        private void SaveDataToReport()
        {
            _mainForm.Pomiar = new Pomiar();
            _mainForm.Pomiar.Klient = cbKlient.Text;
            _mainForm.Pomiar.Produkt = cbProdukt.Text;
            _mainForm.Pomiar.Sprezyna = cbSprezyna.Text;
            _mainForm.Pomiar.Drut = cbDrut.Text;
            _mainForm.Pomiar.IloscPunktowPomiarowych = int.Parse(tbIloscPunktowPomiarowych.Text);
            _mainForm.Pomiar.RozstawPunktowPomiarowych = int.Parse(tbRozstawPunktowPomiarowych.Text);
            _mainForm.Pomiar.Jednostka = tbJednostka.Text;
            _mainForm.Pomiar.Pomiary = (IList<DanePomiaru>)_bindingSource.List;
        }
    }
}