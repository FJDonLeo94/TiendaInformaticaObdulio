﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewTiendaInformatica
{
    public interface IComponente : ICores, IDescripcion, IGrados, IMegaBytes, INumSerie, IPrecio
    {
    }
}