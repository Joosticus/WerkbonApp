using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Verhuizingen
{
    public class IndexModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public IndexModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        public IList<Verhuizing> Verhuizing { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Klantnaam { get; set; }

        public async Task OnGetAsync()
        {

            Verhuizing = await _context.Verhuizing
                .Include(v => v.Klant).ToListAsync();

            var verhuizingen = from m in _context.Verhuizing
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                verhuizingen = verhuizingen.Where(s => s.Klant.Klant_Naam.Contains(SearchString) || s.Betaling.ToString().Contains(SearchString) || s.Datum.ToString().Contains(SearchString));
            }

            Verhuizing = await verhuizingen.ToListAsync();
        }
    }
}
