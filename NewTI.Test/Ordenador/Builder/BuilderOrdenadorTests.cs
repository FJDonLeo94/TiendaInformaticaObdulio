using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewTiendaInformatica.Ordenador.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTiendaInformatica.Componentes;

namespace NewTiendaInformatica.Ordenador.Builder.Tests
{
    [TestClass]
    public class BuilderOrdenadorTests
    {
        private BuilderOrdenador _builder;
        private Ordenador _ordenador;
        private int _calorTotal;
        private int _coresTotal;
        private decimal _precioTotal;
        private long _megasTotal;

        [TestInitialize]
        public void Setup()
        {
            _builder = new BuilderOrdenador();
            _ordenador = _builder.ConstruirOrdenador(EnumComponente.BancoDeMemoriaSDRAM_879FH,
                EnumComponente.DiscoDuroSanDisk_789_XX,
                EnumComponente.ProcesadorInteli7_789_XCD);

            var caracteristicaspc = _builder.CalcularCaracteristicas(_ordenador);

            _calorTotal = caracteristicaspc.CalorTotal;
            _coresTotal = caracteristicaspc.CoreTotal;
            _precioTotal = caracteristicaspc.PrecioTotal;
            _megasTotal = caracteristicaspc.MegaTotal;
        }

        [TestMethod()]
        public void OrdenadorCalorTest()
        {
            Assert.AreEqual(32, _calorTotal);
        }

        [TestMethod()]
        public void OrdenadorCoresTest()
        {
            Assert.AreEqual(10, _coresTotal);
        }

        [TestMethod()]
        public void OrdenadorMegasTest()
        {
            Assert.AreEqual(500512, _megasTotal);
        }

        [TestMethod()]
        public void OrdenadorPrecioTest()
        {
            Assert.AreEqual(288, _precioTotal);
        }

        [TestMethod()]
        public void OrdenadorNotNullTest()
        {
            Assert.IsNotNull(_ordenador);
        }
    }
}