using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StavkaPredracuna
    {
        int predracunID;
        int stavkaPredracunaID;
        int kolicina;
        Vozilo vozilo;

        [Browsable(false)]
        public int PredracunID { get => predracunID; set => predracunID = value; }
        [Browsable(false)]
        public int StavkaPredracunaID { get => stavkaPredracunaID; set => stavkaPredracunaID = value; }
        [DisplayName("Naziv vozila")]
        public Vozilo Vozilo { get => vozilo; set => vozilo = value; }
        [DisplayName("Količina")]
        public int Kolicina { get => kolicina; set => kolicina = value; }
    }
}
