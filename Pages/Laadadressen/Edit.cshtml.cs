﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WerkbonAppTest3.Data;
using WerkbonAppTest3.Models;

namespace WerkbonAppTest3.Pages.Laadadressen
{
    public class EditModel : PageModel
    {
        private readonly WerkbonAppTest3.Data.WerkbonAppTest3Context _context;

        public EditModel(WerkbonAppTest3.Data.WerkbonAppTest3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Laadadres Laadadres { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Laadadres = await _context.Laadadres.FirstOrDefaultAsync(m => m.ID == id);

            if (Laadadres == null)
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

            _context.Attach(Laadadres).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaadadresExists(Laadadres.ID))
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

        private bool LaadadresExists(int id)
        {
            return _context.Laadadres.Any(e => e.ID == id);
        }
    }
}