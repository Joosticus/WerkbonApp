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

namespace WerkbonApplicatie.Pages.Verhuizingtest
{
    public class EditModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public EditModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
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
           ViewData["PersoneelID"] = new SelectList(_context.Personeel, "PersoneelID", "PersoneelID");
           ViewData["VerhuizingID"] = new SelectList(_context.Verhuizing, "VerhuizingID", "VerhuizingID");
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

            _context.Attach(Verhuizing_Personeel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Verhuizing_PersoneelExists(Verhuizing_Personeel.PersoneelID))
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

        private bool Verhuizing_PersoneelExists(int id)
        {
            return _context.Verhuizing_Personeel.Any(e => e.PersoneelID == id);
        }
    }
}
