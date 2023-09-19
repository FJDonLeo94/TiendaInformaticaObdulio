using NewTiendaInformatica.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Componentes.Builder;

namespace NewTiendaInformatica.Ordenador
{
    public class Ordenador : IColeccionComponentes
    {
        private readonly BuilderComponente _builderComponente;
        private readonly List<EnumComponente> _componentes;

        public Ordenador(List<EnumComponente> componentes)
        {
            _builderComponente = new BuilderComponente();
            _componentes = componentes;
        }

        public Collection<Componente> DameColeccion()
        {
            var coleccionComponentes = new Collection<Componente>();

            foreach (var componente in _componentes)
            {
                var nuevoComponente = _builderComponente.DameComponente(componente);
                if (nuevoComponente != null)
                    coleccionComponentes.Add(nuevoComponente);
            }

            return coleccionComponentes;
        }

        
    }
}
