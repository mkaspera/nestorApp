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

        private void GetComPorts()
        {
            cbPortCOM.Items.Clear();
            cbPortCOM.Items.AddRange(SerialPort.GetPortNames());
        }
        public void SetFocus()
        {
            cbPortCOM.Focus();
        }

        private void AssignParameter()
        {
            cbPortCOM.Text = _mainForm.ConfigurationParameter.PortCOM;
            tbBaudrate.Text = _mainForm.ConfigurationParameter.Baudrate;
            tbSkalaTensometr.Text = _mainForm.ConfigurationParameter.SkalaTensometr;
            tbSkalaDroga.Text = _mainForm.ConfigurationParameter.SkalaDroga;
            tbCzuloscStart.Text = _mainForm.ConfigurationParameter.CzuloscStart;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            _mainForm.ConfigurationParameter.Save(cbPortCOM.Text, tbBaudrate.Text, tbSkalaTensometr.Text, tbSkalaDroga.Text, tbCzuloscStart.Text);
            MessageBox.Show("Pomyślnie zapisano parametry.", "Parametry konfiguracyjne");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetComPorts();
        }

        public void UpdateSensorInfo(SensorInfo entry)
        {
            labelSensorInfo.Text = "Sensor:" + entry.version + " [compiled at " + entry.compiled + "]";
        }
    }
}