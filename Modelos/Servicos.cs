using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public class Servicos:Audit
    {
        [Required]
        public string NomeServico { get; set; }
        public bool Estado { get; set; }
    }
}