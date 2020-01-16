using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Werkbonnen
{
    public class EditModel : PageModel
    {
        private readonly WerkbonApplicatie.Data.WerkbonApplicatieContext _context;

        public EditModel(WerkbonApplicatie.Data.WerkbonApplicatieContext context)
        {
            _context = context;
        }

        public IList<Werkbonpersoneel> Werkbonpersoneels { get; set; }

        [BindProperty]
        public Werkbon Werkbon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Werkbonpersoneels = await _context.Werkbonpersoneel
                .Include(w => w.personeel)
                .Include(w => w.werkbon).ToListAsync();

            if (id == null)
            {
                return NotFound();
            }

            Werkbon = await _context.Werkbon.FirstOrDefaultAsync(m => m.WerkbonID == id);

            if (Werkbon == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Werkbon).State = EntityState.Modified;

            try
            {
                if (!String.IsNullOrEmpty(Werkbon.Image))
                {
                    var base64Signature = Werkbon.Image.Split(",")[1];
                    var binarySignature = Convert.FromBase64String(base64Signature);

                    System.IO.File.WriteAllBytes("wwwroot/images/" + Werkbon.Guid + ".png", binarySignature);
                }

                if (!String.IsNullOrEmpty(Werkbon.ImageSecond))
                {
                    var base64SignatureSecond = Werkbon.ImageSecond.Split(",")[1];
                    var binarySignatureSecond = Convert.FromBase64String(base64SignatureSecond);

                    System.IO.File.WriteAllBytes("wwwroot/images/" + Werkbon.GuidSecond + ".png", binarySignatureSecond);
                }

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WerkbonExists(Werkbon.WerkbonID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool WerkbonExists(int id)
        {
            return _context.Werkbon.Any(e => e.WerkbonID == id);
        }
    }
}
