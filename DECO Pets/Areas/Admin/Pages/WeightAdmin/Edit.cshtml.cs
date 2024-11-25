using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.WeightAdmin
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
        public Weight Weight { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Weights == null)
            {
                return NotFound();
            }

            var weight =  await _context.Weights.FirstOrDefaultAsync(m => m.ID == id);
            if (weight == null)
            {
                return NotFound();
            }
            Weight = weight;
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

            _context.Attach(Weight).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeightExists(Weight.ID))
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

        private bool WeightExists(int id)
        {
          return (_context.Weights?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
