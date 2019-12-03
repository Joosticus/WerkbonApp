using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WerkbonAppTest3.Data;
using WerkbonAppTest3.Models;

namespace WerkbonAppTest3.Pages.Uitvoeringsgegevens
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
        ViewData["MedewerkerID"] = new SelectList(_context.Medewerker, "ID", "Name");
            return Page();
        }

        [BindProperty]
        public UitvoeringsData UitvoeringsData { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.UitvoeringsData.Add(UitvoeringsData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
