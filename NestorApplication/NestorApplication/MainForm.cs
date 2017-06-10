using NestorApplication.Common;
using NestorApplication.TabPages;
using NestorRepository.Entities;
using System.Windows.Forms;
using System;
using NestorRepository;
using NestorApplication.Configuration;

namespace NestorApplication
{
    public partial class MainForm : Form
    {
        public Pomiar Pomiar { get; set; }
        public ConfigurationParameter ConfigurationParameter { get; set; }

        KonfiguracjaForm _frmKonfiguracja;
        KlienciForm _frmKlienci = new KlienciForm();
        ProduktyForm _frmProdukty = new ProduktyForm();
        SprezynyForm _frmSprezyny = new SprezynyForm();
        DrutyForm _frmDruty = new DrutyForm();
        PomiarForm _frmPomiar;
        ListaPomiarowForm _frmListaPomiarow = new ListaPomiarowForm();
        RaportForm _frmRaport;

        public MainForm()
        {
            InitializeComponent();
            ConfigurationParameter = new ConfigurationParameter();
            DatabaseHelper.CreateDatabase();
            _frmKonfiguracja = new KonfiguracjaForm(this);
            _frmPomiar = new PomiarForm(this);
            _frmRaport = new RaportForm(this);
            InitTabs();
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
            TabControlHelper.SetTabProperties(_frmKonfiguracja, _frmKlienci, _frmProdukty, _frmSprezyny, _frmDruty, _frmPomiar, _frmRaport, _frmListaPomiarow);
            tabControl.TabPages[0].Controls.Add(_frmKonfiguracja);
            tabControl.TabPages[1].Controls.Add(_frmKlienci);
            tabControl.TabPages[2].Controls.Add(_frmProdukty);
            tabControl.TabPages[3].Controls.Add(_frmSprezyny);
            tabControl.TabPages[4].Controls.Add(_frmDruty);
            tabControl.TabPages[5].Controls.Add(_frmPomiar);
            tabControl.TabPages[6].Controls.Add(_frmRaport);
            tabControl.TabPages[7].Controls.Add(_frmListaPomiarow);
        }

        public void GotoReportTab()
        {
            _frmRaport.LoadData();
            tabControl.SelectedTab = tpRaport;
        }
    }
}