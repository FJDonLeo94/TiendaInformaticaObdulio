using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Ordenador;
using NewTiendaInformatica.Ordenador.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTiendaInformatica.Ordenador.Tests
{
    [TestClass()]
    public class ListadeOrdenadoresTests
    {
        private ListadeOrdenadores _listaOrdenadores;
        private BuilderOrdenador _builder;

        [TestInitialize]
        public void Setup()
        {
            _listaOrdenadores = new ListadeOrdenadores();
            _builder = new BuilderOrdenador();
        }

        [TestMethod()]
        public void CrearOrdenadorMariaTest()
        {
            var ordenadorMaria = _listaOrdenadores.CrearOrdenadorMaria();

            Assert.IsNotNull(ordenadorMaria);

            if (ordenadorMaria != null)
            {
                var caracteristicasMaria = _builder.CalcularCaracteristicas(ordenadorMaria);

                Assert.AreNotEqual(0, caracteristicasMaria.CalorTotal);
                Assert.AreNotEqual(0, caracteristicasMaria.CoreTotal);
                Assert.AreNotEqual(0, caracteristicasMaria.PrecioTotal);
                Assert.AreNotEqual(0, caracteristicasMaria.MegaTotal);
            }
        }

        [TestMethod()]
        public void CrearOrdenadorAndresTest()
        {
            var ordenadorAndres = _listaOrdenadores.CrearOrdenadorAndres();

            Assert.IsNotNull(ordenadorAndres);

            if (ordenadorAndres != null)
            {
                var caracteristicasAndres = _builder.CalcularCaracteristicas(ordenadorAndres);

                Assert.AreNotEqual(0, caracteristicasAndres.CalorTotal);
                Assert.AreNotEqual(0, caracteristicasAndres.CoreTotal);
                Assert.AreNotEqual(0, caracteristicasAndres.PrecioTotal);
                Assert.AreNotEqual(0, caracteristicasAndres.MegaTotal);
            }
        }
    }
}