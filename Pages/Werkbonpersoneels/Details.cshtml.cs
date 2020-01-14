using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Werkbonpersoneels
{
    public class DetailsModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public DetailsModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        public Werkbonpersoneel Werkbonpersoneel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Werkbonpersoneel = await _context.Werkbonpersoneel
                .Include(w => w.personeel)
                .Include(w => w.werkbon).FirstOrDefaultAsync(m => m.PersoneelID == id);

            if (Werkbonpersoneel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
