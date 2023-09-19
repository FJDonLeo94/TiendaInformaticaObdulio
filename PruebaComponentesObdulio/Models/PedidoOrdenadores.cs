
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PruebaComponentesObdulio.Models
{
    public class PedidoOrdenadores
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string NumeroPedido { get; set; }

        [Required]
        public string Cliente { get; set; }

        [NotMapped]
        public decimal Precio {
            get
            {
                decimal preciototal = 0;
                foreach (var ordenador in LPOrdenadores)
                {
                    preciototal += (decimal)ordenador.PrecioTotal;

                }

                return preciototal;
            }
        }

        
        public List<Ordenador> LPOrdenadores { get; set; } = new();
    }
}
