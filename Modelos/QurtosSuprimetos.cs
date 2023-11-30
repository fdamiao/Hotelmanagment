using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public class QurtosSuprimetos:Audit
    {
        public Guid QuratosID { get; set; }
        public Quartos Quartos { get; set; }

        public Guid SupriId { get; set; }
        public Suprimentos Suprimentos { get; set; }
    }
}