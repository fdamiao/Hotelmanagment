using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelManagment.Modelos;
using Hotelmanagment.Data;

namespace Hotelmanagment.Pages_OsSuprimentos
{
    public class ListarSuprimentosModel : PageModel
    {
        private readonly Hotelmanagment.Data.ApplicationDbContext _context;

        public ListarSuprimentosModel(Hotelmanagment.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Suprimentos> Suprimentos { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Suprimentos = await _context.Suprimentos.ToListAsync();
        }
    }
}
