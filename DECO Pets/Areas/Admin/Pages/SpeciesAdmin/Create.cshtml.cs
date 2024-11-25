using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.SpeciesAdmin
{
    [Area("Admin")]
    public class CreateModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public CreateModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Species Species { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Species == null || Species == null)
            {
                return Page();
            }

            _context.Species.Add(Species);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
