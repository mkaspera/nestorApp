using Microsoft.Reporting.WinForms;
using NestorRepository.Entities;
using System;
using System.IO;
using System.Windows.Forms;

namespace NestorApplication.Report
{
    public static class PrintMeasure
    {
        public static void Print(Klient klient, Produkt produkt, Sprezyna sprezyna, Drut drut, BindingSource source)
        {
            const string FolderName = "Wydruki";
            DateTime now = DateTime.Now;
            string executablePath = Environment.CurrentDirectory + Path.DirectorySeparatorChar;
            string date = DateTime.Now.ToShortDateString();

            ReportViewer reportViewer = new ReportViewer();
            reportViewer.LocalReport.ReportPath = executablePath + "Report\\MeasureReport.rdlc";

            ReportParameter data = new ReportParameter("Data", date);
            ReportParameter nazwaKlienta = new ReportParameter("NazwaKlienta", klient.Nazwa);
            ReportParameter logoKlienta = new ReportParameter("LogoKlienta", klient.Logo);
            ReportParameter nazwaProduktu = new ReportParameter("NazwaProduktu", produkt.Nazwa);
            ReportParameter wysokoscPoczatkowa = new ReportParameter("WysokoscPoczatkowa", produkt.Wysokość.ToString());
            ReportParameter wysokoscPoczatkowaSprezyn = new ReportParameter("WysokoscPoczatkowaSprezyn", sprezyna.WysokośćPoczątkowa.ToString());
            ReportParameter liczbaZwoi = new ReportParameter("LiczbaZwoi", sprezyna.LiczbaZwoi.ToString());
            ReportParameter srednicaDrutu = new ReportParameter("SrednicaDrutu", drut.Średnica.ToString());

            reportViewer.LocalReport.SetParameters(
                new ReportParameter[] { data, nazwaKlienta, logoKlienta, nazwaProduktu, wysokoscPoczatkowa, wysokoscPoczatkowaSprezyn, liczbaZwoi, srednicaDrutu }
            );

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Measures", source));

            if (!Directory.Exists(executablePath + FolderName))
            {
                Directory.CreateDirectory(executablePath + FolderName);
            }

            byte[] byteViewer = reportViewer.LocalReport.Render("PDF");
            string fileName = string.Concat(now.ToString("yyyyMMdd_HHmmss"), ".pdf");

            string path = executablePath + FolderName + Path.DirectorySeparatorChar + fileName;
            FileStream reportFile = new FileStream(path, FileMode.Create);
            reportFile.Write(byteViewer, 0, byteViewer.Length);
            reportFile.Flush();
            reportFile.Close();

            DialogResult dr = MessageBox.Show("Czy otworzyć zapisany wydruk ?", "Wydruk", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@path);
            }
        }
    }
}