using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages
{
    public class WerknemerModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public WerknemerModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }
        public IList<Werkbonpersoneel> Werkbonpersoneels { get; set; }

        

        [BindProperty]
        public Werkbonpersoneel Werkbonpersoneel { get; set; }

        /// <summary>
        /// Haalt de personeelslijst en de werkbonlijst op
        /// </summary>
        public async Task OnGetAsync()
        {
            ViewData["PersoneelID"] = new SelectList(_context.Personeel, "PersoneelID", "Pesoneel_VoorNaam");
            ViewData["WerkbonID"] = new SelectList(_context.Werkbon, "WerkbonID", "Klant_Naam");

            Werkbonpersoneels = await _context.Werkbonpersoneel
                .Include(w => w.personeel)
                .Include(w => w.werkbon).ToListAsync();
        }
        /// <summary>
        /// Slaat de werknemer op in combinatie met de werkbon.
        /// </summary>
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Werkbonpersoneel.Add(Werkbonpersoneel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Werknemer");
        }
    }
}