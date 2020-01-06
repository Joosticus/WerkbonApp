using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WerkbonApplicatie.Models
{
    public class Verhuizing_Personeel
    {
        public int PersoneelID { get; set; }
        public int VerhuizingID { get; set; }
        public Personeel personeel { get; set; }
        public Verhuizing verhuizing { get; set; }
    }
}
