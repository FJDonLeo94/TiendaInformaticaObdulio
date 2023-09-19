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

namespace ComponentesObdulio.Test
{
    [TestClass]
    public class ComponentesFakeRepositoryTests
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
        public void FakeComponenteRevisionCompleta()
        {
            
            Assert.IsNotNull(_fakeComponente);
            Assert.AreEqual("789_XCS", _fakeComponente.NumeroSerie);
            Assert.AreEqual("Procesador Intel i7", _fakeComponente.Descripcion);
            Assert.AreEqual(10, _fakeComponente.Calor);
            Assert.AreEqual(0, _fakeComponente.Megas);
            Assert.AreEqual(9, _fakeComponente.Cores);
            Assert.AreEqual(134.0, _fakeComponente.Coste);
            Assert.AreEqual(EnumTipoComponente.Procesador, _fakeComponente.TipoComponente);


        }
        

        [TestMethod]

        public void PruebaRepositorioCrearComponente()
        {
            _fakeRepository.AddComponente(new Componente()
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

            var componenteInventado = _fakeRepository.TomaComponente(4);
            Assert.AreEqual(EnumTipoComponente.MemoriaRAM, componenteInventado.TipoComponente );



        }


        [TestMethod]
        public void PruebaRepositorioborrar()
        {
            var listaComponentesPreBorrado = _controller.Index();
            _fakeRepository.BorraComponente(2);
            var listaComponentes = _controller.Index();
            Assert.IsNotNull(listaComponentes);
            Assert.AreNotEqual(listaComponentesPreBorrado, listaComponentes);

        }

        [TestMethod]
        public void PruebaRepositorioEditar()
        {
            
            var componenteAEditar = _fakeRepository.TomaComponente(3);
            
            _fakeRepository.EditComponente(componenteAEditar);
            componenteAEditar.TipoComponente = EnumTipoComponente.Almacenamiento;
            Assert.AreEqual(EnumTipoComponente.Almacenamiento, componenteAEditar.TipoComponente);

        }



    }
}

    
