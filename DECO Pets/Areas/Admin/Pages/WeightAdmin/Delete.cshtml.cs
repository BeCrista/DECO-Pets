using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.WeightAdmin
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
      public Weight Weight { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Weights == null)
            {
                return NotFound();
            }

            var weight = await _context.Weights.FirstOrDefaultAsync(m => m.ID == id);

            if (weight == null)
            {
                return NotFound();
            }
            else 
            {
                Weight = weight;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Weights == null)
            {
                return NotFound();
            }
            var weight = await _context.Weights.FindAsync(id);

            if (weight != null)
            {
                Weight = weight;
                _context.Weights.Remove(Weight);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
