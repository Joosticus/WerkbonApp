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
        public string Personeel_Voornaam { get; set; }
        [Display(Name = "Achternaam")]
        public string Personeel_Achternaam { get; set; }
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }
        public string Functie { get; set; }
        [Display(Name = "Gebruikersnaam")]
        public string Username { get; set; }
    }
}
