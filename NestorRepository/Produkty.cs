using NestorRepository.Entities;
using System.Collections.Generic;
using System.Data;

namespace NestorRepository
{
    public class Produkty
    {
        public const string SelectQuery = "SELECT id, nazwa, dlugosc, szerokosc, wysokosc, typ FROM Produkty";

        public List<Produkt> GetData()
        {
            List<Produkt> produkty = new List<Produkt>();
            produkty.Add(new Produkt { Id = -1, Nazwa = "== Wybierz ==", Długość = 0, Szerokość = 0, Wysokość = 0, Typ = string.Empty });

            DataTable dataTable = DatabaseHelper.ReadDataTable(SelectQuery);
            foreach (DataRow row in dataTable.Rows)
            {
                produkty.Add(new Produkt
                {
                    Id = int.Parse(row.ItemArray[0].ToString()),
                    Nazwa = row.ItemArray[1].ToString(),
                    Długość = int.Parse(row.ItemArray[2].ToString()),
                    Szerokość = int.Parse(row.ItemArray[3].ToString()),
                    Wysokość = int.Parse(row.ItemArray[4].ToString()),
                    Typ = row.ItemArray[5].ToString()
                });
            }

            return produkty;
        }
    }
}