using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rok
{
    public class IspitniRok
    {
        public string NazivPredmeta { get; set; }
        public string NazivRoka { get; set; }
        public DateTime Datum { get; set; }
        public List<Pitanje> Pitanja = new List<Pitanje>();

    }
}
