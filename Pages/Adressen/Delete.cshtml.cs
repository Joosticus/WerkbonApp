using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Adressen
{
    public class DeleteModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public DeleteModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Adres Adres { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Adres = await _context.Adres
                .Include(a => a.Verhuizing).FirstOrDefaultAsync(m => m.AdresID == id);

            if (Adres == null)
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

            Adres = await _context.Adres.FindAsync(id);

            if (Adres != null)
            {
                _context.Adres.Remove(Adres);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
