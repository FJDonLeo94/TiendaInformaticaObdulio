using PruebaComponentesObdulio.Models;
using System.ComponentModel;

namespace PruebaComponentesObdulio.Services
{
    public interface IRepositoryPedidoPC
    {
        PedidoOrdenadores TomaPedidoPC(int Id);
        void BorraPedidoPC(int Id);

        void EditPedidoPC(PedidoOrdenadores pedidoOrdenadores);
        void AddPedidoPC(PedidoOrdenadores pedidoOrdenadores);
        List<PedidoOrdenadores> ListaPedidoPC();
    }
}
