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
        [Display(Name = "Voornaam")]
        public string Pesoneel_VoorNaam { get; set; }
        [Display(Name = "Achternaam")]
        public string Personeel_Achternaam { get; set; }
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }
        public string Functie { get; set; }
        [Display(Name = "Gebruikersnaam")]
        public string Username { get; set; }
        
    }
}
