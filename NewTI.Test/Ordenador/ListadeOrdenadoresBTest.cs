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
    public class ListadeOrdenadoresBTests
    {
        
        private ListadeOrdenadores _listaOrdenadoresB;
        private BuilderOrdenador _builder;

        [TestInitialize]
        public void Setup()
        {
            _listaOrdenadoresB = new ListadeOrdenadores();
            _builder = new BuilderOrdenador();
        }

        [TestMethod()]
        public void CrearOrdenadorTiburcioIITest()
        {
            var ordenadorTiburcioII = _listaOrdenadoresB.CrearOrdenadorTiburcioII();

            Assert.IsNotNull(ordenadorTiburcioII);

            if (ordenadorTiburcioII != null)
            {
                var caracteristicasTiburcioII = _builder.CalcularCaracteristicas(ordenadorTiburcioII);

                Assert.AreEqual(75, caracteristicasTiburcioII.CalorTotal);
                Assert.AreEqual(9, caracteristicasTiburcioII.CoreTotal);
                Assert.AreEqual(455, caracteristicasTiburcioII.PrecioTotal);
                Assert.AreNotEqual(0, caracteristicasTiburcioII.MegaTotal);
            }
        }

        [TestMethod()]
        public void CrearOrdenadorAndresTest()
        {
            var ordenadorAndresCF = _listaOrdenadoresB.CrearOrdenadorAndresCF();

            Assert.IsNotNull(ordenadorAndresCF);

            if (ordenadorAndresCF != null)
            {
                var caracteristicasAndresCF = _builder.CalcularCaracteristicas(ordenadorAndresCF);

                Assert.AreEqual(158, caracteristicasAndresCF.CalorTotal);
                Assert.AreEqual(34, caracteristicasAndresCF.CoreTotal);
                Assert.AreEqual(593, caracteristicasAndresCF.PrecioTotal);
                Assert.AreNotEqual(0, caracteristicasAndresCF.MegaTotal);
            }
        }
    }
}