using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class ClanUgovora
    {
        int ugovorID;
        int clanUgovoraID;
        string nazivClanaUgovora;
        string opisClanaUgovora;

        [Browsable(false)]
        public int UgovorID { get => ugovorID; set => ugovorID = value; }
        [Browsable(false)]
        public int ClanUgovoraID { get => clanUgovoraID; set => clanUgovoraID = value; }
        [DisplayName("Naziv člana ugovora")]
        public string NazivClanaUgovora { get => nazivClanaUgovora; set => nazivClanaUgovora = value; }
        [DisplayName("Opis")]
        public string OpisClanaUgovora { get => opisClanaUgovora; set => opisClanaUgovora = value; }
    }
}
