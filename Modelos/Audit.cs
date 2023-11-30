using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public abstract class Audit
    {
        public Audit()
        {
            DataCreat=DateTime.Now;
            Usercreat="Nosso hotel";
        }
[Key]
       public Guid Codigo { get; set; }
        public DateTime DataCreat { get; set; }
        public string Usercreat { get; set; }

    }
}