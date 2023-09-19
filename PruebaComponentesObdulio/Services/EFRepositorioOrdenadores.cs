using PruebaComponentesObdulio.CrossCuting.Logging;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Models;

namespace PruebaComponentesObdulio.Services
{
    public class EFRepositorioOrdenadores : IRepositoryOrdenadores
    {


        private readonly TiendaOrdenadoresContext contexto;
        private readonly ILoggerManager LoggerManager;
        public EFRepositorioOrdenadores(ILoggerManager loggerManager, TiendaOrdenadoresContext contexto)
        {
            this.LoggerManager = loggerManager;
            this.LoggerManager.LogInfo("RepoOrdenador");
            this.contexto = contexto;

        }


        public void EditOrdenador(Ordenador ordenador)
        {
            var OrdenadorAEditar = TomaOrdenador(ordenador.Id);
            if (OrdenadorAEditar != null)
            {
                OrdenadorAEditar.Descripcion = ordenador.Descripcion;
                

                LoggerManager.LogInfo($"Ordenador  {OrdenadorAEditar.Id} editado");

                contexto.SaveChanges();
            }
        }

       

        public void AddOrdenador(Ordenador ordenador)
        {
            if (contexto.Ordenadores is not null)
            {
                contexto.Ordenadores.Add(ordenador);
                LoggerManager.LogInfo($"Ordenador {ordenador.Id} añadido");
                contexto.SaveChanges();
            }
        }

        public void BorraOrdenador(int Id)
        {
            if (contexto.Ordenadores is not null)
            {
                var ordenadorABorrar = TomaOrdenador(Id);
                if (ordenadorABorrar is not null)
                {
                    contexto.Ordenadores.Remove(ordenadorABorrar);
                    contexto.SaveChanges();
                }
            }
        }


        public List<Ordenador> ListaOrdenadores()
        {
            if (contexto.Ordenadores is not null)
            {
                return contexto.Ordenadores.ToList();
            }
            return null;
        }

        public Ordenador TomaOrdenador(int Id)
        {
            if (contexto.Ordenadores is not null)
            {
                var ordenadorEncontrado = contexto.Ordenadores.Find(Id);
                return ordenadorEncontrado;
            }
            return null;
        }
    }
}
