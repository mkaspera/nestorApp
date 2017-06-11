namespace NestorRepository.Entities
{
    public class Sprezyna
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int WysokośćPoczątkowa { get; set; }
        public int Średnica { get; set; }
        public int LiczbaZwoi { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", Nazwa, WysokośćPoczątkowa, Średnica, LiczbaZwoi);
        }
    }
}
