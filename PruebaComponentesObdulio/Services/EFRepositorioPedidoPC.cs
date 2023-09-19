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
    public class EFRepositorioPedidoPC : IRepositoryPedidoPC
    {
        
            
            private readonly TiendaOrdenadoresContext contexto;
            private readonly ILoggerManager LoggerManager;
        public EFRepositorioPedidoPC(ILoggerManager loggerManager, TiendaOrdenadoresContext contexto)
        {
            this.LoggerManager = loggerManager;
            this.LoggerManager.LogInfo("Pedido PC");
            this.contexto = contexto;
            
        }

        public void EditPedidoPC(PedidoOrdenadores pedidoOrdenadores)
        {
            var PedidoPCAEditar = TomaPedidoPC(pedidoOrdenadores.Id);
            if (PedidoPCAEditar != null)
            {
                PedidoPCAEditar.Cliente = pedidoOrdenadores.Cliente;
                PedidoPCAEditar.Id = pedidoOrdenadores.Id;
                PedidoPCAEditar.LPOrdenadores = pedidoOrdenadores.LPOrdenadores;
                PedidoPCAEditar.NumeroPedido = pedidoOrdenadores.NumeroPedido;
                
                

                LoggerManager.LogInfo($"Pedido de ordenador {PedidoPCAEditar.Id} editado");

                contexto.SaveChanges();
            }
        }

        public void AddPedidoPC(PedidoOrdenadores pedidoOrdenadores)
        {
            if (contexto.PedidoOrdenadores is not null)
            {
                contexto.PedidoOrdenadores.Add(pedidoOrdenadores);
                LoggerManager.LogInfo($"Pedido de ordenadores con id:  {pedidoOrdenadores.Id} añadido");
                contexto.SaveChanges();
            }
        }

        public void BorraPedidoPC(int Id)
        {
            if (contexto.PedidoOrdenadores is not null)
            {
                var PedidoPCABorrar = TomaPedidoPC(Id);
                if (PedidoPCABorrar is not null)
                {
                    contexto.PedidoOrdenadores.Remove(PedidoPCABorrar);
                    contexto.SaveChanges();
                }
            }
        }


        public List<PedidoOrdenadores> ListaPedidoPC()
        {
            if (contexto.PedidoOrdenadores is not null)
            {
                return contexto.PedidoOrdenadores.ToList();
            }
            return null;
        }

        public PedidoOrdenadores TomaPedidoPC(int Id)
        {
            if (contexto.PedidoOrdenadores is not null)
            {
                var PedidoPCEncontrado = contexto.PedidoOrdenadores.Find(Id);
                return PedidoPCEncontrado;
            }
            return null;
        }

    }
}

    

