using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Verhuizingtest
{
    public class IndexModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public IndexModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        public IList<Verhuizing_Personeel> Verhuizing_Personeel { get;set; }

        public async Task OnGetAsync()
        {
            Verhuizing_Personeel = await _context.Verhuizing_Personeel
                .Include(v => v.personeel)
                .Include(v => v.verhuizing).ToListAsync();
        }
    }
}
