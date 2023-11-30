using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public class SalasSuprimetos:Audit
    {
        public Guid CodSalas { get; set; }
        public Salas Quartos { get; set; }

        public Guid SupriId { get; set; }
        public SalasSuprimetos Suprimentos { get; set; }
    }
}