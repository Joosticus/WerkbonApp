using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WerkbonAppTest3.Models
{
    public class UitvoeringsData
    {
        public int ID { get; set; }
        public int MedewerkerID { get; set; }
        [DataType(DataType.Time)]
        public DateTime Vertrekuur { get; set; }
        public int Inpakuren { get; set; }
        public int Montageuren { get; set; }
        public int Aantal_Laden { get; set; }
        [DataType(DataType.Time)]
        public DateTime Start_Laden { get; set; }
        [DataType(DataType.Time)]
        public DateTime Eind_Laden { get; set; }
        public int Laaduren { get; set; }

        public int Aantal_Lossen { get; set; }
        [DataType(DataType.Time)]
        public DateTime Start_Lossen { get; set; }
        [DataType(DataType.Time)]
        public DateTime Eind_Lossen { get; set; }
        public int Losuren { get; set; }
        [DataType(DataType.Time)]
        public DateTime Aankomst_Tijd { get; set; }

        public Medewerker Medewerker { get; set; }

    }
}
