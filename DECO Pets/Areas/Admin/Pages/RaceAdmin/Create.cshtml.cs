using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.RaceAdmin
{
    public class CreateModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public CreateModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Race = new Race();
            ViewData["EspeciesID"] = new SelectList(_context.Species, "ID", "NameSpecies");
            return Page();
        }

        [BindProperty]
        public Race Race { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Races == null || Race == null)
            {
                return Page();
            }

            _context.Races.Add(Race);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
