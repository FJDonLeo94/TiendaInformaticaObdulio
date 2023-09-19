using PruebaComponentesObdulio.CrossCuting.Logging;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Models;

using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Linq.Expressions;
using System.Reflection;

using System.Resources;
using NLog.LayoutRenderers;
using System.ComponentModel;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace PruebaComponentesObdulio.Services
{
    public class EFRepositorioPedidoComp : IRepositoryPedidoComp
    {
        
            
            private readonly TiendaOrdenadoresContext contexto;
            private readonly ILoggerManager LoggerManager;
        public EFRepositorioPedidoComp(ILoggerManager loggerManager, TiendaOrdenadoresContext contexto)
        {
            this.LoggerManager = loggerManager;
            this.LoggerManager.LogInfo("Pedido de componentes");
            this.contexto = contexto;
            
        }

        public void EditPedidoComp(PedidoComponentes pedidoComponentes)
        {
            var PedidoCompAEditar = TomaPedidoComp(pedidoComponentes.Id);
            if (PedidoCompAEditar != null)
            {
                PedidoCompAEditar.Cliente = pedidoComponentes.Cliente;
                PedidoCompAEditar.Id = pedidoComponentes.Id;
                PedidoCompAEditar.LPComponentes = pedidoComponentes.LPComponentes;
                PedidoCompAEditar.NumeroPedido = pedidoComponentes.NumeroPedido;
                


                LoggerManager.LogInfo($"Pedido de ordenador {PedidoCompAEditar.Id} editado");

                contexto.SaveChanges();
            }
        }

        public void AddPedidoComp(PedidoComponentes pedidoComponentes)
        {
            if (contexto.PedidoComponentes is not null)
            {
                contexto.PedidoComponentes.Add(pedidoComponentes);
                LoggerManager.LogInfo($"Pedido de componentes con id:  {pedidoComponentes.Id} añadido");
                contexto.SaveChanges();
            }
        }

        public void BorraPedidoComp(int Id)
        {
            if (contexto.PedidoComponentes is not null)
            {
                var PedidoCompABorrar = TomaPedidoComp(Id);
                if (PedidoCompABorrar is not null)
                {
                    contexto.PedidoComponentes.Remove(PedidoCompABorrar);
                    contexto.SaveChanges();
                }
            }
        }


        public List<PedidoComponentes> ListaPedidoComponentes()
        {
            if (contexto.PedidoComponentes is not null)
            {
                return contexto.PedidoComponentes.ToList();
            }
            return null;
        }

        public PedidoComponentes TomaPedidoComp(int Id)
        {
            if (contexto.PedidoComponentes is not null)
            {
                var PedidoCompEncontrado = contexto.PedidoComponentes.Find(Id);
                return PedidoCompEncontrado;
            }
            return null;
        }

    }
}

    

