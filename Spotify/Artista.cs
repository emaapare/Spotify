using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Artista
    {
        public Genere _Genere;
        public string Nome;

        public Artista(string nome, Genere genere)
        {
            Nome = nome;
            _Genere = genere;
        }
    }
}
