using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Vozilo
    {
        public Vozilo()
        {
            listaCena = new BindingList<CenaVozila>();
            listaDelovaVozila = new BindingList<DeoVozila>();
        }

        int voziloID;
        string nazivVozila;
        string nazivModela;
        int brojVrata;
        int snagaMotora;
        string vrstaMenjaca;
        string tipVozila;
        BindingList<CenaVozila> listaCena;
        BindingList<DeoVozila> listaDelovaVozila;

        [Browsable(false)]
        public int VoziloID { get => voziloID; set => voziloID = value; }
        [DisplayName("Naziv vozila")]
        public string NazivVozila { get => nazivVozila; set => nazivVozila = value; }
        [DisplayName("Naziv modela")]
        public string NazivModela { get => nazivModela; set => nazivModela = value; }
        [DisplayName("Broj vrata")]
        public int BrojVrata { get => brojVrata; set => brojVrata = value; }
        [DisplayName("Snaga motora")]
        public int SnagaMotora { get => snagaMotora; set => snagaMotora = value; }
        [DisplayName("Vrsta menjača")]
        public string VrstaMenjaca { get => vrstaMenjaca; set => vrstaMenjaca = value; }
        [DisplayName("Tip vozila")]
        public string TipVozila { get => tipVozila; set => tipVozila = value; }
        public BindingList<CenaVozila> ListaCena { get => listaCena; set => listaCena = value; }
        public BindingList<DeoVozila> ListaDelovaVozila { get => listaDelovaVozila; set => listaDelovaVozila = value; }

        public override string ToString()
        {
            return nazivVozila + " " + NazivModela;
        }
    }
}
