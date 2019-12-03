using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WerkbonAppTest3.Data;
using WerkbonAppTest3.Models;

namespace WerkbonAppTest3.Pages.Klanten
{
    public class CreateModel : PageModel
    {
        private readonly WerkbonAppTest3.Data.WerkbonAppTest3Context _context;

        public CreateModel(WerkbonAppTest3.Data.WerkbonAppTest3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["RekeningID"] = new SelectList(_context.Rekening, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Klant Klant { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Klant.Add(Klant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
