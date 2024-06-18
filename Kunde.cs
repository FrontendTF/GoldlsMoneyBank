using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldlsMoneyBank
{
    internal class Kunde
    {
        public string KundenID { get; set; }
        public string KundenName { get; set; }
        public Kunde() { }
    }

    
    internal class Kundenkonto
    {
        public string KundenID { get; set; }

        public string Konto { get; set; }
        public Kundenkonto() { }
    }
}
