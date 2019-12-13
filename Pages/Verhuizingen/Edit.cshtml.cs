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
    public class EditModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public EditModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
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
           ViewData["KlantID"] = new SelectList(_context.Klant, "KlantID", "Klant_Naam");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Verhuizing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VerhuizingExists(Verhuizing.VerhuizingID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VerhuizingExists(int id)
        {
            return _context.Verhuizing.Any(e => e.VerhuizingID == id);
        }
    }
}
