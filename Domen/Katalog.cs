using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Katalog
    {
        public Katalog()
        {
            listaStavki = new BindingList<StavkaKataloga>();
        }

        int katalogID;
        DateTime datumOd;
        DateTime datumDo;
        BindingList<StavkaKataloga> listaStavki;

        public int KatalogID { get => katalogID; set => katalogID = value; }
        public DateTime DatumOd { get => datumOd; set => datumOd = value; }
        public DateTime DatumDo { get => datumDo; set => datumDo = value; }
        public BindingList<StavkaKataloga> ListaStavki { get => listaStavki; set => listaStavki = value; }

        public override string ToString()
        {
            return "KatalogID: "+katalogID+", važi od: "+DatumOd.ToString("dd.MM.yyyy")+" do: "+datumDo.ToString("dd.MM.yyyy");
        }
    }
}
