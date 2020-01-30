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
    public class DeleteModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public DeleteModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Werkbon Werkbon { get; set; }

        /// <summary>
        /// Haalt de geselcteerde werkbon op via de ID 
        /// </summary>
        public async Task<IActionResult> OnGetAsync(int? id)
        {
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

        /// <summary>
        /// Verwijdert de werkbon met de desbetreffende ID
        /// </summary>
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Werkbon = await _context.Werkbon.FindAsync(id);

            if (Werkbon != null)
            {
                _context.Werkbon.Remove(Werkbon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
