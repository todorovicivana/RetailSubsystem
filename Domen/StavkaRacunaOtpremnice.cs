using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StavkaRacunaOtpremnice
    {
        int racunOtpremnicaID;
        int stavkaRacunaOtpremniceID;
        int kolicina;
        Vozilo vozilo;

        [Browsable(false)]
        public int RacunOtpremnicaID { get => racunOtpremnicaID; set => racunOtpremnicaID = value; }
        [Browsable(false)]
        public int StavkaRacunaOtpremniceID { get => stavkaRacunaOtpremniceID; set => stavkaRacunaOtpremniceID = value; }
        [DisplayName("Naziv vozila")]
        public Vozilo Vozilo { get => vozilo; set => vozilo = value; }
       
        [DisplayName("Količina")]
        public int Kolicina { get => kolicina; set => kolicina = value; }
    }
}
