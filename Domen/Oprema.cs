using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Oprema
    {
        int opremaID;
        string nazivOpreme;
        string opis;

        [Browsable(false)]
        public int OpremaID { get => opremaID; set => opremaID = value; }
        [DisplayName("Naziv opreme")]
        public string NazivOpreme { get => nazivOpreme; set => nazivOpreme = value; }
        [DisplayName("Opis opreme")]
        public string Opis { get => opis; set => opis = value; }

        public override string ToString()
        {
            return nazivOpreme;
        }
    }
}
