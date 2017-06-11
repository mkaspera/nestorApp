using NestorApplication.TabPages;


using Newtonsoft.Json;
using System;


using System.IO.Ports;
using System.Windows;

namespace NestorApplication.Common
{
    public struct SensorEntry
    {
        public int time;
        public int tens;
        public int offset;
      //  public int ra;
    }
    public class Sensor
    {
        public SerialPort mySerialPort;
        string _myComPort;

        int tara_tens = 0;
        int previous_offset = -1;
        public PomiarForm Form;


        public string ComPort
        {
            get { return _myComPort; }
            set { _myComPort = value; }
        }

        public Sensor()
        {
            mySerialPort = new SerialPort();

            mySerialPort.BaudRate = 57600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);


        }

        //delegate void SerialDataEventDelegate(SensorEntry Msg);

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata;
            try
            {
                indata = sp.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return;
            }



            if (indata.StartsWith("s1>"))
            {
                string js = indata.Substring(3);

                dynamic stuff;
                try
                {
                    stuff = JsonConvert.DeserializeObject(js);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }


                SensorEntry sd;
                var exists = Int32.TryParse((string)stuff.time, out sd.time);
                exists &= Int32.TryParse((string)stuff.tens, out sd.tens);
                exists &= Int32.TryParse((string)stuff.offset, out sd.offset);
               // exists &= Int32.TryParse((string)stuff.ra, out sd.ra);
                if (exists)
                {
                    if (sd.offset * previous_offset < 0)
                    {
                        previous_offset = sd.offset;
                        tara_tens = sd.tens;
                    }
                    //Console.WriteLine("DATA: " + (string)stuff.time);




                    //drutowanie na szybko
                    if (Form != null)
                    {
                        Form.OnUpdateView(sd);
                    }
                }
            }
        }

        public void Open()
        {
            mySerialPort.PortName = ComPort;

            try
            {
                mySerialPort.Open();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                MessageBox.Show(exc.Message);
            }
        }

        public void Close()
        {
            mySerialPort.Close();
        }

    }
}
