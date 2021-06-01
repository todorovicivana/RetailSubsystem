using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class CenaVozila
    {
        int voziloID;
        int cenaVozilaID;
        double iznos;
        string valuta;
        string nazivVozila;

        [Browsable(false)]
        public int VoziloID { get => voziloID; set => voziloID = value; }
        [Browsable(false)]
        public int CenaVozilaID { get => cenaVozilaID; set => cenaVozilaID = value; }
        public double Iznos { get => iznos; set => iznos = value; }
        public string Valuta { get => valuta; set => valuta = value; }
        [DisplayName("Naziv vozila")]
        public string NazivVozila { get => nazivVozila; set => nazivVozila = value; }
    }
}
