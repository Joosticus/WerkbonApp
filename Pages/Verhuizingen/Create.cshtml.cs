using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Verhuizingen
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
        ViewData["KlantID"] = new SelectList(_context.Klant, "KlantID", "KlantID");
            return Page();
        }

        
        [BindProperty]
        public Verhuizing Verhuizing { get; set; }
        [BindProperty]
        public Klant Klant { get; set; }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            _context.Verhuizing.Add(Verhuizing);
            _context.Klant.Add(Klant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
