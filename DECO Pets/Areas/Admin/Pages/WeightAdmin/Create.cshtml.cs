using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.WeightAdmin
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
        public Weight Weight { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Weights == null || Weight == null)
            {
                return Page();
            }

            _context.Weights.Add(Weight);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
