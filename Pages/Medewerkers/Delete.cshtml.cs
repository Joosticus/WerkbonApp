using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WerkbonAppTest3.Data;
using WerkbonAppTest3.Models;

namespace WerkbonAppTest3.Pages.Medewerkers
{
    public class DeleteModel : PageModel
    {
        private readonly WerkbonAppTest3.Data.WerkbonAppTest3Context _context;

        public DeleteModel(WerkbonAppTest3.Data.WerkbonAppTest3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Medewerker Medewerker { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medewerker = await _context.Medewerker.FirstOrDefaultAsync(m => m.ID == id);

            if (Medewerker == null)
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

            Medewerker = await _context.Medewerker.FindAsync(id);

            if (Medewerker != null)
            {
                _context.Medewerker.Remove(Medewerker);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
