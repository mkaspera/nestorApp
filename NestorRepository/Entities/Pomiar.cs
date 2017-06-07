using System.Collections.Generic;

namespace NestorRepository.Entities
{
    public class Pomiar
    {
        public string Klient { get; set; }
        public string Produkt { get; set; }
        public string Sprezyna { get; set; }
        public string Drut { get; set; }
        public int IloscPunktowPomiarowych { get; set; }
        public int RozstawPunktowPomiarowych { get; set; }
        public string Jednostka { get; set; }
        public IList<DanePomiaru> Pomiary { get; set; }
    }
}