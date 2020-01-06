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
    public class DeleteModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public DeleteModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Verhuizing_Personeel = await _context.Verhuizing_Personeel.FindAsync(id);

            if (Verhuizing_Personeel != null)
            {
                _context.Verhuizing_Personeel.Remove(Verhuizing_Personeel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
