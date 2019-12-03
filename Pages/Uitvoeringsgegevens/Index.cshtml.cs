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
    public class IndexModel : PageModel
    {
        private readonly WerkbonAppTest3.Data.WerkbonAppTest3Context _context;

        public IndexModel(WerkbonAppTest3.Data.WerkbonAppTest3Context context)
        {
            _context = context;
        }

        public IList<UitvoeringsData> UitvoeringsData { get;set; }

        public async Task OnGetAsync()
        {
            UitvoeringsData = await _context.UitvoeringsData
                .Include(u => u.Medewerker).ToListAsync();
        }
    }
}
