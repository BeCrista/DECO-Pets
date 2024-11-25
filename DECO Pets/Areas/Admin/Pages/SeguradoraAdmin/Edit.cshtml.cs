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

namespace DECO_Pets.Areas.Admin.Pages.SeguradoraAdmin
{
    public class EditModel : PageModel
    {
        private readonly DECO_Pets.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EditModel(DECO_Pets.Data.ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public Seguradora Seguradora { get; set; } = default!;

        [BindProperty]
        public IFormFile ImageFile { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Seguradoras == null)
            {
                return NotFound();
            }

            var seguradora =  await _context.Seguradoras.FirstOrDefaultAsync(m => m.ID == id);
            if (seguradora == null)
            {
                return NotFound();
            }
            Seguradora = seguradora;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var validationErrors = ModelState.Values.SelectMany(v => v.Errors);

                foreach (var error in validationErrors)
                {
                    var errorMessage = error.ErrorMessage;
                    // Você pode fazer o que quiser com a mensagem de erro, como adicioná-la a uma lista, logar, etc.
                }
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

            _context.Attach(Seguradora).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeguradoraExists(Seguradora.ID))
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

        private bool SeguradoraExists(int id)
        {
          return (_context.Seguradoras?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
