using PruebaComponentesObdulio.Models;
using System.ComponentModel;

namespace PruebaComponentesObdulio.Services
{
    public interface IRepositoryOrdenadores
    {
        Ordenador TomaOrdenador(int Id);
        void BorraOrdenador(int Id);

        void EditOrdenador(Ordenador ordenador);
        void AddOrdenador(Ordenador ordenador);
        List<Ordenador> ListaOrdenadores();
    }
}
