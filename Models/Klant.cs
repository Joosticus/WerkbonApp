using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WerkbonApplicatie.Models
{
    public class Klant
    {
        public int KlantID { get; set; }
        [Display(Name ="Naam")]
        public string Klant_Naam { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Telefoonnummer { get; set; }
    }
}
