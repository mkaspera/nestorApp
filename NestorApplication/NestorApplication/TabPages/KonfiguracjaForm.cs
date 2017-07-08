using NestorApplication.Sensor;
using System;
using System.IO.Ports;
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
            GetComPorts();
            AssignParameter();
        }
        
        public void SetFocus()
        {
            cbPortCOM.Focus();
        }

        private void GetComPorts()
        {
            cbPortCOM.Items.Clear();
            cbPortCOM.Items.AddRange(SerialPort.GetPortNames());
        }

        private void AssignParameter()
        {
            cbPortCOM.Text = _mainForm.ConfigurationParameter.PortCOM;
            tbBaudrate.Text = _mainForm.ConfigurationParameter.Baudrate;
            tbSkalaTensometr.Text = _mainForm.ConfigurationParameter.SkalaTensometr;
            tbSkalaDroga.Text = _mainForm.ConfigurationParameter.SkalaDroga;
            tbCzuloscStart.Text = _mainForm.ConfigurationParameter.CzuloscStart;
            tbTimeoutPomiar.Text = _mainForm.ConfigurationParameter.TimeoutPomiar;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetComPorts();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            _mainForm.ConfigurationParameter.Save(cbPortCOM.Text, tbBaudrate.Text, tbSkalaTensometr.Text, tbSkalaDroga.Text, tbCzuloscStart.Text, tbTimeoutPomiar.Text);
            MessageBox.Show("Pomyślnie zapisano parametry.", "Parametry konfiguracyjne");
        }

        public void UpdateSensorInfo(SensorInfo entry)
        {
            labelSensorInfo.Text = "Sensor:" + entry.Version + " [compiled at " + entry.Compiled + "]";
        }
    }
}