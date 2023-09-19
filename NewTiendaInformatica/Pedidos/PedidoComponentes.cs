using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTiendaInformatica.Componentes;

namespace NewTiendaInformatica.Pedidos
{
    public class PedidoComponentes : Ordenador.Ordenador
    {
        public PedidoComponentes(List<EnumComponente> componentes) : base(componentes)
        {
        }
    }
}
