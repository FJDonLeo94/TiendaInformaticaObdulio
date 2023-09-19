using Microsoft.AspNetCore.Mvc;
using NewTiendaInformatica.Componentes;
using PCObdulioWebApi.Controllers;
using PCObdulioWebApi.Models;
using PCObdulioWebApi.Services;
using PruebaComponentesObdulio.CrossCuting.Logging;
using Componente = PCObdulioWebApi.Models.Componente;


namespace PCOApi.Test
{
    [TestClass]
    public class TestComponentesController
    {
        private FakeRepositorioComponentes _fakeRepository;
        private readonly ComponentesController controlador = new(new FakeRepositorioComponentes());
        private Componente _fakeComponente;




        [TestInitialize]
        public void TestSetup()
        {
            _fakeRepository = new FakeRepositorioComponentes();
            _fakeComponente = _fakeRepository.Obtener(1);


        }

        [TestMethod]
        public void TestObtenerTodos()
        {
            var resultado = controlador.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            var listaModulos = resultado.Value as List<Componente>;
            Assert.IsNotNull(listaModulos);
            Assert.AreEqual(3, listaModulos.Count);
        }

        [TestMethod]
        public void TestObtenerComponenteExiste()
        {
            var resultado = controlador.Get(1) as ObjectResult;
            Assert.IsNotNull(resultado);
            var componente = resultado.Value as PCObdulioWebApi.Models.Componente;
            Assert.IsNotNull(componente);
            Assert.AreEqual((EnumTipoComponente.Procesador), componente.TipoComponente);
            Assert.AreEqual("Procesador Intel i7", componente.Descripcion);
            Assert.AreEqual(10, componente.Calor);
            Assert.AreEqual(9, componente.Cores);
            Assert.AreEqual(134.0, componente.Coste);
            Assert.AreEqual("789_XCS", componente.NumeroSerie);
            Assert.AreEqual(0, componente.Megas);
        }

        [TestMethod]
        public void TestObtenerComponenteNoExiste()
        {
            var resultado = controlador.Get(6) as NotFoundResult;
            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void TestComponentesCrearBien()
        {
            var resultado = controlador.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            var listaModulos = resultado.Value as List<PCObdulioWebApi.Models.Componente>;
            Assert.IsNotNull(listaModulos);
            Assert.AreEqual(3, listaModulos.Count);

            Componente componente = new()
            {
                Descripcion = "Prueba",
                NumeroSerie = "BBBB"
            };

            controlador.Post(componente);
            resultado = controlador.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            listaModulos = resultado.Value as List<Componente>;
            Assert.IsNotNull(listaModulos);
            Assert.AreEqual(4, listaModulos.Count);
        }

        [TestMethod]
        public void TestComponentesBorrarExiste()
        {
            var resultado = controlador.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            var listaModulos = resultado.Value as List<Componente>;
            Assert.IsNotNull(listaModulos);
            Assert.AreEqual(3, listaModulos.Count);

            controlador.Delete(3);
            resultado = controlador.Get() as OkObjectResult;
            Assert.IsNotNull(resultado);
            listaModulos = resultado.Value as List<Componente>;
            Assert.IsNotNull(listaModulos);
            Assert.AreEqual(2, listaModulos.Count);
        }

        //[TestMethod]
        //public void TestComponentesBorrarNoExiste()
        //{
        //    var resultado = controlador.Get() as OkObjectResult;
        //    Assert.IsNotNull(resultado);
        //    var listaModulos = resultado.Value as List<Componente>;
        //    Assert.IsNotNull(listaModulos);
        //    Assert.AreEqual(3, listaModulos.Count);

        //    controlador.Delete(999);
        //    resultado = controlador.Get() as OkObjectResult;
        //    Assert.IsNotNull(resultado);
        //    listaModulos = resultado.Value as List<Componente>;
        //    Assert.IsNotNull(listaModulos);
        //    Assert.AreEqual(3, listaModulos.Count);
        //}
    }
}