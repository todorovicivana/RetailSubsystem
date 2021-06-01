using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Mesto
    {
        public Mesto()
        {
            listaAdresa = new BindingList<Adresa>();
        }

        int mestoID;
        string nazivMesta;
        string postanskiBroj;
        Drzava drzava;
        BindingList<Adresa> listaAdresa;

        public int MestoID { get => mestoID; set => mestoID = value; }
        public string NazivMesta { get => nazivMesta; set => nazivMesta = value; }
        public string PostanskiBroj { get => postanskiBroj; set => postanskiBroj = value; }
        public Drzava Drzava { get => drzava; set => drzava = value; }
        public BindingList<Adresa> ListaAdresa { get => listaAdresa; set => listaAdresa = value; }
    }
}
