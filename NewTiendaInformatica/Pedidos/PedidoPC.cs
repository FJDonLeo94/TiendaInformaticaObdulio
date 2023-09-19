using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTiendaInformatica.Interfaces;
using NewTiendaInformatica.Ordenador;

namespace NewTiendaInformatica.Pedidos
{
    public class PedidoPC : IPedido
    {
        public List<Ordenador.Ordenador> DameOrdenadores { get; set; }

        public PedidoPC(params Ordenador.Ordenador[] ordenadores)
        {
            DameOrdenadores = new List<Ordenador.Ordenador>(ordenadores);
        }
    }
}
