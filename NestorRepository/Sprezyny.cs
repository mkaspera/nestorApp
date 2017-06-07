using NestorRepository.Entities;
using System.Collections.Generic;

namespace NestorRepository
{
    public class Sprezyny
    {
        public List<Sprezyna> GetData()
        {
            List<Sprezyna> sprezyny = new List<Sprezyna>();
            sprezyny.Add(new Sprezyna { WysokośćPoczątkowa = 1, Średnica = 1, LiczbaZwoi = 1 });
            sprezyny.Add(new Sprezyna { WysokośćPoczątkowa = 2, Średnica = 2, LiczbaZwoi = 2 });
            sprezyny.Add(new Sprezyna { WysokośćPoczątkowa = 3, Średnica = 3, LiczbaZwoi = 3 });
            return sprezyny;
        }
    }
}