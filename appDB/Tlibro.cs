using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appDB
{
    class Tlibro
    {
        public string collocazione { get; set; }
        public string inventario { get; set; }
        public string titolo { get; set; }
        public string autore { get; set; }
        public string genere { get; set; }
        public string editore { get; set; }
        public bool disponibilita { get; set; }
        public int id { get; set; }

        public Tlibro(string c,string i, string t, string a,string g, string e, bool d, int iden)
        {
            collocazione = c;
            inventario = i;
            titolo = t;
            autore = a;
            genere = g;
            editore = e;
            disponibilita = d;
            id = iden;
        }
    }
}
