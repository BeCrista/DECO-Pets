using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.AgeAdmin
{
    [Area("Admin")]
    public class DetailsModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public DetailsModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Age Age { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ages == null)
            {
                return NotFound();
            }

            var age = await _context.Ages.FirstOrDefaultAsync(m => m.ID == id);
            if (age == null)
            {
                return NotFound();
            }
            else 
            {
                Age = age;
            }
            return Page();
        }
    }
}
