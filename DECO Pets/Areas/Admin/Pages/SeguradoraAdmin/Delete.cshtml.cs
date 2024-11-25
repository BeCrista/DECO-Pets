using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.Pages.SeguradoraAdmin
{
    public class DeleteModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public DeleteModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Seguradora Seguradora { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Seguradoras == null)
            {
                return NotFound();
            }

            var seguradora = await _context.Seguradoras.FirstOrDefaultAsync(m => m.ID == id);

            if (seguradora == null)
            {
                return NotFound();
            }
            else 
            {
                Seguradora = seguradora;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Seguradoras == null)
            {
                return NotFound();
            }
            var seguradora = await _context.Seguradoras.FindAsync(id);

            if (seguradora != null)
            {
                Seguradora = seguradora;
                _context.Seguradoras.Remove(Seguradora);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
