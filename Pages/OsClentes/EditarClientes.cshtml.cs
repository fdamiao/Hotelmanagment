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

namespace Hotelmanagment.Pages_OsClentes
{
    public class EditarClientesModel : PageModel
    {
        private readonly Hotelmanagment.Data.ApplicationDbContext _context;

        public EditarClientesModel(Hotelmanagment.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Clientes Clientes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes =  await _context.Clientes.FirstOrDefaultAsync(m => m.Codigo == id);
            if (clientes == null)
            {
                return NotFound();
            }
            Clientes = clientes;
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

            _context.Attach(Clientes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientesExists(Clientes.Codigo))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./ListarClientes");
        }

        private bool ClientesExists(Guid id)
        {
            return _context.Clientes.Any(e => e.Codigo == id);
        }
    }
}
