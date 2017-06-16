using System.Collections.Generic;

namespace NestorRepository.Entities
{
    public class Pomiar
    {
        public Klient Klient { get; set; }
        public Produkt Produkt { get; set; }
        public Sprezyna Sprezyna { get; set; }
        public Drut Drut { get; set; }
        public int IloscPunktowPomiarowych { get; set; }
        public IList<DanePomiaru> Pomiary { get; set; }
    }
}