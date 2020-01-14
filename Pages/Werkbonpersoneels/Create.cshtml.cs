using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Werkbonpersoneels
{
    public class CreateModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public CreateModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PersoneelID"] = new SelectList(_context.Personeel, "PersoneelID", "Username");
        ViewData["WerkbonID"] = new SelectList(_context.Werkbon, "WerkbonID", "Klant_Naam");
            return Page();
        }

        [BindProperty]
        public Werkbonpersoneel Werkbonpersoneel { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Werkbonpersoneel.Add(Werkbonpersoneel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
