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

namespace DECO_Pets.Areas.Admin.Pages.PremiosAdmin
{
    public class EditModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public EditModel(DECO_Pets.Data.ApplicationDbContext context)
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

            var premios = await _context.Premios.Include(p => p.Dados).FirstOrDefaultAsync(m => m.ID == id);
            if (premios == null)
            {
                return NotFound();
            }
            Premios = premios;
            var dados = _context.Dados.Select(x => new
            {
                ID = x.ID,
                FullName = x.Age.AgeDescription + " - " + x.Species.NameSpecies + " - " + x.Race.Descricao + " - " + x.Weight.WeightDescription
            }).ToList();
            ViewData["DadosID"] = new SelectList(dados, "ID", "FullName");
            var seguradoras = _context.Seguradoras.Select(x => new
            {
                ID = x.ID,
                FullName = x.Nome + " - " + x.Designacao
            });
            ViewData["SeguradoraID"] = new SelectList(seguradoras, "ID", "FullName");
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

            _context.Attach(Premios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PremiosExists(Premios.ID))
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

        private bool PremiosExists(int id)
        {
          return (_context.Premios?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
