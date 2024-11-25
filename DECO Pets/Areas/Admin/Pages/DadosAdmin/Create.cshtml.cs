using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.Pages.DadosAdmin
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
            Dados = new Dados(); // Inicialize a propriedade Dados
            ViewData["AgeID"] = new SelectList(_context.Ages, "ID", "AgeDescription");
            ViewData["RaceID"] = new SelectList(_context.Races, "ID", "Descricao");
            ViewData["SpeciesID"] = new SelectList(_context.Species, "ID", "NameSpecies");
            ViewData["WeightID"] = new SelectList(_context.Weights, "ID", "WeightDescription");

            return Page();
        }

        public JsonResult OnGetRacesBySpecies(int speciesId)
        {
            IQueryable<Race> races;

            if (speciesId == 1) // Cão
            {
                races = _context.Races.Select(r => new Race { ID = r.ID, Descricao = r.Descricao });
            }
            else if (speciesId == 2) // Gato
            {
                races = _context.Races.Select(r => new Race { ID = r.ID, Descricao = r.Descricao });
            }
            else
            {
                return new JsonResult(new List<Race>());
            }

            return new JsonResult(races);
        }


        [BindProperty]
        public Dados Dados { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Dados == null || Dados == null)
            {
                // Iterar por cada erro de validação e coletar informações
                var validationErrors = ModelState.Values.SelectMany(v => v.Errors);

                foreach (var error in validationErrors)
                {
                    var errorMessage = error.ErrorMessage;
                    // Você pode fazer o que quiser com a mensagem de erro, como adicioná-la a uma lista, logar, etc.
                }

                return Page();
            }

            // Verifique se a espécie é um cão e se a raça é "Sem raça definida"
            if (Dados.SpeciesID == 1 && Dados.RaceID == 1)
            {
                // Verifique se o campo de peso está preenchido
                if (Dados.WeightID == null)
                {
                    ModelState.AddModelError("Dados.WeightID", "Weight is required for selected species and race.");
                    return Page();
                }
            }

            _context.Dados.Add(Dados);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
