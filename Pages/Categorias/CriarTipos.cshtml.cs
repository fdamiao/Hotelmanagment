using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotelManagment.Modelos;
using Hotelmanagment.Data;

namespace Hotelmanagment.Pages_Categorias
{
    public class CriarTiposModel : PageModel
    {
        private readonly Hotelmanagment.Data.ApplicationDbContext _context;

        public CriarTiposModel(Hotelmanagment.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tiposdequarto Tiposdequarto { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tiposdequarto.Add(Tiposdequarto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./ListarTipos");
        }
    }
}
