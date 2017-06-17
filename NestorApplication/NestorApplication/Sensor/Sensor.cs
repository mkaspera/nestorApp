using Newtonsoft.Json;
using System;
using System.IO.Ports;
using System.Windows;

namespace NestorApplication.Sensor
{
    public class Sensor
    {
        private MainForm _mainForm;
        private SerialPort _serialPort;

        private int _taraTens = 0;
        private int _previousOffset = -1;

        public Sensor(MainForm mainForm)
        {
            _mainForm = mainForm;

            int baudRate;
            int.TryParse(_mainForm.ConfigurationParameter.Baudrate, out baudRate);

            _serialPort = new SerialPort();
            _serialPort.PortName = _mainForm.ConfigurationParameter.PortCOM;
            _serialPort.BaudRate = baudRate;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;
            _serialPort.RtsEnable = true;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            string inData;
            try
            {
                inData = serialPort.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return;
            }

            if (inData.StartsWith("s1>"))
            {
                string data = inData.Substring(3);
                dynamic stuff;
                try
                {
                    stuff = JsonConvert.DeserializeObject(data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

                SensorEntry sensorEntry;
                bool exists = int.TryParse((string)stuff.time, out sensorEntry.Time);
                exists &= int.TryParse((string)stuff.tens, out sensorEntry.Tens);
                exists &= int.TryParse((string)stuff.offset, out sensorEntry.Offset);
                if (exists)
                {
                    if (sensorEntry.Offset * _previousOffset < 0)
                    {
                        _previousOffset = sensorEntry.Offset;
                        _taraTens = sensorEntry.Tens;
                    }
                    _mainForm.UpdateMeasure(sensorEntry);
                }
            }
            else if (inData.StartsWith("info>"))
            {
                string data = inData.Substring(5);
                dynamic stuff;
                try
                {
                    stuff = JsonConvert.DeserializeObject(data);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

                SensorInfo sensorInfo;
                sensorInfo.version = stuff.version;
                sensorInfo.compiled = stuff.compiled;

               _mainForm.UpdateSensorInfo (sensorInfo);
               
            }
        }

        public void Open()
        {
            try
            {
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Close()
        {
            try
            {
                _serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}