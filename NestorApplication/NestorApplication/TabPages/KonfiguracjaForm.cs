using System;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class KonfiguracjaForm : Form
    {
        MainForm _mainForm;

        public KonfiguracjaForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            _mainForm.ConfigurationParameter.Read();
            AssignParameter();
        }

        public void SetFocus()
        {
            tbPortCOM.Focus();
        }

        private void AssignParameter()
        {
            tbPortCOM.Text = _mainForm.ConfigurationParameter.PortCOM;
            tbBaudrate.Text = _mainForm.ConfigurationParameter.Baudrate;
            tbSkalaTensometr.Text = _mainForm.ConfigurationParameter.SkalaTensometr;
            tbSkalaDroga.Text = _mainForm.ConfigurationParameter.SkalaDroga;
            tbCzuloscStart.Text = _mainForm.ConfigurationParameter.CzuloscStart;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            _mainForm.ConfigurationParameter.Save(tbPortCOM.Text, tbBaudrate.Text, tbSkalaTensometr.Text, tbSkalaDroga.Text, tbCzuloscStart.Text);
            MessageBox.Show("Pomyślnie zapisano parametry.", "Parametry konfiguracyjne");
        }
    }
}