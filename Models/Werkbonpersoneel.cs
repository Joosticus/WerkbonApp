using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WerkbonApplicatie.Models
{
    public class Werkbonpersoneel
    {
        public int PersoneelID { get; set; }
        public int WerkbonID { get; set; }
        public Personeel personeel { get; set; }
        public Werkbon werkbon { get; set; }
    }
}
