namespace NestorRepository.Entities
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public int Długość { get; set; }
        public int Szerokość { get; set; }
        public int Wysokość { get; set; }
        public string Typ { get; set; }

        public override string ToString()
        {
            return Nazwa;
        }
    }
}
