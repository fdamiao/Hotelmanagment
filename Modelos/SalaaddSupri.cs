using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public class SalaaddSupri:Audit
    {

[Required]        public String Suprimento { get; set; }
        //public String Suprimento { get; set; }
        public ICollection<SalasSuprimetos> Suprimetoss { get; set; }
    }
}