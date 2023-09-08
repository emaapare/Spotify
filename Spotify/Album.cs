using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Album : Raccolta
    {
        public Genere _Genere;
        public Artista _Artista;

        public Album(Genere genere, Artista artista) { 
            _Genere = genere;
            _Artista = artista;
            Canzoni = null;
        }

        

    }
}
