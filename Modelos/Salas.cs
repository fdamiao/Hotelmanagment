using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public class Salas:Audit
    {
        [Display(Name ="Saloes")]
        
[Required]   
        public String Tiposala { get; set; }
        
[Required]   
        public double Valor { get; set; }=0;
        public string Descricao { get; set; }
        public string Fotosaloes { get; set; }
         public ICollection<SalasSuprimetos> Suprimetoss { get; set; }

      
    }
}