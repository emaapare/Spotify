using System;
using System.ComponentModel.DataAnnotations;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------SPOTIFY------");
            Utilities.StampaMenuIniziale();

            char Scelta = char.Parse(Console.ReadLine());
            Scelta = char.ToLower(Scelta);
            //FileLoader.LeggiFile();
        }
    }
}
