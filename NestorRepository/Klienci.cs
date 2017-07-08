using NestorRepository.Entities;
using System.Collections.Generic;
using System.Data;

namespace NestorRepository
{
    public class Klienci
    {
        public const string SelectQuery = "SELECT id, nazwa, logo FROM Klienci";

        public List<Klient> GetData()
        {
            List<Klient> klienci = new List<Klient>();
            klienci.Add(new Klient { Id = -1, Nazwa = "== Wybierz ==", Logo = string.Empty });

            DataTable dataTable = DatabaseHelper.ReadDataTable(SelectQuery);
            foreach (DataRow row in dataTable.Rows)
            {
                klienci.Add(new Klient {
                    Id = int.Parse(row.ItemArray[0].ToString()),
                    Nazwa = row.ItemArray[1].ToString(),
                    Logo = row.ItemArray[2].ToString()
                });
            }
            
            return klienci;
        }

        public static Klient GetKlient(int id, List<Klient> klienci)
        {
            return klienci.Find(x => x.Id == id);
        }
    }
}