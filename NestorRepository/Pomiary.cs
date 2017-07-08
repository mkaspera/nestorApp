using System;
using NestorRepository.Entities;

namespace NestorRepository
{
    public class Pomiary
    {
        public const string DateFormat = "yyyy-MM-dd";
        public const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        public static string GetQueryHeaders(Klient klient, Produkt produkt, Sprezyna sprezyna, Drut drut, DateTime start, DateTime stop)
        {
            string query = "SELECT pomiar.id AS id, klient.Id AS idKlient, produkt.Id AS idProdukt, sprezyna.Id AS idSprezyna, drut.Id AS idDrut, ";
            query += "klient.Nazwa AS klient, produkt.Nazwa AS produkt, sprezyna.Nazwa AS sprezyna, drut.Nazwa AS drut, CAST(pomiar.data AS VARCHAR) AS dataPomiaru, pomiar.iloscPunktowPomiarowych AS iloscPunktow ";
            query += "FROM Pomiar pomiar ";
            query += "LEFT JOIN Klienci klient ON pomiar.idKlient = klient.id ";
            query += "LEFT JOIN Produkty produkt ON pomiar.idProdukt = produkt.id ";
            query += "LEFT JOIN Sprezyny sprezyna ON pomiar.idSprezyna = sprezyna.id ";
            query += "LEFT JOIN Druty drut ON pomiar.idDrut = drut.id ";
            query += "WHERE data BETWEEN '" + start.ToString(DateFormat) + " 00:00:00' AND '" + stop.ToString(DateFormat) + " 23:59:59'";
            if (klient.Id > 0)
            {
                query += " AND pomiar.idKlient = " + klient.Id;
            }
            if (produkt.Id > 0)
            {
                query += " AND pomiar.idProdukt = " + produkt.Id;
            }
            if (sprezyna.Id > 0)
            {
                query += " AND pomiar.idSprezyna = " + sprezyna.Id;
            }
            if (drut.Id > 0)
            {
                query += " AND pomiar.idDrut = " + drut.Id;
            }

            return query;
        }

        public static string GetQueryDetails(object idPomiar)
        {
            return "SELECT proba, sila, ugiecie, procent FROM DanePomiaru WHERE idPomiar = " + idPomiar;
        }
    }
}
