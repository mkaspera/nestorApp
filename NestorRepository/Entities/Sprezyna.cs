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
            return Nazwa;
        }
    }
}
