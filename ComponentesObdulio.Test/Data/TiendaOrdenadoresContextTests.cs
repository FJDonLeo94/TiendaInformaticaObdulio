using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PruebaComponentesObdulio.Controllers;
using PruebaComponentesObdulio.CrossCuting.Logging;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Services;
using System.ComponentModel;
using System.Drawing;
using NewTiendaInformatica.Componentes;
using PruebaComponentesObdulio.Logica;
using PruebaComponentesObdulio.Models;
using Componente = PruebaComponentesObdulio.Models.Componente;

namespace ComponentesObdulio.Test.Controladores
{
    [TestClass]
    public class TiendaOrdenadoresContextTest
    {
        private DbContextOptions<TiendaOrdenadoresContext> _options;

        [TestInitialize]
        public void TestSetup()
        {
            _options = new DbContextOptionsBuilder<TiendaOrdenadoresContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new TiendaOrdenadoresContext(_options))
            {
                var initializer = new DbInitializer();
                initializer.Seed(context);
            }

            

        }

        [TestMethod]
        public void Test_DbInitializer_Seed()
        {
            using (var context = new TiendaOrdenadoresContext(_options))
            {
                var componentes = context.Componentes.ToList();
                Assert.AreEqual(5, componentes.Count);
                var ordenadores = context.Ordenadores.ToList();
                Assert.AreEqual(3, ordenadores.Count);
            }
        }

        

        private class DbInitializer
        {
            public void Seed(TiendaOrdenadoresContext context)
            {
                context.Componentes.AddRange(
                    new Componente()
                    {
                        Id = 1,
                        NumeroSerie = "789_XCS",
                        Descripcion = "Procesador Intel i7",
                        Calor = 10,
                        Megas = 0,
                        Cores = 9,
                        Coste = 134.0,
                        TipoComponente = EnumTipoComponente.Procesador
                    },
                    new Componente()
                    {
                        Id = 2,
                        NumeroSerie = "789_XCD",
                        Descripcion = "Procesador Intel i7",
                        Calor = 12,
                        Megas = 0,
                        Cores = 10,
                        Coste = 138.0,
                        TipoComponente = EnumTipoComponente.Procesador
                    },
                    new Componente()
                    {
                        Id = 3,
                        NumeroSerie = "789_XCT",
                        Descripcion = "Procesador Intel i7",
                        Calor = 22,
                        Megas = 0,
                        Cores = 11,
                        Coste = 138.0,
                        TipoComponente = EnumTipoComponente.Procesador
                    },
                    new Componente()
                    {
                        Id = 4,
                        NumeroSerie = "879FH",
                        Descripcion = "Banco de memoria SDRAM",
                        Calor = 10,
                        Megas = 512,
                        Cores = 0,
                        Coste = 100.0,
                        TipoComponente = EnumTipoComponente.MemoriaRAM
                    },
                    new Componente()
                    {
                        Id = 5,
                        NumeroSerie = "789_XX",
                        Descripcion = "Disco Duro Scan Disk",
                        Calor = 10,
                        Megas = 500000,
                        Cores = 0,
                        Coste = 50.0,
                        TipoComponente = EnumTipoComponente.Almacenamiento
                    }
                );

                context.Ordenadores.AddRange(
                    new Ordenador()
                    {
                        Id = 1,
                        Descripcion = "Almacen de componentes",
                        tipoOrdenador = EnumOrdenador.AlmacenComponentes,
                        PrecioTotal = 0


                    },
                    new Ordenador()
                    {
                        Id = 2,
                        Descripcion = "Ordenador de Maria",
                        tipoOrdenador = EnumOrdenador.OrdenadorMaria,
                        PrecioTotal = new BuilderPC().CaracteristicasMaria().PrecioTotal



                    },
                    new Ordenador()
                    {
                        Id = 3,
                        Descripcion = "Ordenador de Andres",
                        tipoOrdenador = EnumOrdenador.OrdenadorAndres,
                        PrecioTotal = new BuilderPC().CaracteristicasAndres().PrecioTotal
                    });
                context.SaveChanges();
            }
        }

    }
}