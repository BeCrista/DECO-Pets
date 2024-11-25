using DECO_Pets.Data;
using DECO_Pets.Models;
using DECO_Pets.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Linq;

namespace DECO_Pets.Pages
{
    public class ResultadosModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public ResultadosVM ViewModel { get; set; }
        public Seguradora SeguradoraRecomendada { get; set; }

        public ResultadosModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            var t = "";
            var resultados = HttpContext.Session.GetString("Resultados");
            ViewModel = JsonConvert.DeserializeObject<ResultadosVM>(resultados);

            //var seguradoraRecomendadaID = ViewModel.Premios
            //.OrderByDescending(p => p.Premio) // Ordena por prêmio em ordem decrescente
            //.FirstOrDefault()?.SeguradoraID;


            //var recomendada = ViewModel.Premios
            //.OrderByDescending(p => p.Premio) // Ordena por prêmio em ordem decrescente
            //.FirstOrDefault();


            //// Defina a seguradora recomendada como a primeira da lista
            //ViewModel.Premios = ViewModel.Premios.OrderBy(p => p.SeguradoraID != seguradoraRecomendadaID).ThenBy(p => p.Premio).ToList();

            //SeguradoraRecomendada = _context.Seguradoras.FirstOrDefault(s => s.ID == seguradoraRecomendadaID);

        }
        //    public void OnGet(List<Premios> resultados)
        //{
        //    var t = "";
        //    //ViewModel = new ResultadosVM
        //    //{
        //    //    Seguradoras = _context.Seguradoras.ToList(),
        //    //    Premios = _context.Premios.ToList()
        //    //};

        //    //var selectedSpecies = Request.Query["species"];
        //    //var selectedRace = Request.Query["race"];
        //    //var selectedWeight = Request.Query["weight"];
        //    //var selectedAge = Request.Query["age"];

        //    //var seguradorasCorrespondentes = ViewModel.Seguradoras
        //    //    .Where(seguradora =>
        //    //        seguradora.QualidadeDesc == selectedSpecies &&
        //    //        seguradora.Designacao == selectedRace &&
        //    //        seguradora.Responsabilidade_Civil_Franquia == selectedWeight &&
        //    //        seguradora.Cirurgia_Franquia == selectedAge)
        //    //    .ToList();

        //    //if (seguradorasCorrespondentes.Any())
        //    //{
        //    //    SeguradoraRecomendada = seguradorasCorrespondentes
        //    //        .OrderBy(seguradora => ViewModel.Premios
        //    //            .Where(p => p.SeguradoraID == seguradora.ID)
        //    //            .Select(p => p.Premio)
        //    //            .Min())
        //    //        .First();
        //    //}
        //}
    }
}

