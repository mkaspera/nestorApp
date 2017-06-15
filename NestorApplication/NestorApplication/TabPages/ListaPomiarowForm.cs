using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class ListaPomiarowForm : Form
    {
        MainForm _mainForm;

        public ListaPomiarowForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
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
    }
}