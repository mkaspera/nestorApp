namespace NestorRepository.Entities
{
    public class Drut
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Średnica { get; set; }
        public string Dostawca { get; set; }

        public override string ToString()
        {
            return Nazwa;
        }
    }
}