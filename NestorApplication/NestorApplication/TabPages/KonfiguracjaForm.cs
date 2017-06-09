using NestorApplication.Configuration;
using System;
using System.Windows.Forms;

namespace NestorApplication.TabPages
{
    public partial class KonfiguracjaForm : Form
    {
        public KonfiguracjaForm()
        {
            InitializeComponent();
        }

        public void SetFocus()
        {
            tbPortCOM.Focus();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            ConfigurationParameter parameters = new ConfigurationParameter();
            parameters.Save(tbPortCOM.Text, tbBaudrate.Text, tbSkalaTensometr.Text, tbSkalaDroga.Text, tbCzuloscStart.Text, tbDrogaStop.Text, tbTimeoutStop.Text);

            MessageBox.Show("Pomyślnie zapisano parametry.", "Parametry konfiguracyjne");
        }
    }
}