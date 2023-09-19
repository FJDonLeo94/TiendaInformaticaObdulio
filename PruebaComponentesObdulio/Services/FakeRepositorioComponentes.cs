using NewTiendaInformatica.Componentes;
using Componente = PruebaComponentesObdulio.Models.Componente;

namespace PruebaComponentesObdulio.Services
{
    public class FakeRepositorioComponentes : IRepositoryComponentes
    {
        readonly List<Componente> misComponentes = new();
        public FakeRepositorioComponentes()
        {
            misComponentes.Add(new Componente() {
                Id = 1,
                NumeroSerie = "789_XCS",
                Descripcion = "Procesador Intel i7",
                Calor = 10,
                Megas = 0,
                Cores = 9,
                Coste = 134.0,
                TipoComponente = EnumTipoComponente.Procesador
            });
            misComponentes.Add(new Componente()
            {
                Id = 2,
                NumeroSerie = "879FH",
                Descripcion = "Banco de memoria SDRAM",
                Calor = 10,
                Megas = 512,
                Cores = 0,
                Coste = 100.0,
                TipoComponente = EnumTipoComponente.MemoriaRAM
            });
            misComponentes.Add(new Componente()
            {
                Id = 3,
                NumeroSerie = "789_XX",
                Descripcion = "Disco Duro Scan Disk",
                Calor = 10,
                Megas = 500000,
                Cores = 0,
                Coste = 50.0,
                TipoComponente = EnumTipoComponente.Almacenamiento
            });

        }


        

        public void EditComponente(Componente componente)
        {
            var ComponenteAEditar = TomaComponente(componente.Id);
            if (ComponenteAEditar != null)
            {
                ComponenteAEditar.NumeroSerie = componente.NumeroSerie;
                ComponenteAEditar.Descripcion = componente.Descripcion;
                ComponenteAEditar.Calor = componente.Calor;
                ComponenteAEditar.Megas = componente.Megas;
                ComponenteAEditar.Cores = componente.Cores;
                ComponenteAEditar.Coste = componente.Coste;
                ComponenteAEditar.TipoComponente = componente.TipoComponente;

            }
        }

        public void AddComponente(Componente componente)
        {
            
            misComponentes.Add(componente);
        }

        public void BorraComponente(int Id)
        {
            var componentToRemove = misComponentes.First(comp => comp.Id == Id);
            if (componentToRemove != null)
            {
                misComponentes.Remove(componentToRemove);
            }
        }

        public List<Componente> ListaComponentes()
        {
            return misComponentes;
        }

        public Componente TomaComponente(int Id)
        {
            if (Id < 0 || Id > misComponentes.Count)
            {
                return null;
            }
            return misComponentes.First(x => x.Id == Id);

        }
    }
}





