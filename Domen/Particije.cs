using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Particije
    {
        [DisplayName("Broj particije")]
        public int Broj { get; set; }
        [DisplayName("Naziv particije")]
        public string NazivParticije { get; set; }
        
    }
}
