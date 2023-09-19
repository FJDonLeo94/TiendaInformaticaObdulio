using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PruebaComponentesObdulio.Controllers;
using PruebaComponentesObdulio.CrossCuting.Logging;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Services;
using System.ComponentModel;
using System.Drawing;
using NewTiendaInformatica.Componentes;
using Componente = PruebaComponentesObdulio.Models.Componente;

namespace ComponentesObdulio.Test.Controladores
{
    [TestClass]
    public class ComponentesControllerTests
    {

        private FakeRepositorioComponentes _fakeRepository;
        private readonly ComponentesController _controller = new(new FakeRepositorioComponentes(), new LoggerManager());
        private Componente _fakeComponente;




        [TestInitialize]
        public void TestSetup()
        {
            _fakeRepository = new FakeRepositorioComponentes();
            _fakeComponente = _fakeRepository.TomaComponente(1);


        }
        [TestMethod]
        public void PruebaFakeRepository()
        {
            var result = _controller.Create();
            Assert.IsNotNull(result);
            Assert.AreEqual(3, _fakeRepository.ListaComponentes().Count);


        }

        [TestMethod]

        public void PruebaControladorCrearComponente()
        {
            var result = _controller.Create() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Create", result.ViewName);

        }

    

        [TestMethod]
        public void PruebaControllerCrearComponente()
        {
            // Act
            var result = _controller.Create(new Componente()
            {
                Calor = 15,
                Cores = 25,
                Coste = 345,
                Descripcion = "Inventado",
                Megas = 21,
                NumeroSerie = "4537",
                TipoComponente = EnumTipoComponente.MemoriaRAM,
                Id = 4
            });

            // Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
            var redirectToAction = result as RedirectToActionResult;
            Assert.AreEqual("Index", redirectToAction.ActionName);
        }


        [TestMethod]


        public void PruebaControladorborrar()
        {
            var listaComponentesPreBorrado = _controller.Index();
            var result = _controller.Delete(2) as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Delete", result.ViewName);
            Assert.IsNotNull(result.ViewData.Model);



            var listaComponentes = _controller.Index();
            Assert.IsNotNull(listaComponentes);
            Assert.AreNotEqual(listaComponentesPreBorrado, listaComponentes);

        }

        [TestMethod]


        public void PruebaControladorBorrarNull()
        {

            var result = _controller.Delete(7) as ViewResult;
            Assert.IsNull(result);
        }


        [TestMethod]
        public void PruebaControladorBorrarConfirmed()
        {

            var resultnull = _controller.DeleteConfirmed(5) as ViewResult;
            Assert.IsNull(resultnull);

            var result = _controller.DeleteConfirmed(1) as RedirectToActionResult;
            Assert.AreEqual("Index", result.ActionName);
        }



        [TestMethod]
        public void PruebaControladorEditar()
        {

            var componenteAEditar = _controller.Edit(3, _fakeComponente) as RedirectToActionResult;
            var comprobacion = _controller.Index() as ViewResult;

            Assert.IsNotNull(componenteAEditar);
            Assert.IsNotNull(comprobacion);
            Assert.AreEqual("Index", componenteAEditar.ActionName);

            var listaComponentes = comprobacion.ViewData.Model as List<Componente>;
            Assert.IsNotNull(listaComponentes);
            Assert.IsTrue(_fakeComponente.Equals(listaComponentes[2]));

        }





        [TestMethod]
        public void PruebaControllerEditar()
        {
            var result = _controller.Edit(1) as ViewResult;
            Assert.AreEqual("Edit", result.ViewName);

            var resultnull = _controller.Edit(8) as ViewResult;
            Assert.IsNull(resultnull);


        }

        [TestMethod]
        public void PruebaComponenteDetalles()
        {
            var result = _controller.Details(1) as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Details", result.ViewName);
            var resultadocomponente = result.ViewData.Model;
            Assert.IsTrue(_fakeComponente.Equals(resultadocomponente));

            var resultComponenteNotFound = _controller.Details(5) as ViewResult;
            Assert.IsNull(resultComponenteNotFound);


        }

        [TestMethod]
        public void PruebaComponenteIndex()
        {
            var result = _controller.Index() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result.ViewData.Model);
            var listaComponentes = result.ViewData.Model as List<Componente>;
            Assert.IsNotNull(listaComponentes);
            Assert.AreEqual(3, listaComponentes.Count);
        }

    }
}


