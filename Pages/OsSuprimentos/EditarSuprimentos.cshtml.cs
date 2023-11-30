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

namespace Hotelmanagment.Pages_OsSuprimentos
{
    public class EditarSuprimentosModel : PageModel
    {
        private readonly Hotelmanagment.Data.ApplicationDbContext _context;

        public EditarSuprimentosModel(Hotelmanagment.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Suprimentos Suprimentos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suprimentos =  await _context.Suprimentos.FirstOrDefaultAsync(m => m.Codigo == id);
            if (suprimentos == null)
            {
                return NotFound();
            }
            Suprimentos = suprimentos;
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

            _context.Attach(Suprimentos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SuprimentosExists(Suprimentos.Codigo))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./ListarSuprimentos");
        }

        private bool SuprimentosExists(Guid id)
        {
            return _context.Suprimentos.Any(e => e.Codigo == id);
        }
    }
}
