using NestorRepository.Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System;

namespace NestorRepository
{
    public class DatabaseHelper
    {
        private static string databaseFile = ConfigurationManager.AppSettings["database"];
        private static string connectionString = "Data Source = " + databaseFile + "; Version=3;New=True;Compress=True;";

        public static void CreateDatabase()
        {
            if (File.Exists(databaseFile))
            {
                return;
            }

            string[] sqls = File.ReadAllLines("Database\\CreateDatabase.sql");

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    foreach (string sql in sqls)
                    {
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static List<Parametr> ReadConfigurationParameters()
        {
            List<Parametr> parameters = new List<Parametr>();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT nazwa, wartosc FROM Parametry";
                    command.ExecuteNonQuery();
                    using (SQLiteDataReader datareader = command.ExecuteReader())
                    {
                        while (datareader.Read())
                        {
                            parameters.Add(new Parametr { Nazwa = datareader.GetString(0), Wartosc = datareader.GetString(1) });
                        }
                    }
                }
            }
            return parameters;
        }

        public static void SaveParameters(List<Parametr> dbParameters)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    foreach (Parametr param in dbParameters)
                    {
                        command.CommandText = string.Format("UPDATE Parametry SET wartosc = '{0}' WHERE nazwa = '{1}'", param.Wartosc, param.Nazwa);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static DataTable ReadDataTable(string query)
        {
            DataSet dataSet = new DataSet();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.Fill(dataSet);
            }
            return dataSet.Tables[0];
        }

        public static void AddKlient(DataRow row)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    string nazwa = row.ItemArray[1].ToString();
                    string logo = row.ItemArray[2].ToString();
                    command.CommandText = string.Format("INSERT INTO Klienci (nazwa, logo) VALUES('{0}','{1}')", nazwa, logo);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateKlient(DataRow row)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    int id = int.Parse(row.ItemArray[0].ToString());
                    string nazwa = row.ItemArray[1].ToString();
                    string logo = row.ItemArray[2].ToString();
                    command.CommandText = string.Format("UPDATE Klienci SET nazwa = '{0}', logo = '{1}' WHERE id = {2}", nazwa, logo, id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteRecord(string tabela, int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = string.Format("DELETE FROM {0} WHERE id = {1}", tabela, id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static int CountRecords(string pole, int id)
        {
            int count = 0;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText = string.Format("SELECT Count(id) FROM Pomiar WHERE {0} = {1}", pole, id);
                    count = int.Parse(command.ExecuteScalar().ToString());
                }
            }
            return count;
        }

        public static void AddProdukt(DataRow row)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    string nazwa = row.ItemArray[1].ToString();
                    int dlugosc = 0;
                    int.TryParse(row.ItemArray[2].ToString(), out dlugosc);
                    int szerokosc = 0;
                    int.TryParse(row.ItemArray[3].ToString(), out szerokosc);
                    int wysokosc = 0;
                    int.TryParse(row.ItemArray[4].ToString(), out wysokosc);
                    string typ = row.ItemArray[5].ToString();
                    command.CommandText = string.Format("INSERT INTO Produkty (nazwa, dlugosc, szerokosc, wysokosc, typ) VALUES('{0}',{1},{2},{3},'{4}')", nazwa, dlugosc, szerokosc, wysokosc, typ);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateProdukt(DataRow row)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    int id = int.Parse(row.ItemArray[0].ToString());
                    string nazwa = row.ItemArray[1].ToString();
                    int dlugosc = 0;
                    int.TryParse(row.ItemArray[2].ToString(), out dlugosc);
                    int szerokosc = 0;
                    int.TryParse(row.ItemArray[3].ToString(), out szerokosc);
                    int wysokosc = 0;
                    int.TryParse(row.ItemArray[4].ToString(), out wysokosc);
                    string typ = row.ItemArray[5].ToString();
                    command.CommandText = string.Format("UPDATE Produkty SET nazwa = '{0}', dlugosc = {1}, szerokosc = {2}, wysokosc = {3}, typ = '{4}' WHERE id = {5}", nazwa, dlugosc, szerokosc, wysokosc, typ, id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddSprezyna(DataRow row)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    string nazwa = row.ItemArray[1].ToString();
                    int wysokoscPoczatkowa = 0;
                    int.TryParse(row.ItemArray[2].ToString(), out wysokoscPoczatkowa);
                    int srednica = 0;
                    int.TryParse(row.ItemArray[3].ToString(), out srednica);
                    int liczbaZwoi = 0;
                    int.TryParse(row.ItemArray[4].ToString(), out liczbaZwoi);
                    command.CommandText = string.Format("INSERT INTO Sprezyny (nazwa, wysokoscPoczatkowa, srednica, liczbaZwoi) VALUES('{0}',{1},{2},{3})", nazwa, wysokoscPoczatkowa, srednica, liczbaZwoi);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateSprezyna(DataRow row)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    int id = int.Parse(row.ItemArray[0].ToString());
                    string nazwa = row.ItemArray[1].ToString();
                    int wysokoscPoczatkowa = 0;
                    int.TryParse(row.ItemArray[2].ToString(), out wysokoscPoczatkowa);
                    int srednica = 0;
                    int.TryParse(row.ItemArray[3].ToString(), out srednica);
                    int liczbaZwoi = 0;
                    int.TryParse(row.ItemArray[4].ToString(), out liczbaZwoi);
                    command.CommandText = string.Format("UPDATE Sprezyny SET nazwa = '{0}', wysokoscPoczatkowa = {1}, srednica = {2}, liczbaZwoi = {3} WHERE id = {4}", nazwa, wysokoscPoczatkowa, srednica, liczbaZwoi, id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddDrut(DataRow row)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    string nazwa = row.ItemArray[1].ToString();
                    int srednica = 0;
                    int.TryParse(row.ItemArray[2].ToString(), out srednica);
                    string dostawca = row.ItemArray[3].ToString();
                    command.CommandText = string.Format("INSERT INTO Druty (nazwa, srednica, dostawca) VALUES('{0}',{1},'{2}')", nazwa, srednica, dostawca);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateDrut(DataRow row)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    int id = int.Parse(row.ItemArray[0].ToString());
                    string nazwa = row.ItemArray[1].ToString();
                    int srednica = 0;
                    int.TryParse(row.ItemArray[2].ToString(), out srednica);
                    string dostawca = row.ItemArray[3].ToString();
                    command.CommandText = string.Format("UPDATE Druty SET nazwa = '{0}', srednica = {1}, dostawca = '{2}' WHERE id = {3}", nazwa, srednica, dostawca, id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool AddPomiar(Klient klient, Produkt produkt, Sprezyna sprezyna, Drut drut, DateTime date, int iloscPunktowPomiarowych, IList<DanePomiaru> pomiary)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    SQLiteTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;

                    try
                    {
                        command.CommandText = string.Format("INSERT INTO Pomiar (idKlient, idProdukt, idSprezyna, idDrut, data, iloscPunktowPomiarowych) VALUES({0},{1},{2},{3},'{4}',{5})", klient.Id, produkt.Id, sprezyna.Id, drut.Id, date.ToString(Pomiary.DateTimeFormat), iloscPunktowPomiarowych);
                        command.ExecuteNonQuery();

                        command.CommandText = "SELECT last_insert_rowid()";
                        object idPomiar = command.ExecuteScalar();

                        foreach (DanePomiaru pomiar in pomiary)
                        {
                            command.CommandText = string.Format("INSERT INTO DanePomiaru (idPomiar, proba, sila, ugiecie, procent) VALUES({0},{1},{2},{3},{4})", idPomiar, pomiar.Próba, pomiar.Siła, pomiar.Ugięcie, pomiar.Procent);
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
        }
    }
}