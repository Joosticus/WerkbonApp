using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WerkbonAppTest3.Data;
using WerkbonAppTest3.Models;

namespace WerkbonAppTest3.Pages.Uitvoeringsgegevens
{
    public class DetailsModel : PageModel
    {
        private readonly WerkbonAppTest3.Data.WerkbonAppTest3Context _context;

        public DetailsModel(WerkbonAppTest3.Data.WerkbonAppTest3Context context)
        {
            _context = context;
        }

        public UitvoeringsData UitvoeringsData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UitvoeringsData = await _context.UitvoeringsData
                .Include(u => u.Medewerker).FirstOrDefaultAsync(m => m.ID == id);

            if (UitvoeringsData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
