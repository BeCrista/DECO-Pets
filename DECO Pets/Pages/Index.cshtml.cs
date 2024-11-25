using DECO_Pets.Data;
using DECO_Pets.Models;
using DECO_Pets.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DECO_Pets.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;
        [BindProperty]
        public HomepageVM ViewModels { get; set; }

        public SelectList Species { get; set; }
        public SelectList Races { get; set; }
        public SelectList Weights { get; set; }
        public SelectList Ages { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            ViewModels = new HomepageVM
            { 
                //Races = _context.Races.ToList(),
                //Weights = _context.Weights.ToList(),
                //Ages = _context.Ages.ToList()
            };

            ViewData["SpeciesID"] = new SelectList(_context.Species, "ID", "NameSpecies");
            ViewData["WeightID"] = new SelectList(_context.Weights, "ID", "WeightDescription");
            ViewData["AgeID"] = new SelectList(_context.Ages, "ID", "AgeDescription");

            //var dogRacesToIDs = _context.Races
            //.Select(r => r.DogRaces)
            //.Distinct()
            //.ToDictionary(dogRace => dogRace, dogRace => dogRace);
            //var catRacesToIDs = _context.Races
            //    .Select(r => r.CatRaces)
            //    .Distinct()
            //    .ToDictionary(catRace => catRace, catRace => catRace);
            //ViewData["DogRacesToIDs"] = dogRacesToIDs;
            //ViewData["CatRacesToIDs"] = catRacesToIDs;
        }

        public JsonResult OnGetRacas(int id)

        {

            return new JsonResult(_context.Races.Where(r => r.EspeciesID == id).Select(r => new { id = r.ID, descricao = r.Descricao }));

        }

        public IActionResult OnPostSimularAsync()
        {

            ResultadosVM resultadosVM = new ResultadosVM();

            foreach (var item in _context.Seguradoras.ToList()) {
                // Consultar os dados correspondentes aos critérios selecionados
                var dadosCorrespondentes = _context.Premios
                    .Include(d => d.Dados)
                    .Include(d => d.Dados.Race)
                    .Include(d => d.Dados.Age)
                    .Include(d => d.Dados.Species)
                    .Include(d => d.Dados.Weight)
                    //.Include(d => d.Seguradora)
                    .Where(d =>
                        d.Dados.SpeciesID == ViewModels.SpeciesID &&
                        d.Dados.RaceID == ViewModels.RaceID &&
                        (d.Dados.WeightID == ViewModels.WeightID || ViewModels.WeightID == null || ViewModels.WeightID == 0) &&
                        d.Dados.AgeID == ViewModels.AgeID &&
                        d.SeguradoraID == item.ID)
                    .FirstOrDefault();
                if (dadosCorrespondentes != null)
                {
                    resultadosVM.Premios.Add(dadosCorrespondentes);
                }
            }

            HttpContext.Session.SetString("Resultados", JsonConvert.SerializeObject(resultadosVM));

            return RedirectToPage("/Resultados");
        }

    }
}