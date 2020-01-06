using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Data
{
    public class WerkbonApplicatieContext : DbContext
    {
        public WerkbonApplicatieContext (DbContextOptions<WerkbonApplicatieContext> options)
            : base(options)
        {
        }

        public DbSet<WerkbonApplicatie.Models.Klant> Klant { get; set; }

        public DbSet<WerkbonApplicatie.Models.Verhuizing> Verhuizing { get; set; }

        public DbSet<WerkbonApplicatie.Models.Personeel> Personeel { get; set; }

        public DbSet<WerkbonApplicatie.Models.Verhuizing_Personeel> Verhuizing_Personeel { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Verhuizing_Personeel>()
                .HasKey(o => new { o.PersoneelID, o.VerhuizingID });
        }
    }
}
