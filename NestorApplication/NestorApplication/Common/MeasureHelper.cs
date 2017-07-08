using System;
using System.Collections.Generic;
using NestorRepository.Entities;
using NestorRepository;
using System.Windows;
using System.Linq;

namespace NestorApplication.Common
{
    public static class MeasureHelper
    {
        public static List<DanePomiaru> PrepareMeasures(List<DanePomiaru> measurementList, int datapoints)
        {
            if (measurementList.Count == 0)
            {
                return null;
            }

            double minUgiecie = measurementList.Min(x => x.Ugięcie);
            double maxUgiecie = measurementList.Max(x => x.Ugięcie);
            
            double range = maxUgiecie - minUgiecie;
            double distBetweenPoint = range / datapoints;

            List<DanePomiaru> normalizedList = new List<DanePomiaru>();

            double presentPoint = minUgiecie;
            for (int i = 0; i < datapoints; i++)
            {
                int idx = GetClosestIndex(measurementList, new DanePomiaru { Ugięcie = presentPoint });
                measurementList[idx].Próba = i + 1;
                measurementList[idx].Procent = maxUgiecie != 0 ? (measurementList[idx].Ugięcie/ maxUgiecie) * 100 : 0;
                normalizedList.Add(measurementList[idx]);
                presentPoint += distBetweenPoint;
            }

            return normalizedList;
        }

        public static bool Validate(bool resultPunktyPomiarowe, Klient klient, Produkt produkt, Sprezyna sprezyna, Drut drut, IList<DanePomiaru> pomiary, out string message)
        {
            message = string.Empty;
            if (!resultPunktyPomiarowe)
            {
                message = "Niepoprawna wartość ilości punktów pomiarowych.";
                return false;
            }
            if (klient.Id < 0)
            {
                message = "Wybierz klienta.";
                return false;
            }
            if (produkt.Id < 0)
            {
                message = "Wybierz produkt.";
                return false;
            }
            if (sprezyna.Id < 0)
            {
                message = "Wybierz sprężynę.";
                return false;
            }
            if (drut.Id < 0)
            {
                message = "Wybierz drut.";
                return false;
            }
            if (pomiary.Count == 0)
            {
                message = "Brak pomiarów.";
                return false;
            }
            return true;
        }

        public static bool Save(Pomiar pomiar)
        {
            bool result = DatabaseHelper.AddPomiar(pomiar.Klient, pomiar.Produkt, pomiar.Sprezyna, pomiar.Drut, DateTime.Now, pomiar.IloscPunktowPomiarowych, pomiar.Pomiary);
            MessageBox.Show(result ? "Pomyślnie zapisano zmiany." : "Nie udało się zapisać danych. Spróbuj ponownie.", "Zapis danych");
            return result;
        }

        private static int GetClosestIndex(List<DanePomiaru> list, DanePomiaru targetvalue)
        {
            return list.IndexOf(list.OrderBy(d => Math.Abs(d.Ugięcie - targetvalue.Ugięcie)).ElementAt(0));
        }
    }
}