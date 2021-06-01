using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class RacunOtpremnica
    {
        public RacunOtpremnica()
        {
            listaStavki = new BindingList<StavkaRacunaOtpremnice>();
        }

        int racunOtpremnicaID;
        int brojRacunaOtpremnice;
        DateTime datumIzdavanja;
        DateTime datumPrometa;
        string nacinPlacanja;
        string imePrezimeProdavca;
        Predracun predracun;
        Prodavac prodavac;
        Kupac kupac;
        BindingList<StavkaRacunaOtpremnice> listaStavki;

        [Browsable(false)]
        public int RacunOtpremnicaID { get => racunOtpremnicaID; set => racunOtpremnicaID = value; }
        [DisplayName("Broj račun otpremnice")]
        public int BrojRacunaOtpremnice { get => brojRacunaOtpremnice; set => brojRacunaOtpremnice = value; }
        [DisplayName("Datum izdavanja")]
        public DateTime DatumIzdavanja { get => datumIzdavanja; set => datumIzdavanja = value; }
        [DisplayName("Datum prometa")]
        public DateTime DatumPrometa { get => datumPrometa; set => datumPrometa = value; }
        [DisplayName("Način plaćanja")]
        public string NacinPlacanja { get => nacinPlacanja; set => nacinPlacanja = value; }
        [Browsable(false)]
        public string ImePrezimeProdavca { get => imePrezimeProdavca; set => imePrezimeProdavca = value; }

        [Browsable(false)]
        public Predracun Predracun { get => predracun; set => predracun = value; }
        [DisplayName("PredračunID")]
        public string PredracunID
        {
            get { return "" + predracun.PredracunID; }
        }
        [Browsable(false)]
        public Prodavac Prodavac { get => prodavac; set => prodavac = value; }
        [DisplayName("ProdavacID")]
        public string IDProdavac
        {
            get { return "" + prodavac.ProdavacID; }
        }
        [DisplayName("Ime i prezime prodavca")]
        public string ImePrezimeProdavac
        {
            get { return "" + prodavac.ImePrezimeProdavca; }
        }

        public Kupac Kupac { get => kupac; set => kupac = value; }
        public BindingList<StavkaRacunaOtpremnice> ListaStavki { get => listaStavki; set => listaStavki = value; }
    }
}
