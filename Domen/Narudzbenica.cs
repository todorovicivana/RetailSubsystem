using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Narudzbenica
    {
        public Narudzbenica()
        {
            listaStavki = new BindingList<StavkaNarudzbenice>();
        }

        int narudzbenicaID;
        int brojNarudzbenice;
        string nacinIsporuke;
        string nacinPlacanja;
        Ponuda ponuda;
        Kupac kupac;
        BindingList<StavkaNarudzbenice> listaStavki;

        public int NarudzbenicaID { get => narudzbenicaID; set => narudzbenicaID = value; }
        public int BrojNarudzbenice { get => brojNarudzbenice; set => brojNarudzbenice = value; }
        public string NacinIsporuke { get => nacinIsporuke; set => nacinIsporuke = value; }
        public string NacinPlacanja { get => nacinPlacanja; set => nacinPlacanja = value; }
        public Ponuda Ponuda { get => ponuda; set => ponuda = value; }
        public Kupac Kupac { get => kupac; set => kupac = value; }
        public BindingList<StavkaNarudzbenice> ListaStavki { get => listaStavki; set => listaStavki = value; }

        public override string ToString()
        {
            return "NarudžbenicaID: "+narudzbenicaID+", broj narudžbenice: "+brojNarudzbenice;
        }
    }
}
