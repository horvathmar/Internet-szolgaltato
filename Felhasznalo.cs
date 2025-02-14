using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_szolgaltato
{
    internal class Felhasznalo
    {

        public string Nev { get; set; }
        public int Jelszo { get; set; }

        public Felhasznalo(string nev, int jelszo)
        {
            Nev = nev;
            Jelszo = jelszo;
            if (nev  == null || jelszo < 100000 || jelszo > 1000000 )
            {
                throw new Exception("Helytelen adatot adott meg.");
            }
        }

    }
}
