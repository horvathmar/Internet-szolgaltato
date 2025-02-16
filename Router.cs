using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_szolgaltato
{
    internal class Router
    {
        public string Nev { get; set; }
        public Router(string nev)
        {
            Nev = nev;
        }
        public void Tovabbitas(InternetCsomag csomag, Szerver szerver)
        {
            szerver.Feldolgoz(csomag);
        }
    }
}
