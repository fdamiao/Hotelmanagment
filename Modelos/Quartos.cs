using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagment.Modelos
{
    public class Quartos:Audit
    {
        [Required]
        [Display(Name ="Numero do quarto")]
        public int Nquarto { get; set; }
        public Guid Tipodquarto { get; set; }
        [ForeignKey(nameof(Tipodquarto) )]
        public Tiposdequarto tiposdequarto { get; set; }
         [Display(Name ="Numero de oucupantes")]
        public int Nocupantes { get; set; }
        public int Voip { get; set; }
        public double  Preco { get; set; }
        public Despon  Desponibilidade { get; set; }
        public string Localizacao { get; set; }
        public Tpcamas Tipodecamas { get; set; }
        public String Fotodoquarto { get; set; }
        [NotMapped]
        public IFormFile Fotodolin { get; set; }

        public ICollection<QurtosSuprimetos> Suprimetos { get; set; }

      
    }
      public enum Despon
        {
             Desponivel,
            Oucupado,
            Reservado
           
        }
        public enum Tpcamas{
            Simples,
            Casais,
            Quing,
            Qween,
            Douplas
        }
}