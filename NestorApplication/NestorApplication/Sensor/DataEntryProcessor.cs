using NestorRepository.Entities;
using System;

namespace NestorApplication.Sensor
{
    public class DataEntryProcessor
    {
        public int TensometerScale { get; set; }
        public int DistanceScale { get; set; }
        public int ZeroTara { get; set; }
        public int ZeroOffset { get; set; }
        public int StartLevelGrams { get; set; }

        private MainForm _mainForm;
        private bool _taraFlag;
        private bool _measurementInProgress;
        private DanePomiaru _previousMeasure;
        private int _offsetSameSince;
        private bool _offesetFlag;

        public DataEntryProcessor(MainForm mainForm)
        {
            _mainForm = mainForm;
            _taraFlag = true;
            _offesetFlag = true;
            _previousMeasure = new DanePomiaru();
        }

        public void SetTaraFlag()
        {
            _taraFlag = true;
        }
        
        public void SetOffsetFlag()
        {
            _offesetFlag = true;
        }

        public DanePomiaru ProcessDataEntry(SensorEntry entry)
        {
            if (_taraFlag)
            {
                _taraFlag = false;
                ZeroTara = entry.Tens;
            }

            if (_offesetFlag)
            {
                _offesetFlag = false;
                ZeroOffset = entry.Offset;
            }

            DanePomiaru measure = new DanePomiaru
            {
                Siła = (entry.Tens - ZeroTara) / TensometerScale,
                Ugięcie = (entry.Offset - ZeroOffset) / DistanceScale,
            };

            if (Math.Abs(measure.Siła) > StartLevelGrams && !_measurementInProgress && Math.Abs(measure.Ugięcie) != 0)
            {
                _measurementInProgress = true;
                _offsetSameSince = 0;
                _mainForm.StartMeasure();
                Console.WriteLine("POMIAR ROZPOCZĘTY");
            }

            if (_previousMeasure.Ugięcie == measure.Ugięcie)
            {
                _offsetSameSince++;
            }
            else
            {
                _offsetSameSince = 0;
            }

            // 100 ostatnich pomiarów offset jest stały 
            if (_offsetSameSince > 40 && _measurementInProgress)
            {
                _measurementInProgress = false;
                _mainForm.StopMeasure();
                Console.WriteLine("POMIAR ZAKOŃCZONY");
            }

            _previousMeasure = measure;
            return measure;
        }
    }
}
