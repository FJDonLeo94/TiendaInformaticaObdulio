namespace NewTiendaInformatica.Comportamientos
{
    public class ConCores : ICores
    {
        public ConCores(int cores)
        {
            Cores = cores;
        }
        public int Cores { get; }
    }
}