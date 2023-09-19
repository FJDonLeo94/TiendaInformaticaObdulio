using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NewTiendaInformatica.Componentes;

namespace PCObdulioWebApi.Models
{
    public class PedidoComponentes
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string NumeroPedido{ get; set; }

        [Required]
        public string Cliente { get; set; }

        [NotMapped]
        public decimal Precio
        {
            get
            {
                decimal preciototal = 0;
                foreach (var componente in LPComponentes)
                {
                    preciototal += (decimal)componente.Coste;

                }

                return preciototal;
            }
        }

        [Required]
        public List<Componente> LPComponentes { get; set; }


    }
}
