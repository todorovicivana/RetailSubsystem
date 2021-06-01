using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Predracun
    {
        public Predracun()
        {
            listaStavki = new BindingList<StavkaPredracuna>();
        }

        int predracunID;
        BrojPredracuna brojPredracuna;
        DateTime datumIzdavanja;
        DateTime datumPrometa;
        string nacinPlacanja;
        Ugovor ugovor;
        Prodavac prodavac;
        Kupac kupac;
        double ukupanIznos;
        BindingList<StavkaPredracuna> listaStavki;

        [Browsable(false)]
        public int PredracunID { get => predracunID; set => predracunID = value; }
        [Browsable(false)]
        public BrojPredracuna BrojPredracuna { get => brojPredracuna; set => brojPredracuna = value; }
        [DisplayName("Broj predračuna")]
        public string Broj
        {
            get { return brojPredracuna.Godina + "/" + brojPredracuna.RedniBroj; }
        }
        [DisplayName("Datum izdavanja")]
        public DateTime DatumIzdavanja { get => datumIzdavanja; set => datumIzdavanja = value; }
        [DisplayName("Datum prometa")]
        public DateTime DatumPrometa { get => datumPrometa; set => datumPrometa = value; }
        [DisplayName("Način plaćanja")]
        public string NacinPlacanja { get => nacinPlacanja; set => nacinPlacanja = value; }
        [Browsable(false)]
        public Ugovor Ugovor { get => ugovor; set => ugovor = value; }
        [DisplayName("UgovorID")]
        public string UgovorID
        {
            get { return ""+ugovor.UgovorID; }
        }
        public Prodavac Prodavac { get => prodavac; set => prodavac = value; }
        public Kupac Kupac { get => kupac; set => kupac = value; }
        [DisplayName("Ukupan iznos")]
        public double UkupanIznos { get => ukupanIznos; set => ukupanIznos = value; }
        public BindingList<StavkaPredracuna> ListaStavki { get => listaStavki; set => listaStavki = value; }

        public override string ToString()
        {
            return "Predračun ID: " + predracunID + " , Broj predračuna: " + brojPredracuna;
        }

        

    }
}
