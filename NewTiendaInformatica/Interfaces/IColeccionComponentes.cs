using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTiendaInformatica.Componentes;

namespace NewTiendaInformatica.Interfaces
{
    public interface IColeccionComponentes
    {
        Collection<Componente> DameColeccion();
    }
}