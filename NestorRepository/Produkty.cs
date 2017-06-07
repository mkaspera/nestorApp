using NestorRepository.Entities;
using System.Collections.Generic;

namespace NestorRepository
{
    public class Produkty
    {
        public List<Produkt> GetData()
        {
            List<Produkt> produkty = new List<Produkt>();
            produkty.Add(new Produkt { Nazwa = "Produkt 1", Długość = 1, Szerokość = 1, Wysokość = 1, Typ = "Materac 1" });
            produkty.Add(new Produkt { Nazwa = "Produkt 2", Długość = 2, Szerokość = 2, Wysokość = 2, Typ = "Materac 2" });
            produkty.Add(new Produkt { Nazwa = "Produkt 3", Długość = 3, Szerokość = 3, Wysokość = 3, Typ = "Materac 3" });
            return produkty;
        }
    }
}