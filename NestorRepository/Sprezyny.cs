using NestorRepository.Entities;
using System.Collections.Generic;
using System.Data;

namespace NestorRepository
{
    public class Sprezyny
    {
        public const string SelectQuery = "SELECT id, nazwa, wysokoscPoczatkowa, srednica, liczbaZwoi FROM Sprezyny";

        public List<Sprezyna> GetData()
        {
            List<Sprezyna> sprezyny = new List<Sprezyna>();
            sprezyny.Add(new Sprezyna { Id = -1, Nazwa = "== Wybierz ==", LiczbaZwoi = 0, WysokośćPoczątkowa = 0, Średnica = 0 });

            DataTable dataTable = DatabaseHelper.ReadDataTable(SelectQuery);
            foreach (DataRow row in dataTable.Rows)
            {
                sprezyny.Add(new Sprezyna
                {
                    Id = int.Parse(row.ItemArray[0].ToString()),
                    Nazwa = row.ItemArray[1].ToString(),
                    WysokośćPoczątkowa = int.Parse(row.ItemArray[2].ToString()),
                    Średnica = int.Parse(row.ItemArray[3].ToString()),
                    LiczbaZwoi = int.Parse(row.ItemArray[4].ToString())
                });
            }

            return sprezyny;
        }

        public static Sprezyna GetSprezyna(int id, List<Sprezyna> sprezyny)
        {
            return sprezyny.Find(x => x.Id == id);
        }
    }
}