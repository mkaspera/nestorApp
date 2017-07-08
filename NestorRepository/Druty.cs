using NestorRepository.Entities;
using System.Collections.Generic;
using System.Data;

namespace NestorRepository
{
    public class Druty
    {
        public static string SelectQuery = "SELECT id, nazwa, srednica, dostawca FROM Druty";

        public List<Drut> GetData()
        {
            List<Drut> druty = new List<Drut>();
            druty.Add(new Drut { Id = -1, Nazwa = "== Wybierz ==", Dostawca = string.Empty, Średnica = 0 });

            DataTable dataTable = DatabaseHelper.ReadDataTable(SelectQuery);
            foreach (DataRow row in dataTable.Rows)
            {
                druty.Add(new Drut
                {
                    Id = int.Parse(row.ItemArray[0].ToString()),
                    Nazwa = row.ItemArray[1].ToString(),
                    Średnica = int.Parse(row.ItemArray[2].ToString()),
                    Dostawca = row.ItemArray[3].ToString()
                });
            }

            return druty;
        }

        public static Drut GetDrut(int id, List<Drut> druty)
        {
            return druty.Find(x => x.Id == id);
        }
    }
}