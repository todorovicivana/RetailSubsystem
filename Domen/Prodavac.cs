using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Prodavac
    {
        int prodavacID;
        string imePrezimeProdavca;

        public int ProdavacID { get => prodavacID; set => prodavacID = value; }
        [DisplayName("Ime i prezime prodavca")]
        public string ImePrezimeProdavca { get => imePrezimeProdavca; set => imePrezimeProdavca = value; }

        public override string ToString()
        {
            return imePrezimeProdavca;
        }
    }
}
