using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public static class FileLoader
    {
        public static string path = @"C:\Users\emaap\Downloads\Spotify.csv";
        public static List<string> contents1;
        public static string[] contentsSeparato;
        public static List<Canzone> canzoni = new List<Canzone>();

        public static void CaricamentoFile()
        {

            FileInfo f = new FileInfo(path);

            try
            {
                contents1 = File.ReadAllLines(path).ToList();
                contents1.RemoveAt(0);
                Console.WriteLine("il file è stato caricato correttamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine("il caricamento del file non è andato a buon fine");
                Console.WriteLine("è necessario eseguire un riavvio dell'applicazione");
                contents1 = new string[0].ToList();
            }

            int i = 0;
            foreach (var line in contents1)
            {

                contentsSeparato = line.Split(",");
                canzoni.Add(new Canzone()
                {
                    _Genere = (Genere)int.Parse(contentsSeparato[0]),
                    Titolo = contentsSeparato[1],
                    _Artista = new Artista(contentsSeparato[2], (Genere)int.Parse(contentsSeparato[0])),
                    Durata = contentsSeparato[3]
                }
                );    
            }

        }
    }
}
