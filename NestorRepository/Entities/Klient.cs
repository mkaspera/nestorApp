namespace NestorRepository.Entities
{
    public class Klient
    {
        public string Nazwa { get; set; }
        public string Logo { get; set; }

        public override string ToString()
        {
            return Nazwa;
        }
    }
}