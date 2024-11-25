using DECO_Pets.Data;
using DECO_Pets.Models;
using DECO_Pets.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DECO_Pets.Pages
{
    public class DetalhesModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetalhesModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Seguradora Seguradora { get; set; } = default!;

        public Premios Premios { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Seguradoras == null)
            {
                return NotFound();
            }
            var resultados = HttpContext.Session.GetString("Resultados");
            var objResultados = JsonConvert.DeserializeObject<ResultadosVM>(resultados);
            Premios = objResultados.Premios.Where(x => x.ID == id).FirstOrDefault();
            return Page();
        }
    }
}
