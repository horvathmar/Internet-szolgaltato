using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_szolgaltato
{
    internal class Ugyfel
    {
        public string Nev { get; set; }
        public string Jelszo { get; set; }
        public Ugyfel(string nev, string jelszo)
        {
            Nev = nev;
            Jelszo = jelszo;
        }
        public InternetCsomag Kuldes(string adat)
        {
            return new InternetCsomag(adat, adat.Length);
        }
    }
}
