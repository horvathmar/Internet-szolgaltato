using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_szolgaltato
{
    internal class Szerver
    {
        public string Nev { get; set; }
        public Szerver(string nev)
        {
            Nev = nev;
        }
        public void Feldolgoz(InternetCsomag csomag)
        {
            // TODO: Adatfeldolgozás 
        }
    }
}
