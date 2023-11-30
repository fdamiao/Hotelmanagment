using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelManagment.Modelos;
using Hotelmanagment.Data;

namespace Hotelmanagment.Pages_OsQuartos
{
    public class ListarQuartosModel : PageModel
    {
        private readonly Hotelmanagment.Data.ApplicationDbContext _context;

        public ListarQuartosModel(Hotelmanagment.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Quartos> Quartos { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Quartos = await _context.quartos.ToListAsync();
        }
    }
}
