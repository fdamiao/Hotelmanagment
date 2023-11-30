using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelManagment.Modelos;
using Hotelmanagment.Data;

namespace Hotelmanagment.Pages_Categorias
{
    public class ListarTiposModel : PageModel
    {
        private readonly Hotelmanagment.Data.ApplicationDbContext _context;

        public ListarTiposModel(Hotelmanagment.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Tiposdequarto> Tiposdequarto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Tiposdequarto = await _context.Tiposdequarto.ToListAsync();
        }
    }
}
