using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Ordenador;
using PruebaComponentesObdulio.Logica;


namespace PCObdulioWebApi.Models
{
    public class Ordenador
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public string Descripcion { get; set; }

        [Required]

        public EnumOrdenador tipoOrdenador { get; set; }

        public decimal PrecioTotal { get; set; }

        
        public int? PedidoOrdenadoresId { get; set; } = null;


        public override bool Equals(object? obj)
        {
            return this.Descripcion == (obj as Componente).Descripcion && this.Id == (obj as Componente).Id;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
