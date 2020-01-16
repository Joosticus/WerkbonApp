using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WerkbonApplicatie.Models
{
    public class Personeel
    {
        public int PersoneelID { get; set; }
        [Display(Name = "Voornaam")]
        public string Pesoneel_VoorNaam { get; set; }
        [Display(Name = "Achternaam")]
        public string Personeel_Achternaam { get; set; }
        
    }
}
