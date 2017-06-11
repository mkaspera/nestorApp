using NestorApplication.Common;
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

        DataEntryProcessor dep;

        public PomiarForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();

            dep = new DataEntryProcessor();
            dep.TensometerScale = Convert.ToInt32(_mainForm.ConfigurationParameter.SkalaTensometr);
            dep.DistanceScale = Convert.ToInt32(_mainForm.ConfigurationParameter.SkalaDroga);
            dep.StartLevelGrams = Convert.ToInt32(_mainForm.ConfigurationParameter.CzuloscStart);


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


            btnRaport.Enabled = true; //was false but changed for tests
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

        private void btnZeruj_Click(object sender, EventArgs e)
        {
            dep.SetOffsetFlag();
            dep.SetTaraFlag();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {

        }

        private void ReadData()
        {
            int count = 20;
            int.TryParse(tbIloscPunktowPomiarowych.Text, out count);
            for (int i = 0; i < count; i++)
            {
                DanePomiaru pomiar = new DanePomiaru { Próba = i + 1, Siła = 100 + i * 2, Ugięcie = i };
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

        public void OnUpdateView(SensorEntry inData)
        {
            BeginInvoke(
                new EventHandler(delegate
                {
                    //inData - surowe dane
                    //DanePomiaru - TabAlignment klaska powinna mieć troche logiki - zerowanie itp

                    textBoxNacisk.Text = inData.tens.ToString();
                    textBoxDroga.Text = inData.offset.ToString();


                    //_bindingSource.Clear();
                    if (dep == null)
                    {
                        return;
                    }
                    var pomiar = dep.ProcessDataEntry(inData);
                    _bindingSource.Add(pomiar);
                    dgvDanePomiaru.FirstDisplayedScrollingRowIndex = dgvDanePomiaru.RowCount - 1;
                    dgvDanePomiaru.Refresh();

                })
                );
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }


    public class DataEntryProcessor
    {
        public int TensometerScale { get; set; }
        public int DistanceScale { get; set; }
        public int ZeroTara { get; set; }
        public int ZeroOffset { get; set; }
        public int StartLevelGrams { get; set; }

        private bool _taraFlag;
        private bool _measurementInProgress;
        private DanePomiaru _previousDP;
        private int _offsetSameSince;

        public DataEntryProcessor()
        {
            _taraFlag = true;
            _offesetFlag = true;
            _previousDP = new DanePomiaru();
        }

        public void SetTaraFlag()
        {
            _taraFlag = true;
        }

        private bool _offesetFlag;
        public void SetOffsetFlag()
        {
            _offesetFlag = true;
        }

        public DanePomiaru ProcessDataEntry(SensorEntry se)
        {
            if (_taraFlag)
            {
                _taraFlag = false;
                ZeroTara = se.tens;
            }

            if (_offesetFlag)
            {
                _offesetFlag = false;
                ZeroOffset = se.offset;
            }

            DanePomiaru dp = new DanePomiaru { Siła = (se.tens - ZeroTara) / TensometerScale, Ugięcie = (se.offset - ZeroOffset) / DistanceScale };

            if (Math.Abs( dp.Siła) > StartLevelGrams && !_measurementInProgress)
            {
                _measurementInProgress = true;
                _offsetSameSince = 0;
                Console.WriteLine("POMIAR ROZPOCZĘTY");
                
            }

            if (_previousDP.Ugięcie == dp.Ugięcie)
            {
                _offsetSameSince++;
            }
            else
            {
                _offsetSameSince = 0;
            }

            if (_offsetSameSince > 20 && _measurementInProgress)  //100 ostatnich pomiarów offset jest stały 
            {
                _measurementInProgress = false;
                Console.WriteLine("POMIAR ZAKONCZONY");
            }

            _previousDP = dp;
            return dp;
        }
    }
}