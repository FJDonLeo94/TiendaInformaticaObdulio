//using NewTiendaInformatica;
//using NewTiendaInformatica.Componentes;
//using NewTiendaInformatica.Comportamientos;
//using System.Drawing;

//namespace NewTI.Test.Componentes
//{
//    [TestClass]
//    public class UnitTestComponentes
//    {
//        private Componente _componente;

//        public UnitTestComponentes(Componente componente)
//        {
//            _componente = componente;
//        }

//        [TestInitialize]
//        public void Initialize()
//        {
//            var serie = "1234";
//            var grados = 10;
//            var cores = 4;
//            var megas = 8192;
//            var descripcion = "Componente de prueba";
//            var precio = 200;
//            var tipocomponente = EnumTipoComponente.MemoriaRAM;

//            _componente = new Componente(serie, grados, cores, megas, descripcion, precio, tipocomponente);
//        }


//        [TestMethod]
//            public void TestComponenteNotNull()
//            { 
//                Assert.IsNotNull(_componente);
//            }

//        [TestMethod]
//            public void TestCalorComponente()
//            {
//                Assert.AreEqual(10, _componente.Calor);
//            }
//        [TestMethod]
//            public void TestCoresComponente()
//            {
//                Assert.AreEqual(4, _componente.Cores);
//            }
//        [TestMethod]
//            public void TestPrecioComponente()
//            {
//                Assert.AreEqual(EnumTipoComponente.MemoriaRAM, _componente.TipoComponente);
//            }
//        [TestMethod]
//            public void TestTipoComponente()
//            {
//                Assert.AreEqual(200, _componente.Coste);
//            }
//        [TestMethod]
//            public void TestMegasComponente()
//            {
//                Assert.AreEqual(8192, _componente.Megas);
//            }
//        [TestMethod]
//            public void TestNumSerieComponente()
//            {
//                Assert.AreEqual("1234", _componente.NumeroSerie);
//            }
//        [TestMethod]
//            public void TestDefinicionComponente()
//            {
//                Assert.AreEqual("Componente de prueba", _componente.Descripcion);
//            }

//    }
    
//}
