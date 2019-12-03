using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WerkbonAppTest3.Models
{
    public class Klant
    {
        public int ID { get; set; }
        public int RekeningID { get; set; }
        public string Naam { get; set; }
        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }
        public string Contactpersoon { get; set; }
        [Display(Name = "Rekeningbedrag")]
        public Rekening Rekening { get; set; }
    }
}
