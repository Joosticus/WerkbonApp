using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WerkbonAppTest3.Models;

namespace WerkbonAppTest3.Data
{
    public class WerkbonAppTest3Context : DbContext
    {
        public WerkbonAppTest3Context (DbContextOptions<WerkbonAppTest3Context> options)
            : base(options)
        {
        }

        public DbSet<WerkbonAppTest3.Models.Medewerker> Medewerker { get; set; }

        public DbSet<WerkbonAppTest3.Models.UitvoeringsData> UitvoeringsData { get; set; }

        public DbSet<WerkbonAppTest3.Models.Rekening> Rekening { get; set; }

        public DbSet<WerkbonAppTest3.Models.Klant> Klant { get; set; }

        public DbSet<WerkbonAppTest3.Models.Ongeluk> Ongeluk { get; set; }

        public DbSet<WerkbonAppTest3.Models.Verhuiswagen> Verhuiswagen { get; set; }

        public DbSet<WerkbonAppTest3.Models.Laadadres> Laadadres { get; set; }

        public DbSet<WerkbonAppTest3.Models.Losadres> Losadres { get; set; }

        public DbSet<WerkbonAppTest3.Models.Werkbon> Werkbon { get; set; }
    }
}
