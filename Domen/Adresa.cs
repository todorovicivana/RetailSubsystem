using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Adresa
    {
        int mestoID;
        int adresaID;
        string nazivUlice;
        string broj;

        public int MestoID { get => mestoID; set => mestoID = value; }
        public int AdresaID { get => adresaID; set => adresaID = value; }
        public string NazivUlice { get => nazivUlice; set => nazivUlice = value; }
        public string Broj { get => broj; set => broj = value; }
    }
}
