using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DECO_Pets.Data;
using DECO_Pets.Models;
using Microsoft.AspNetCore.Hosting;

namespace DECO_Pets.Areas.Admin.Pages.SeguradoraAdmin
{
    public class CreateModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CreateModel(DECO_Pets.Data.ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Seguradora Seguradora { get; set; } = default!;

        [BindProperty]
        public IFormFile ImageFile { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Seguradoras == null || Seguradora == null)
            {
                return Page();
            }

            if (ImageFile != null)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string pathImagem = Path.Combine(wwwRootPath, @"Images/Seguradoras");
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(ImageFile.FileName);

                // Salvar a imagem no servidor
                using (var fileStream = new FileStream(Path.Combine(pathImagem, uniqueFileName), FileMode.Create))
                {
                    ImageFile.CopyTo(fileStream);
                }

                // Set the ImagemSeguradora property
                Seguradora.ImagemSeguradora = @"\Images\Seguradoras\" + uniqueFileName;
            }

            _context.Seguradoras.Add(Seguradora);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
