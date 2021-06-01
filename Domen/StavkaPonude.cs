using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StavkaPonude
    {
        int ponudaID;
        int stavkaPonudeID;
        string napomena;
        Vozilo vozilo;

        [Browsable(false)]
        public int PonudaID { get => ponudaID; set => ponudaID = value; }
        [Browsable(false)]
        public int StavkaPonudeID { get => stavkaPonudeID; set => stavkaPonudeID = value; }
       
        [DisplayName("Naziv vozila")]
        public Vozilo Vozilo { get => vozilo; set => vozilo = value; }
        public string Napomena { get => napomena; set => napomena = value; }
    }
}
