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

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zapis ", "Parametry konfiguracyjne");
        }
    }
}
