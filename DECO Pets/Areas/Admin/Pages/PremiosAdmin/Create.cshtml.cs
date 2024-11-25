using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DECO_Pets.Data;
using DECO_Pets.Models;

namespace DECO_Pets.Areas.Admin.Pages.PremiosAdmin
{
    public class CreateModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public CreateModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
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

        [BindProperty]
        public Premios Premios { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Premios == null || Premios == null)
            {
                return Page();
            }

            _context.Premios.Add(Premios);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
