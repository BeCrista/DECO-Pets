﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.SpeciesAdmin
{
    [Area("Admin")]
    public class EditModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public EditModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Species Species { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Species == null)
            {
                return NotFound();
            }

            var species =  await _context.Species.FirstOrDefaultAsync(m => m.ID == id);
            if (species == null)
            {
                return NotFound();
            }
            Species = species;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Species).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpeciesExists(Species.ID))
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

        private bool SpeciesExists(int id)
        {
          return (_context.Species?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}