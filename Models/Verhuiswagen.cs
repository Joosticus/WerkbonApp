using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WerkbonAppTest3.Models
{
    public class Verhuiswagen
    {
        public int ID { get; set; }
        public string Kenteken { get; set; }
        public int Volume { get; set; }
        public string Merknaam { get; set; }
    }
}
