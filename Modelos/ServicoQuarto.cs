using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public class ServicoQuarto:Audit
    {
        public Guid TipoquartoID { get; set; }
        public Tiposdequarto Tipoquarto { get; set; }

        public Guid ServicosID { get; set; }
        public Servicos Servicos { get; set; }

        public Formacombranca Cobranca { get; set; }
        public double Valor { get; set; }=0;

        public enum Formacombranca { Por_Noite,Por_Pessoa, Fixo }
    }
}