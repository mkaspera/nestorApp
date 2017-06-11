namespace NestorRepository.Entities
{
    public class Klient
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Logo { get; set; }

        public override string ToString()
        {
            return Nazwa;
        }
    }
}