using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.SpeciesAdmin
{
    [Area("Admin")]
    public class DeleteModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public DeleteModel(DECO_Pets.Data.ApplicationDbContext context)
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

            var species = await _context.Species.FirstOrDefaultAsync(m => m.ID == id);

            if (species == null)
            {
                return NotFound();
            }
            else 
            {
                Species = species;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Species == null)
            {
                return NotFound();
            }
            var species = await _context.Species.FindAsync(id);

            if (species != null)
            {
                Species = species;
                _context.Species.Remove(Species);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
