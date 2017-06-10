using NestorRepository.Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.IO;
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
    }
}