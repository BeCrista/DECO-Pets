using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.RaceAdmin
{
    public class DetailsModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public DetailsModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Race Race { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Races == null)
            {
                return NotFound();
            }

            var race = await _context.Races.FirstOrDefaultAsync(m => m.ID == id);
            if (race == null)
            {
                return NotFound();
            }
            else 
            {
                Race = race;
            }
            return Page();
        }
    }
}
