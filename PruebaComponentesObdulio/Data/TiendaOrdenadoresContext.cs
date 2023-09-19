


using Microsoft.EntityFrameworkCore;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Ordenador;
using NewTiendaInformatica.Ordenador.Builder;

using PruebaComponentesObdulio.Models;
using Componente = PruebaComponentesObdulio.Models.Componente;
using Ordenador = PruebaComponentesObdulio.Models.Ordenador;

namespace PruebaComponentesObdulio.Data
{
    public class TiendaOrdenadoresContext : DbContext
    {
        public TiendaOrdenadoresContext(DbContextOptions<TiendaOrdenadoresContext> options)
            : base(options)
        {

        }

        public DbSet<Componente> Componentes => Set<Componente>();
        public DbSet<Ordenador> Ordenadores => Set<Ordenador>();
        public DbSet<PedidoComponentes> PedidoComponentes => Set<PedidoComponentes>();
        public DbSet<PedidoOrdenadores> PedidoOrdenadores => Set<PedidoOrdenadores>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
            new OrdenadorInitializer(modelBuilder).Seed();

        }
    }

    public class OrdenadorInitializer
    {
        private readonly ModelBuilder modelBuilder;


        public OrdenadorInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {

            modelBuilder.Entity<Ordenador>().HasData(
                new Ordenador()
                {
                    Id = 1,
                    Descripcion = "Almacen de componentes",
                    


                },
                new Ordenador()
                {
                    Id = 2,
                    Descripcion = "Ordenador de Maria",
                    ListaComponentesPC =new List<Componente>() 



                },
                new Ordenador()
                {
                    Id = 3,
                    Descripcion = "Ordenador de Andres",
                    
                },
                new Ordenador()
                {
                    Id = 4,
                    Descripcion = "Ordenador de Tiburcio",
                    
                },
                new Ordenador()
                {
                    Id = 5,
                    Descripcion = "Ordenador de AndresCF",
                    
                },
                new Ordenador()
                {
                    Id = 6,
                    Descripcion = "Ordenador personalizado",
                    
                });


        }


    }



    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Componente>().HasData(
                (object)new Componente()
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
                    NumeroSerie = "879FH_L",
                    Descripcion = "Banco de memoria SDRAM",
                    Calor = 15,
                    Megas = 1024,
                    Cores = 0,
                    Coste = 125,
                    TipoComponente = EnumTipoComponente.MemoriaRAM
                },
                new Componente()
                {
                    Id = 6,
                    NumeroSerie = "879FH_T",
                    Descripcion = "Banco de memoria SDRAM",
                    Calor = 24,
                    Megas = 2028,
                    Cores = 0,
                    Coste = 150,
                    TipoComponente = EnumTipoComponente.MemoriaRAM
                },

                new Componente()
                {
                    Id = 7,
                    NumeroSerie = "789_XX",
                    Descripcion = "Disco Duro Scan Disk",
                    Calor = 10,
                    Megas = 500000,
                    Cores = 0,
                    Coste = 50,
                    TipoComponente = EnumTipoComponente.Almacenamiento
                },
                new Componente()
                {
                    Id = 8,
                    NumeroSerie = "789_XX_2",
                    Descripcion = "Disco Duro Scan Disk",
                    Calor = 29,
                    Megas = 1000000,
                    Cores = 0,
                    Coste = 90,
                    TipoComponente = EnumTipoComponente.Almacenamiento
                },
                new Componente()
                {
                    Id = 9,
                    NumeroSerie = "789_XX_3",
                    Descripcion = "Disco Duro Scan Disk",
                    Calor = 39,
                    Megas = 2000000,
                    Cores = 0,
                    Coste = 128,
                    TipoComponente = EnumTipoComponente.Almacenamiento
                },
                new Componente()
                {
                    Id = 10,
                    NumeroSerie = "797-X",
                    Descripcion = "Procesador Ryzen AMD",
                    Calor = 30,
                    Megas = 0,
                    Cores = 10,
                    Coste = 78,
                    TipoComponente = EnumTipoComponente.Procesador
                },
                new Componente()
                {
                    Id = 11,
                    NumeroSerie = "797-X-2",
                    Descripcion = "Procesador Ryzen AMD",
                    Calor = 30,
                    Megas = 0,
                    Cores = 29,
                    Coste = 178,
                    TipoComponente = EnumTipoComponente.Procesador
                },
                new Componente()
                {
                    Id = 12,
                    NumeroSerie = "797-X-3",
                    Descripcion = "Procesador Ryzen AMD",
                    Calor = 60,
                    Megas = 0,
                    Cores = 34,
                    Coste = 278,
                    TipoComponente = EnumTipoComponente.Procesador
                },
                new Componente()
                {
                    Id = 13,
                    NumeroSerie = "788-fg",
                    Descripcion = "Disco Mecanico Patatin",
                    Calor = 35,
                    Megas = 250,
                    Cores = 0,
                    Coste = 37,
                    TipoComponente = EnumTipoComponente.Almacenamiento
                },
                new Componente()
                {
                    Id = 14,
                    NumeroSerie = "788-fg-2",
                    Descripcion = "Disco Mecanico Patatin",
                    Calor = 35,
                    Megas = 250,
                    Cores = 0,
                    Coste = 67,
                    TipoComponente = EnumTipoComponente.Almacenamiento
                },
                new Componente()
                {
                    Id = 15,
                    NumeroSerie = "788-fg-3",
                    Descripcion = "Disco Mecanico Patatin",
                    Calor = 35,
                    Megas = 250,
                    Cores = 0,
                    Coste = 97,
                    TipoComponente = EnumTipoComponente.Almacenamiento
                }
            );
        }
    }

    
}
