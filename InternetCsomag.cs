using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_szolgaltato
{
    internal class InternetCsomag
    {
        public string Adat { get; set; }
        public int Meret { get; set; }
        public InternetCsomag(string adat, int meret)
        {
            Adat = adat;
            Meret = meret;
        }
    }
}
