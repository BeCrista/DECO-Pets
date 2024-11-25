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

namespace DECO_Pets.Areas.Admin.Pages.DadosAdmin
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
        public Dados Dados { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Dados == null)
            {
                return NotFound();
            }

            var dados = await _context.Dados.Include(d => d.Race).FirstOrDefaultAsync(m => m.ID == id);
            if (dados == null)
            {
                return NotFound();
            }

            ViewData["AgeID"] = new SelectList(_context.Ages, "ID", "AgeDescription", dados.AgeID);
            ViewData["SpeciesID"] = new SelectList(_context.Species, "ID", "NameSpecies", dados.SpeciesID);


            ViewData["RaceID"] = new SelectList(_context.Races, "ID", "Descricao", dados.RaceID);

            ViewData["WeightID"] = new SelectList(_context.Weights, "ID", "WeightDescription", dados.WeightID);
            

            Dados = dados;
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

            if (Dados.SpeciesID != 1 || Dados.RaceID != 1) // Espécie não é "Cão" ou Raça não é "Sem raça definida"
            {
                Dados.WeightID = null; // Definir o valor do peso como nulo
            }

            _context.Attach(Dados).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DadosExists(Dados.ID))
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


        private bool DadosExists(int id)
        {
          return (_context.Dados?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
