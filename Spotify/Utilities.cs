using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public static class Utilities
    {
        public static void StampaMenuIniziale()
        {
            FileLoader.CaricamentoFile();
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nMUSICA(m)                                       PROFILO(c)");
            Console.WriteLine("\nArtisti(a)   Album(d)   Playlist(p)   Generi(g)   Cerca(c)");
        }

        public static void StampaScelta(char Scelta)
        {
            switch (Scelta)
            {
                case 'm':
                    {
                        
                        return;
                    }
            }
        }
    }
}
