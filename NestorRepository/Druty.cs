using NestorRepository.Entities;
using System.Collections.Generic;

namespace NestorRepository
{
    public class Druty
    {
        public List<Drut> GetData()
        {
            List<Drut> druty = new List<Drut>();
            druty.Add(new Drut { Średnica = 1, Dostawca = "Dostawca 1" });
            druty.Add(new Drut { Średnica = 2, Dostawca = "Dostawca 2" });
            druty.Add(new Drut { Średnica = 3, Dostawca = "Dostawca 3" });
            return druty;
        }
    }
}