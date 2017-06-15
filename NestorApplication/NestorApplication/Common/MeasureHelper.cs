using System.Collections.Generic;
using NestorRepository.Entities;

namespace NestorApplication.Common
{
    public static class MeasureHelper
    {
        public static List<DanePomiaru> PrepareMeasures(List<DanePomiaru> measures, int count)
        {
            List<DanePomiaru> filteredMeasures = new List<DanePomiaru>();
            int offset = measures.Count / count;

            for (int i = 0; i < count; i++)
            {
                int indx = i * offset;
                if (indx > measures.Count)
                {
                    indx = measures.Count;
                }

                DanePomiaru measure = measures[i * offset];
                measure.Próba = i + 1;
                measure.Procent = measure.Ugięcie != 0 ? measure.Siła / measure.Ugięcie * 100: 0;
                filteredMeasures.Add(measure);
            }

            return filteredMeasures;
        }
    }
}