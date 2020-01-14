using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WerkbonApplicatie.Data;
using WerkbonApplicatie.Models;

namespace WerkbonApplicatie.Pages.Werkbonnen
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
            return Page();
        }

        [BindProperty]
        public Werkbon Werkbon { get; set; }




        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            var base64Signature = Werkbon.Image.Split(",")[1];
            var binarySignature = Convert.FromBase64String(base64Signature);
          
            System.IO.File.WriteAllBytes("wwwroot/images/" + Werkbon.Guid + ".png", binarySignature);

            var base64SignatureSecond = Werkbon.ImageSecond.Split(",")[1];
            var binarySignatureSecond = Convert.FromBase64String(base64SignatureSecond);

            System.IO.File.WriteAllBytes("wwwroot/images/" + Werkbon.GuidSecond + ".png", binarySignatureSecond);

            _context.Werkbon.Add(Werkbon);
            await _context.SaveChangesAsync();


            return RedirectToPage("./Werknemer", new {id = Werkbon.WerkbonID});
        }

    }
}
