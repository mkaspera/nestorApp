using System.Collections.Generic;

namespace NestorApplication.Common
{
    public class MovingAverage
    {
        private Queue<int> _samples = new Queue<int>();
        private int _windowSize = 10;
        private int _sampleAccumulator;

        public int Average { get; private set; }

        public void ComputeAverage(int newSample)
        {
            _sampleAccumulator += newSample;
            _samples.Enqueue(newSample);

            if (_samples.Count > _windowSize)
            {
                _sampleAccumulator -= _samples.Dequeue();
            }

            Average = _sampleAccumulator / _samples.Count;
        }
    }
}