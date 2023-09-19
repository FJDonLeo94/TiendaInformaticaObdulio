using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Componentes.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTiendaInformatica.Ordenador.Validator
{
    public class OrdenadorValidator : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            var miordenador = value as Ordenador;
            if (miordenador != null)
            {
                var coleccionComponentes = miordenador.DameColeccion();

                int countRAM = 0;
                int countProcesador = 0;
                int countAlmacenamiento = 0;

                foreach (var componente in coleccionComponentes)
                {
                    switch (componente.TipoComponente)
                    {
                        case EnumTipoComponente.MemoriaRAM:
                            countRAM++;
                            break;
                        case EnumTipoComponente.Procesador:
                            countProcesador++;
                            break;
                        case EnumTipoComponente.Almacenamiento:
                            countAlmacenamiento++;
                            break;
                    }
                }

                return countRAM >= 1 && countProcesador >= 1 && countAlmacenamiento >= 1;
            }
            else
            {
                return false;
            }
        }
    }
}
