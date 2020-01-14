using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Werkbonpersoneels
{
    public class IndexModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public IndexModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        public IList<Werkbonpersoneel> Werkbonpersoneel { get;set; }

        public async Task OnGetAsync()
        {
            Werkbonpersoneel = await _context.Werkbonpersoneel
                .Include(w => w.personeel)
                .Include(w => w.werkbon).ToListAsync();
        }
    }
}
