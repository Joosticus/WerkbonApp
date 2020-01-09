using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WerkbonApplicatie.Models
{
    public class Adres
    {
        public int AdresID { get; set; }
        public int VerhuizingID { get; set; }
        public string Straat { get; set; }
        public string Postcode { get; set; }
        public string Huisnummer { get; set; }
        public string Plaats { get; set; }
        public int Etage { get; set; }
        public string Type { get; set; }
        public Verhuizing Verhuizing { get; set; }
    }
}
