using PruebaComponentesObdulio.CrossCuting.Logging;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Models;

namespace PruebaComponentesObdulio.Services
{
    public class FakeRepositorioOrdenadores : IRepositoryOrdenadores
    {
        private readonly List<Ordenador> misOrderadores = new();
        public FakeRepositorioOrdenadores()
        {
            misOrderadores.Add(new Ordenador()
            {
                    Descripcion = "Ordenador Fake 1",
                    Id = 1
            });
            misOrderadores.Add(new Ordenador()
            {
                Descripcion = "Ordenador Fake 2",
                Id = 2
            });
            misOrderadores.Add(new Ordenador()
            {
                Descripcion = "Ordenador Fake 3",
                Id = 3
            });

        }


        public void EditOrdenador(Ordenador ordenador)
        {
            var OrdenadorAEditar = TomaOrdenador(ordenador.Id);
            if (OrdenadorAEditar != null)
            {
                OrdenadorAEditar.Descripcion = ordenador.Descripcion;
                
            }
        }



        public void AddOrdenador(Ordenador ordenador)
        {
            misOrderadores.Add(ordenador);
        }

        public void BorraOrdenador(int Id)
        {
            var ordenadorToRemove = misOrderadores.First(comp => comp.Id == Id);
            if (ordenadorToRemove != null)
            {
                misOrderadores.Remove(ordenadorToRemove);
            }
        }


        public List<Ordenador> ListaOrdenadores()
        {
            return misOrderadores;
        }

        public Ordenador TomaOrdenador(int Id)
        {
            if (Id < 0 || Id > misOrderadores.Count)
            {
                return null;
            }
            return misOrderadores.First(x => x.Id == Id);
        }
    }

}
