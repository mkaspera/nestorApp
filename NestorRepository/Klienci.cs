using NestorRepository.Entities;
using System.Collections.Generic;

namespace NestorRepository
{
    public class Klienci
    {
        public List<Klient> GetData()
        {
            List<Klient> klienci = new List<Klient>();
            klienci.Add(new Klient { Nazwa = "Klient 1", Logo = "Logo 1 ?" });
            klienci.Add(new Klient { Nazwa = "Klient 2", Logo = "Logo 2 ?" });
            klienci.Add(new Klient { Nazwa = "Klient 3", Logo = "Logo 3 ?" });

            return klienci;
        }
    }
}