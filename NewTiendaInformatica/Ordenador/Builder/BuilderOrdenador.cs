using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Ordenador.Validator;

namespace NewTiendaInformatica.Ordenador.Builder
{
    public class BuilderOrdenador
    {
        private OrdenadorValidator _validador;

        public BuilderOrdenador()
        {
            _validador = new OrdenadorValidator();
        }

        public Ordenador? ConstruirOrdenador(params EnumComponente[] componentes)
        {
            Ordenador _ordenador = new Ordenador(new List<EnumComponente>(componentes));

            if (_validador.IsValid(_ordenador))
            {
                return _ordenador;
            }
            else
            {
                return null;
            }
        }

        public (int CalorTotal, int CoreTotal, long MegaTotal, decimal PrecioTotal) CalcularCaracteristicas(Ordenador ordenador)
        {
            var componentes = ordenador.DameColeccion();

            int CalorTotal = 0;
            int CoreTotal = 0;
            long MegaTotal = 0;
            decimal PrecioTotal = 0;

            foreach (var componente in componentes)
            {
                CalorTotal += componente.Calor;
                CoreTotal += componente.Cores;
                MegaTotal += componente.Megas;
                PrecioTotal += componente.Coste;
            }

            return (CalorTotal, CoreTotal, MegaTotal, PrecioTotal);
        }
    }



}



