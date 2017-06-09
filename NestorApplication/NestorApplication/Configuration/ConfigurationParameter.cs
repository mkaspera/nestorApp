using System;

namespace NestorApplication.Configuration
{
    public class ConfigurationParameter
    {
        public string PortCOM { get; set; }
        public string Baudrate { get; set; }
        public string SkalaTensometr { get; set; }
        public string SkalaDroga { get; set; }
        public string CzuloscStart { get; set; }
        public string DrogaStop { get; set; }
        public string TimeoutStop { get; set; }

        public void Save(string portCOM, string baudrate, string skalaTensometr, string skalaDroga, string czuloscStart, string drogaStop, string timeoutStop)
        {
            PortCOM = portCOM;
            Baudrate = baudrate;
            SkalaTensometr = skalaTensometr;
            SkalaDroga = skalaDroga;
            CzuloscStart = czuloscStart;
            DrogaStop = drogaStop;
            TimeoutStop = timeoutStop;

            // TODO save in db
        }
    }
}
