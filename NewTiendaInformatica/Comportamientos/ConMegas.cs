namespace NewTiendaInformatica.Comportamientos
{
    public class ConMegas : IMegaBytes
    {
        public ConMegas(long megas)
        {
            Megas = megas;
        }
        public long Megas { get; }
    }
}