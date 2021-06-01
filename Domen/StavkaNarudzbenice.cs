using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StavkaNarudzbenice
    {
        int narudzbenicaID;
        int stavkaNarudzbeniceID;
        int kolicina;
        Vozilo vozilo;

        public int NarudzbenicaID { get => narudzbenicaID; set => narudzbenicaID = value; }
        public int StavkaNarudzbeniceID { get => stavkaNarudzbeniceID; set => stavkaNarudzbeniceID = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public Vozilo Vozilo { get => vozilo; set => vozilo = value; }
    }
}
