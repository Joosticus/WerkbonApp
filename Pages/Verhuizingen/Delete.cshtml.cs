using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Verhuizingen
{
    public class DeleteModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public DeleteModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Verhuizing Verhuizing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Verhuizing = await _context.Verhuizing
                .Include(v => v.Klant).FirstOrDefaultAsync(m => m.VerhuizingID == id);

            if (Verhuizing == null)
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

            Verhuizing = await _context.Verhuizing.FindAsync(id);

            if (Verhuizing != null)
            {
                _context.Verhuizing.Remove(Verhuizing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
