using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTiendaInformatica.Interfaces
{
    public interface IPedido
    {
        List<Ordenador.Ordenador> DameOrdenadores { get; set; }
    }
}
