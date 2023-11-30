using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelManagment.Modelos;
using Hotelmanagment.Data;

namespace Hotelmanagment.Pages_Categorias
{
    public class EditarTiposModel : PageModel
    {
        private readonly Hotelmanagment.Data.ApplicationDbContext _context;

        public EditarTiposModel(Hotelmanagment.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tiposdequarto Tiposdequarto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposdequarto =  await _context.Tiposdequarto.FirstOrDefaultAsync(m => m.Codigo == id);
            if (tiposdequarto == null)
            {
                return NotFound();
            }
            Tiposdequarto = tiposdequarto;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Tiposdequarto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposdequartoExists(Tiposdequarto.Codigo))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./ListarTipos");
        }

        private bool TiposdequartoExists(Guid id)
        {
            return _context.Tiposdequarto.Any(e => e.Codigo == id);
        }
    }
}
