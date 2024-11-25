using System.Linq;
using DECO_Pets.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DECO_Pets.Areas.Admin.Pages.PremiosAdmin
{
    public class IndexModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;

        public IndexModel(DECO_Pets.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PremiosViewModel> PremiosViewModelList { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Premios != null)
            {
                PremiosViewModelList = await _context.Premios
                    .Include(p => p.Dados)
                    .Include(p => p.Seguradora)
                    .Select(p => new PremiosViewModel
                    {
                        ID = p.ID,
                        DadosInfo = $"{p.Dados.Age.AgeDescription} - {p.Dados.Species.NameSpecies} - {p.Dados.Race.Descricao} - {p.Dados.Weight.WeightDescription}",
                        SeguradoraInfo = $"{p.Seguradora.Nome} - {p.Seguradora.Designacao}",
                        Premio = p.Premio.ToString()
                    })
                    .ToListAsync();
            }
        }

        public class PremiosViewModel
        {
            public int ID { get; set; }
            public string DadosInfo { get; set; }
            public string SeguradoraInfo { get; set; }
            public string Premio { get; set; }
        }
    }
}
