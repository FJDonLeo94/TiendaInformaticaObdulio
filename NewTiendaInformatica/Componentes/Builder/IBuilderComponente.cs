﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTiendaInformatica.Componentes.Builder
{
    public interface IBuilderComponente
    {
        Componente? DameComponente(EnumComponente tipo);
        Componente? DameComponente(string serie, string descripcion, int calor, long megas, int cores, decimal coste, EnumTipoComponente tipo);

    }
}
