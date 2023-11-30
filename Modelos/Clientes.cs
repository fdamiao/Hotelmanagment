using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public class Clientes:Audit
    {
        public int CodigoCLi { get; set; }
        public String Nome { get; set; }
        public string Ntelefone { get; set; }
        public string Nacionalidade { get; set; }
    }
}