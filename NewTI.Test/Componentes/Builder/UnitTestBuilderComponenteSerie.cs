using NewTiendaInformatica;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Componentes.Builder;
using NewTiendaInformatica.Comportamientos;

namespace NewTI.Test.Componentes.Builder
{
    [TestClass]
    public class UnitTestBuilderComponenteSerie
    {
        private BuilderComponente _builder;
        private Componente componenteProcesador;
        private Componente componenteRAM;
        private Componente componenteAlmacenamiento;
        




        [TestInitialize]
        public void Initialize()
        {
            _builder = new BuilderComponente();
            componenteProcesador = _builder.DameComponente("serie", "descripcion", 10, 1000, 4, 100, EnumTipoComponente.Procesador);
            componenteRAM = _builder.DameComponente("serie", "descripcion", 10, 1000, 4, 100, EnumTipoComponente.MemoriaRAM);
            componenteAlmacenamiento = _builder.DameComponente("serie", "descripcion", 10, 1000, 4, 100, EnumTipoComponente.Almacenamiento);
            


        }

        [TestMethod]
        public void TestBuilderProcesador()
        {
            Assert.IsNotNull(componenteProcesador);
            Assert.AreEqual("serie", componenteProcesador.NumeroSerie);
            Assert.AreEqual(10, componenteProcesador.Calor);
            Assert.AreEqual(4, componenteProcesador.Cores);
            Assert.AreEqual(1000, componenteProcesador.Megas);
            Assert.AreEqual("descripcion", componenteProcesador.Descripcion);
            Assert.AreEqual(100, componenteProcesador.Coste);
            Assert.AreEqual(EnumTipoComponente.Procesador, componenteProcesador.TipoComponente);


        }
        [TestMethod]
        public void TestBuilderRAM()
        {
            Assert.IsNotNull(componenteRAM);
            Assert.AreEqual("serie", componenteRAM.NumeroSerie);
            Assert.AreEqual(10, componenteRAM.Calor);
            Assert.AreEqual(4, componenteRAM.Cores);
            Assert.AreEqual(1000, componenteRAM.Megas);
            Assert.AreEqual("descripcion", componenteRAM.Descripcion);
            Assert.AreEqual(100, componenteRAM.Coste);
            Assert.AreEqual(EnumTipoComponente.MemoriaRAM, componenteRAM.TipoComponente);


        }
        [TestMethod]
        public void TestBuilderAlmacenamiento()
        {
            Assert.IsNotNull(componenteAlmacenamiento);
            Assert.AreEqual("serie", componenteAlmacenamiento.NumeroSerie);
            Assert.AreEqual(10, componenteAlmacenamiento.Calor);
            Assert.AreEqual(4, componenteAlmacenamiento.Cores);
            Assert.AreEqual(1000, componenteAlmacenamiento.Megas);
            Assert.AreEqual("descripcion", componenteAlmacenamiento.Descripcion);
            Assert.AreEqual(100, componenteAlmacenamiento.Coste);
            Assert.AreEqual(EnumTipoComponente.Almacenamiento, componenteAlmacenamiento.TipoComponente);


        }



    }
}