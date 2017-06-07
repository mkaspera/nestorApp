namespace NestorRepository.Entities
{
    public class Drut
    {
        public int Średnica { get; set; }
        public string Dostawca { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Dostawca, Średnica);
        }
    }
}