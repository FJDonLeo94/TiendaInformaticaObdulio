using NewTiendaInformatica;
using NewTiendaInformatica.Comportamientos;

namespace NewTI.Test.Comportamientos
{
    [TestClass]
    public class UnitTestComportamientos
    {
        [TestMethod]
        public void TestConCalor()
        {
            int caloresperado = 24;

            ConCalor concalor = new(caloresperado);
            Assert.IsNotNull(concalor.Calor);
            Assert.AreEqual(caloresperado, concalor.Calor);

        }
        [TestMethod]
        public void TestSinCalor()
        {
            SinCalor sincalor = new();
            Assert.AreEqual(0, sincalor.Calor);
        }
        [TestMethod]
        public void TestConCores()
        {
            int coreesperado = 24;

            ConCores concores = new(coreesperado);
            Assert.IsNotNull(concores.Cores);
            Assert.AreEqual(coreesperado, concores.Cores);
        }

        [TestMethod]
        public void TestSinCores()
        {
            SinCores sincores = new();
            Assert.AreEqual(0, sincores.Cores);
        }

        [TestMethod]
        public void TestConMegas()
        {
            int megasesperado = 24;

            ConMegas conmegas = new(megasesperado);
            Assert.IsNotNull(conmegas.Megas);
            Assert.AreEqual(megasesperado, conmegas.Megas);

        }
        [TestMethod]
        public void TestSinMegas()
        {
            SinMegas sinmegas = new();
            Assert.AreEqual(0, sinmegas.Megas);
        }

        [TestMethod]
        public void TestConPrecio()
        {
            int precioesperado = 24;

            ConPrecio conprecio = new(precioesperado);
            Assert.IsNotNull(conprecio.Coste);
            Assert.AreEqual(precioesperado, conprecio.Coste);

        }
        [TestMethod]
        public void TestSinPrecio()
        {
            SinPrecio sinprecio = new();
            Assert.AreEqual(0, sinprecio.Coste);
        }

        [TestMethod]
        public void TestConNumSerie()
        {
            string serieesperada = "ram-fg-34";

            ConSerie conserie = new(serieesperada);
            Assert.IsNotNull(conserie.NumeroSerie);
            Assert.AreEqual(serieesperada, conserie.NumeroSerie);

        }

        [TestMethod]
        public void TestSinNumSerie()
        {
            SinSerie sinserie = new();
            Assert.AreEqual("", sinserie.NumeroSerie);
        }

        [TestMethod]
        public void TestConDescripcion()
        {
            string descripcionesperada = "Componente con X e Y";

            ConDescripcion condescripcion = new(descripcionesperada);
            Assert.IsNotNull(condescripcion.Descripcion);
            Assert.AreEqual(descripcionesperada, condescripcion.Descripcion);
        }
        [TestMethod]
        public void TestSinDescripcion()
        {
            SinDescripcion sindescripcion = new();
            Assert.AreEqual("", sindescripcion.Descripcion);
        }
    }
}