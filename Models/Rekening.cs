using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WerkbonAppTest3.Models
{
    public class Rekening
    {
        public int ID { get; set; }
        public int Bedrag { get; set; }
        public string Betaalmethode { get; set; }
    }
}
