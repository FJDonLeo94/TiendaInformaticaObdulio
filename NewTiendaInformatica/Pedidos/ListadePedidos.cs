using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NewTiendaInformatica.Interfaces;
using NewTiendaInformatica.Ordenador;

namespace NewTiendaInformatica.Pedidos
{
    public class ListadePedidos
    {
        ListadeOrdenadores listaDeOrdenadores = new ListadeOrdenadores();
        

        List<IPedido> listaPedidos = new List<IPedido>();

        PedidoPC pedidoA;
        PedidoPC pedidoB;

        public ListadePedidos()
        {
            pedidoA = new PedidoPC(
                listaDeOrdenadores.CrearOrdenadorMaria(),
                listaDeOrdenadores.CrearOrdenadorMaria(),
                listaDeOrdenadores.CrearOrdenadorMaria(),
                listaDeOrdenadores.CrearOrdenadorAndres(),
                listaDeOrdenadores.CrearOrdenadorAndres(),
                
                listaDeOrdenadores.CrearOrdenadorAndres());


            pedidoB = new PedidoPC(
                listaDeOrdenadores.CrearOrdenadorTiburcioII(),
                listaDeOrdenadores.CrearOrdenadorAndresCF(),
                listaDeOrdenadores.CrearOrdenadorTiburcioII(),
                listaDeOrdenadores.CrearOrdenadorTiburcioII(),
                listaDeOrdenadores.CrearOrdenadorAndresCF());

            listaPedidos.Add(pedidoA);
            listaPedidos.Add(pedidoB);
        }

        
    }
}

