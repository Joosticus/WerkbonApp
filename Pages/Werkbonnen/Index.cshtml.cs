using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Werkbonnen
{
    public class IndexModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public IndexModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        public IList<Werkbon> Werkbon { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {
            // Get all werbonnen
            var werkbonnen = from m in _context.Werkbon
                               select m;

            // If searchstring is not empty do function
            if (!string.IsNullOrEmpty(SearchString))
            {
                // Search where searchstring is klantnaam, bedrag or datum
                werkbonnen = werkbonnen.Where(s => s.Klant_Naam.Contains(SearchString) || s.Telefoonnummer.ToString().Contains(SearchString) || s.Datum.ToString().Contains(SearchString));
            }

            Werkbon = await werkbonnen.ToListAsync();
        }
    }
}
