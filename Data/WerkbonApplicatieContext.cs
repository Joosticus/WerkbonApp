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

        public DbSet<WerkbonApplicatie.Models.Personeel> Personeel { get; set; }

        public DbSet<WerkbonApplicatie.Models.Werkbon> Werkbon { get; set; }
    }
}
