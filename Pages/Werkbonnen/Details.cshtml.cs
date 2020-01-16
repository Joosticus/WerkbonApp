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
    public class DetailsModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public DetailsModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        public IList<Werkbonpersoneel> Werkbonpersoneels { get; set; }
        public Werkbon Werkbon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Werkbonpersoneels = await _context.Werkbonpersoneel
                .Include(w => w.personeel)
                .Include(w => w.werkbon).ToListAsync();

            if (id == null)
            {
                return NotFound();
            }

            Werkbon = await _context.Werkbon.FirstOrDefaultAsync(m => m.WerkbonID == id);

            if (Werkbon == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
