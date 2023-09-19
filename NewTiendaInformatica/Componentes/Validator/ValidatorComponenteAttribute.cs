using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTiendaInformatica.Componentes.Validator
{
    public class ValidatorComponenteAttribute: ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var miComponente = (Componente?)value;
            if (miComponente is not null)
                return miComponente is { Calor: >= 0 }
                       && miComponente.NumeroSerie != ""
                       && miComponente is { Coste: >= 0 }
                       && miComponente.Descripcion != ""
                       && miComponente is { Megas: >= 0 }
                       && miComponente is { Cores: >= 0 };
            else
            {
                return false;
            }
        }
    }
}
