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
    public class IndexModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public IndexModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Age> Age { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Ages != null)
            {
                Age = await _context.Ages.ToListAsync();
            }
        }
    }
}
