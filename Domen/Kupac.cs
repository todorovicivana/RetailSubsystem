using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Kupac
    {
        string kupacJMBG;
        string imePrezimeKupca;
        Adresa adresa;

        public string KupacJMBG { get => kupacJMBG; set => kupacJMBG = value; }
        public string ImePrezimeKupca { get => imePrezimeKupca; set => imePrezimeKupca = value; }
        public Adresa Adresa { get => adresa; set => adresa = value; }

        public override string ToString()
        {
            return imePrezimeKupca;
        }
    }
}
