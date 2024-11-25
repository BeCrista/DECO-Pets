using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.Pages.DadosAdmin
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
      public Dados Dados { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Dados == null)
            {
                return NotFound();
            }

            var dados = await _context.Dados
                .Include(d => d.Species)
                .Include(d => d.Race)
                .Include(d => d.Weight)
                .Include(d => d.Age)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (dados == null)
            {
                return NotFound();
            }
            else
            {
                Dados = dados;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Dados == null)
            {
                return NotFound();
            }
            var dados = await _context.Dados.FindAsync(id);

            if (dados != null)
            {
                Dados = dados;
                _context.Dados.Remove(Dados);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
