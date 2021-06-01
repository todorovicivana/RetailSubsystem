using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class UgovorParticije
    {
        DateTime datumPotpisivanja;
        int brojUgovora;
        int narudzbenicaID;
        string kupacJMBG;
        int prodavacID;

        [DisplayName("Datum potpisivanja")]
        public DateTime DatumPotpisivanja { get => datumPotpisivanja; set => datumPotpisivanja = value; }
        public int BrojUgovora { get => brojUgovora; set => brojUgovora = value; }
        public int NarudzbenicaID { get => narudzbenicaID; set => narudzbenicaID = value; }
        public string KupacJMBG { get => kupacJMBG; set => kupacJMBG = value; }
        public int ProdavacID { get => prodavacID; set => prodavacID = value; }
    }
}
