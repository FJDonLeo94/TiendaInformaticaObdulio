using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTiendaInformatica.Componentes
{
    public class Componente : IComponente
    {
        public Componente(string serie, int calor, int cores, long megas, string descripcion, decimal coste, EnumTipoComponente tipo)
        {
            this.Megas = megas;
            this.Descripcion = descripcion;
            this.Calor = calor;
            this.Cores = cores;
            this.Coste = coste;
            this.NumeroSerie = serie;
            this.TipoComponente = tipo;
        }


        public int Cores { get; set; }

        public string? Descripcion { get; set; }

        public int Calor { get; set; }

        public long Megas { get; set; }

        public string? NumeroSerie { get; set; }

        public decimal Coste { get; set; }

        public EnumTipoComponente TipoComponente { get; set; }
    }
}
