using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Ponuda
    {
        public Ponuda()
        {
            listaStavki = new BindingList<StavkaPonude>();
        }

        int ponudaID;
        int brojPonude;
        DateTime datumOd;
        DateTime datumDo;
        string rokIsporuke;
        Katalog katalog;
        Prodavac prodavac;
        Kupac kupac;
        BindingList<StavkaPonude> listaStavki;

        [Browsable(false)]
        public int PonudaID { get => ponudaID; set => ponudaID = value; }
        [DisplayName("Broj ponude")]
        public int BrojPonude { get => brojPonude; set => brojPonude = value; }
        [DisplayName("Datum od")]
        public DateTime DatumOd { get => datumOd; set => datumOd = value; }
        [DisplayName("Datum do")]
        public DateTime DatumDo { get => datumDo; set => datumDo = value; }
        [DisplayName("Rok isporuke")]
        public string RokIsporuke { get => rokIsporuke; set => rokIsporuke = value; }
        [Browsable(false)]
        public Katalog Katalog { get => katalog; set => katalog = value; }
        [DisplayName("KatalogID")]
        public string KatalogID
        {
            get { return "" + katalog.KatalogID; }
        }

        public Prodavac Prodavac { get => prodavac; set => prodavac = value; }
        public Kupac Kupac { get => kupac; set => kupac = value; }
        public BindingList<StavkaPonude> ListaStavki { get => listaStavki; set => listaStavki = value; }
    }
}
