using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WerkbonAppTest3.Models
{
    public class Ongeluk
    {
        public int ID { get; set; }
        public int KlantID { get; set; }
        public bool Schade { get; set; }
        public bool Besproken { get; set; }
        public string Kostenplaats { get; set; }
        public Klant Klant { get; set; }
    }
}
