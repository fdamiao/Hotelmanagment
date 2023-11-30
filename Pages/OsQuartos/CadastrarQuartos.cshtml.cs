using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotelManagment.Modelos;
using Hotelmanagment.Data;
using Microsoft.EntityFrameworkCore;

namespace Hotelmanagment.Pages_OsQuartos
{
    public class CadastrarQuartosModel : PageModel
    {
        private readonly Hotelmanagment.Data.ApplicationDbContext _context;

        public CadastrarQuartosModel(Hotelmanagment.Data.ApplicationDbContext context)
        {
            _context = context;
        }
public List<SelectListItem> customerList { get; set; }
public List<SelectListItem> LSuprimentos { get; set; }
        public async Task< IActionResult> OnGet()
        {

 customerList = await (from p in _context.Tiposdequarto
                                                select new SelectListItem
                                                {
                                                    Text = p.Descricao,
                                                    Value = p.Codigo.ToString()
                                                }).ToListAsync();

 LSuprimentos = await (from p in _context.Suprimentos
                                                select new SelectListItem
                                                {
                                                    Text = p.Suprimento,
                                                    Value = p.Codigo.ToString()
                                                }).ToListAsync();
 
 

      
           
          //Add Default Item at First Position.
         //   customerList.Insert(0, new SelectListItem { Text = "--Select categoria--", Value = "" });
 
       

            ViewData["tpquarto"] = customerList;
            return Page();
        }

        [BindProperty]
        public Quartos Quartos { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.quartos.Add(Quartos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./ListarQuartos");
        }
    }
}
