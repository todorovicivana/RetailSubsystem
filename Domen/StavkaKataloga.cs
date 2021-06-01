using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StavkaKataloga
    {
        int katalogID;
        int stavkaKatalogaID;
        string opis;
        Vozilo vozilo;

        public int KatalogID { get => katalogID; set => katalogID = value; }
        public int StavkaKatalogaID { get => stavkaKatalogaID; set => stavkaKatalogaID = value; }
        public string Opis { get => opis; set => opis = value; }
        public Vozilo Vozilo { get => vozilo; set => vozilo = value; }
    }
}
