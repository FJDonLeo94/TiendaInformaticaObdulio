using PruebaComponentesObdulio.Models;
using System.ComponentModel;

namespace PruebaComponentesObdulio.Services
{
    public interface IRepositoryComponentes
    {
        Componente TomaComponente(int Id);
        void BorraComponente(int Id);

        void EditComponente(Componente componente);
        void AddComponente(Componente componente);
        List<Componente> ListaComponentes();
    }
}
