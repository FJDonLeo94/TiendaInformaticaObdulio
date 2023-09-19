using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Ordenador;



namespace PruebaComponentesObdulio.Models
{
    public class Ordenador
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public string Descripcion { get; set; }

        [NotMapped]
        public decimal PrecioTotal
        {
            get
            {
                decimal preciototal = 0;
                foreach (var componente in ListaComponentesPC)
                {
                    preciototal += (decimal)componente.Coste;

                }

                return preciototal;
            }
        }

        
        public List<Componente> ListaComponentesPC { get; set; } = new();
        //Usar el componente.Descripcion como forma de ver los componentes, asi no hace falta enum.
        //Llamar al repositorio que devuelva una lista con todas las descripciones de los compoentes

        public int? PedidoOrdenadoresId { get; set; } = null;



        public override bool Equals(object? obj)
        {
            return this.Descripcion == (obj as Componente).Descripcion && this.Id == (obj as Componente).Id;
        }

        
    }
}
