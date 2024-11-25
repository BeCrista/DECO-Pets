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
    public class SeguradoraPremiosModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public SeguradoraPremiosModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<SeguradorasPremiosViewModel> seguradorasPremiosViewModel { get; set; } = new List<SeguradorasPremiosViewModel>();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premiosSeguradoras = await _context.Premios
                .Include(p => p.Seguradora)
                .Include(p => p.Dados)
                .Where(p => p.Seguradora.ID == id)
                .Select(p => new SeguradorasPremiosViewModel
                {
                    DadosInfo = $"{p.Dados.Age.AgeDescription} - {p.Dados.Species.NameSpecies} - {p.Dados.Race.Descricao} - {p.Dados.Weight.WeightDescription}",
                    Premio = p.Premio.ToString()
                })
                .ToListAsync();

            if (premiosSeguradoras == null)
            {
                return NotFound();
            }

            seguradorasPremiosViewModel = premiosSeguradoras;
            return Page();
        }

        public class SeguradorasPremiosViewModel
        {
            public string DadosInfo { get; set; }
            public string Premio { get; set; }
        }
    }
}
