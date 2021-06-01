using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Ugovor
    {
        public Ugovor()
        {
            listaClanovaUgovora = new BindingList<ClanUgovora>();
        }

        int ugovorID;
        int brojUgovora;
        DateTime datumPotpisivanja;
        Narudzbenica narudzbenica;
        Kupac kupac;
        Prodavac prodavac;
        BindingList<ClanUgovora> listaClanovaUgovora;

        [Browsable(false)]
        public int UgovorID { get => ugovorID; set => ugovorID = value; }
        [DisplayName("Broj ugovora")]
        public int BrojUgovora { get => brojUgovora; set => brojUgovora = value; }
        [DisplayName("Datum potpisivanja")]
        public DateTime DatumPotpisivanja { get => datumPotpisivanja; set => datumPotpisivanja = value; }

        [Browsable(false)]
        public Narudzbenica Narudzbenica { get => narudzbenica; set => narudzbenica = value; }
        [DisplayName("NarudžbenicaID")]
        public string Narudžbenica
        {
            get { return "" + narudzbenica.NarudzbenicaID; }
        }

        public Kupac Kupac { get => kupac; set => kupac = value; }
     
        public Prodavac Prodavac { get => prodavac; set => prodavac = value; }
        public BindingList<ClanUgovora> ListaClanovaUgovora { get => listaClanovaUgovora; set => listaClanovaUgovora = value; }

        public override string ToString()
        {
            return "Kupoprodajni ugovor broj: " + brojUgovora;
        }
    }
}
