using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public class Tiposdequarto:Audit
    {
        [Required]
        [Display(Name ="Tipo de quarto")]
        public String Tipodquarto { get; set; }
        [Display(Name ="Descricao")]
        public string Descricao { get; set; }
        public ICollection<Quartos> Quartos { get; set; }
    }
}