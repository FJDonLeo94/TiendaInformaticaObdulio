using PruebaComponentesObdulio.Models;
using System.ComponentModel;

namespace PruebaComponentesObdulio.Services
{
    public interface IRepositoryPedidoComp
    {
        PedidoComponentes TomaPedidoComp(int Id);
        void BorraPedidoComp(int Id);

        void EditPedidoComp(PedidoComponentes pedidoComponentes);
        void AddPedidoComp(PedidoComponentes pedidoComponentes);
        List<PedidoComponentes> ListaPedidoComponentes();
    }
}
