using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection;
using NewTiendaInformatica.Componentes;


namespace PCObdulioWebApi.Models
{
    public class Componente
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public double Coste { get; set; }
        [Required]
        public string NumeroSerie { get; set; }
        [Required]
        public int Calor { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "No puede haber cores negativos")]
        public int Cores { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "No puede haber megas negativos")]
        public long Megas { get; set; }
        [Required]
        [Range(0, 3)]
        public EnumTipoComponente TipoComponente { get; set; }

        
        public int? PedidoComponentesId { get; set; } = null;


        //public virtual Ordenador? MiOrdenador { get; set; }

        public override bool Equals(object? obj)
        {
            return this.Coste == (obj as Componente).Coste && this.TipoComponente == (obj as Componente).TipoComponente && this.Calor == (obj as Componente).Calor
                && this.Cores == (obj as Componente).Cores && this.Descripcion == (obj as Componente).Descripcion && this.Id == (obj as Componente).Id
                && this.Megas == (obj as Componente).Megas && this.NumeroSerie == (obj as Componente).NumeroSerie;
        }

        
    }
}
