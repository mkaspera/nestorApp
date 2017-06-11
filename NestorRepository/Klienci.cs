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
    }
}