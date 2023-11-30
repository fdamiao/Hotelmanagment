using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public class Booking:Audit
    {
        public Guid QuartoId { get; set; }
        public Quartos Quartos { get; set; }
        [Display(Name ="Adultos")]
        public int Adultos { get; set; }
        [Display(Name ="Menores")]
        public int Menores { get; set; }
        public DateTime DataInicio { get; set; }
        public int Dias { get; set; }
         public double Total { get; set; }
         public double Valorpago { get; set; }=0;
         public double VolorApagar { get; set; }=0;
         public BTipo Tipo { get; set; }
         public ICollection<Quartos> ListaQuartos { get; set; }
      public enum BTipo  { Reservado,Oupacao,Cancelado}
    }
}