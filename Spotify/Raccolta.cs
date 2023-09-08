using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public abstract class Raccolta
    {
        public string Nome;
        public List<Canzone> Canzoni;

        public void AggiungiCanzone(Canzone canzoni)
        {
            Canzoni.Add(canzoni);
            Console.WriteLine($"il brano {canzoni} è stato aggiunto correttamente");
        }
    }
}
