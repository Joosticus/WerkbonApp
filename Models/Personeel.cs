using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WerkbonApplicatie.Models
{
    public class Personeel
    {   
        public int PersoneelID { get; set; }
        [Display(Name = "Naam")]
        public string Pesoneel_VoorNaam { get; set; }
        public string Personeel_Achternaam { get; set; }
        public string Password { get; set; }
        public string Functie { get; set; }
        public string Username { get; set; }

    }
}
