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
    public class EFRepositorioComponentes : IRepositoryComponentes
    {
        
            
            private readonly TiendaOrdenadoresContext contexto;
            private readonly ILoggerManager LoggerManager;
        public EFRepositorioComponentes(ILoggerManager loggerManager, TiendaOrdenadoresContext contexto)
        {
            this.LoggerManager = loggerManager;
            this.LoggerManager.LogInfo("RepoComponente");
            this.contexto = contexto;
            
        }

        public void EditComponente(Componente componente)
        {
            var ComponenteAEditar = TomaComponente(componente.Id);
            if (ComponenteAEditar != null)
            {
                ComponenteAEditar.NumeroSerie = componente.NumeroSerie;
                ComponenteAEditar.Descripcion = componente.Descripcion;
                ComponenteAEditar.Calor = componente.Calor;
                ComponenteAEditar.Megas = componente.Megas;
                ComponenteAEditar.Cores = componente.Cores;
                ComponenteAEditar.Coste = componente.Coste;
                ComponenteAEditar.TipoComponente = componente.TipoComponente;

                LoggerManager.LogInfo($"Componente {ComponenteAEditar.Id} editado");

                contexto.SaveChanges();
            }
        }

        public void AddComponente(Componente componente)
        {
            if (contexto.Componentes is not null)
            {
                contexto.Componentes.Add(componente);
                LoggerManager.LogInfo($"Componente {componente.Id} añadido");
                contexto.SaveChanges();
            }
        }

        public void BorraComponente(int Id)
        {
            if (contexto.Componentes is not null)
            {
                var componenteABorrar = TomaComponente(Id);
                if (componenteABorrar is not null)
                {
                    contexto.Componentes.Remove(componenteABorrar);
                    contexto.SaveChanges();
                }
            }
        }


        public List<Componente> ListaComponentes()
        {
            if (contexto.Componentes is not null)
            {
                return contexto.Componentes.ToList();
            }
            return null;
        }

        public Componente TomaComponente(int Id)
        {
            if (contexto.Componentes is not null)
            {
                var componenteEncontrado = contexto.Componentes.Find(Id);
                return componenteEncontrado;
            }
            return null;
        }
    }
}

    

