using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotelManagment.Modelos;
using Hotelmanagment.Data;

namespace Hotelmanagment.Pages_OsClentes
{
    public class CadastrarClientesModel : PageModel
    {
        private readonly Hotelmanagment.Data.ApplicationDbContext _context;

        public CadastrarClientesModel(Hotelmanagment.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Clientes Clientes { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clientes.Add(Clientes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./ListarClientes");
        }
    }
}
