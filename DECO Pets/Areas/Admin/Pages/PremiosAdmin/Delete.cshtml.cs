using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.Pages.PremiosAdmin
{
    public class DeleteModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public DeleteModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Premios Premios { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Premios == null)
            {
                return NotFound();
            }

            var premios = await _context.Premios
                .Include(d => d.Dados)
                .Include(d => d.Seguradora)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (premios == null)
            {
                return NotFound();
            }
            else 
            {
                Premios = premios;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Premios == null)
            {
                return NotFound();
            }
            var premios = await _context.Premios.FindAsync(id);

            if (premios != null)
            {
                Premios = premios;
                _context.Premios.Remove(Premios);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
