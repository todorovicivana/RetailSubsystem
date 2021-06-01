using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class DeoVozila
    {
        int voziloID;
        int deoVozilaID;
        string napomena;
        Oprema oprema;

        [Browsable(false)]
        public int VoziloID { get => voziloID; set => voziloID = value; }
        [Browsable(false)]
        public int DeoVozilaID { get => deoVozilaID; set => deoVozilaID = value; }
        public Oprema Oprema { get => oprema; set => oprema = value; }
        public string Napomena { get => napomena; set => napomena = value; }
    }
}
