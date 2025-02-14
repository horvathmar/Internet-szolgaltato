using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internet_szolgaltato
{
    internal class Internet
    {

        public string Szerver { get; set; }
        public string Router { get; set; }
        public string Ugyfel { get; set; }
        public string Internetcsomag { get; set; }
        public Internet(string szerver, string router, string ugyfel, string internetcsomag)
        {
            Szerver = szerver;
            Router = router;
            Ugyfel = ugyfel;
            Internetcsomag = internetcsomag;
        }

    }
}
