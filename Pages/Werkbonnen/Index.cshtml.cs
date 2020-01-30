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
            // Get all Personeel for filter list
            Personeel = await _context.Personeel.ToListAsync();

            // Get all werkbonnen
            var werkbonnen = from m in _context.Werkbon
                               select m;

            // If searchstring is not empty do function
            if (!string.IsNullOrEmpty(SearchString))
            {
                // Convert searchstring to datetime
                var datetimeSearch = DateTime.Parse(SearchString);

                // Get werkbonnen where werkbon date is same as searched date.
                werkbonnen = werkbonnen.Where(s => s.Datum == datetimeSearch);
            }

            Werkbon = await werkbonnen.ToListAsync();
        }
        public IList<Personeel> Personeel { get; set; }
        [BindProperty]
        public string selectedFilter { get; set; }

    }
}
