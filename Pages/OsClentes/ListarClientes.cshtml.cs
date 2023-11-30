using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelManagment.Modelos;
using Hotelmanagment.Data;

namespace Hotelmanagment.Pages_OsClentes
{
    public class ListarClientesModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ListarClientesModel(Hotelmanagment.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Clientes> Clientes { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Clientes = await _context.Clientes.ToListAsync();
        }
    }
}
