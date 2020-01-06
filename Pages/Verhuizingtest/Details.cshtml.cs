using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Verhuizingtest
{
    public class DetailsModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public DetailsModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        public Verhuizing_Personeel Verhuizing_Personeel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Verhuizing_Personeel = await _context.Verhuizing_Personeel
                .Include(v => v.personeel)
                .Include(v => v.verhuizing).FirstOrDefaultAsync(m => m.PersoneelID == id);

            if (Verhuizing_Personeel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
