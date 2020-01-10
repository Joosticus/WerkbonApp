using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WerkbonApplicatie.Models
{
    public class Werkbon
    {
        public int WerkbonID { get; set; }
        [Display(Name = "Contactpersoon")]
        [Required (ErrorMessage ="Dit veld is verplicht.")]
        public string Klant_Naam { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Telefoonnummer { get; set; }
        [DataType(DataType.Date)]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public DateTime Datum { get; set; }
        public bool Inpakken { get; set; }
        public bool Uitpakken { get; set; }
        public bool Montage { get; set; }
        public bool Demontage { get; set; }
        public bool Laden { get; set; }
        public bool Lossen { get; set; }

        [Display(Name = "Ophangen lamp")]
        public bool Ophangen_Lamp { get; set; }

        [Display(Name = "Afhalen lamp")]
        public bool Afhalen_Lamp { get; set; }

        [Display(Name = "Aansluiten witgoed")]
        public bool Aansluiten_Witgoed { get; set; }

        [Display(Name = "Afsluiten witgoed")]
        public bool Afsluiten_Witgoed { get; set; }

        [Display(Name = "Intern transport")]
        public bool Intern_Transport { get; set; }

        [Display(Name = "Schade Veroorzaakt")]
        public bool Schade_Veroorzaakt { get; set; }

        [Display(Name = "Schade Besproken")]
        public bool Schade_Besproken { get; set; }

        [Display(Name = "Schade beschrijving")]
        public string Schade_Beschrijving { get; set; }
        [Required (ErrorMessage = "Dit veld is verplicht.")]

        public string Kenteken { get; set; }

        [DataType(DataType.Time)]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public DateTime Aanvangstijd { get; set; }
        public int Volume { get; set; }

        [Display(Name = "Merk kraan")]
        public string Merk_Kraan { get; set; }
        public bool Traploper { get; set; }
        public bool Rolsteiger { get; set; }
        public bool Drempelplaat { get; set; }

        [Display(Name = "Groot Volume Bak")]
        public bool Groot_Volume_Bak { get; set; }
        public bool Wasmachinebeugel { get; set; }
        public bool Noppenfolie { get; set; }

        [Display(Name = "1-persoons matrashoes")]
        public bool Eenpersoons_Matrashoes { get; set; }

        [Display(Name = "2-persoons matrashoes")]
        public bool Tweepersoons_Matrashoes { get; set; }
        public bool Barrel { get; set; }
        public bool Handymankoffers { get; set; }

        [Display(Name = "Extra materiaal:")]
        public string Extra_Materiaal { get; set; }

        [Display(Name = "Vertrekuur Zaak:")]
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        public DateTime Vertrekuur_Zaak { get; set; }

        [Display(Name = "Inpakken Manuren")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        public int Inpakken_Manuren { get; set; }

        [Display(Name = "Uitpakken Manuren")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        public int Uitpakken_Manuren { get; set; }

        [Display(Name = "Montage manuren")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        public int Montage_Manuren { get; set; }

        [Display(Name = "Demontage manuren")]
        [Required(ErrorMessage = "Dit veld is verplicht.")]
        public int Demontage_Manuren { get; set; }

        [Display(Name = "Aantal man geladen")]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public int Aantal_Geladen { get; set; }

        [Display(Name = "Starttijd laden:")]
        [DataType(DataType.Time)]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public DateTime Starttijd_Laden { get; set; }

        [Display(Name = "Eindtijd laden:")]
        [DataType(DataType.Time)]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public DateTime Eindtijd_Laden { get; set; }

        [Display(Name = "Totale Laaduren")]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public int Laaduur_Totaal { get; set; }

        [Display(Name = "Aantal man gelost")]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public int Aantal_Gelost { get; set; }

        [Display(Name = "Starttijd lossen:")]
        [DataType(DataType.Time)]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public DateTime Starttijd_Lossen { get; set; }

        [Display(Name = "Eindtijd lossen:")]
        [DataType(DataType.Time)]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public DateTime Eindtijd_Lossen { get; set; }

        [Display(Name = "Totale Losuren")]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public int Losuur_Totaal { get; set; }

        [Display(Name = "Aankomsttijd zaak:")]
        [DataType(DataType.Time)]
        [Required (ErrorMessage = "Dit veld is verplicht.")]
        public DateTime Aankomsttijd_Zaak { get; set; }
        [Display(Name = "Bedrag")]
        [DataType(DataType.Currency)]
        public int Bedrag { get; set; }
        public string Betaalwijze { get; set; }
        [Display(Name = "Kostenplaats:")]
        public string KostenPlaats { get; set; }
        [Display(Name = "Adres:")]
        public string LaadAdres{ get; set; }
        [Display(Name = "Plaats:")]
        public string LaadPlaats { get; set; }
        [Display(Name = "Etage:")]
        public int LaadEtage { get; set; }
        [Display(Name = "Adres:")]
        public string LosAdres { get; set; }
        [Display(Name = "Plaats:")]
        public string LosPlaats { get; set; }
        [Display(Name = "Etage:")]
        public int LosEtage { get; set; }
    }
}
