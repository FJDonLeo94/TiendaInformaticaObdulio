namespace NewTiendaInformatica.Comportamientos
{
    public class ConSerie : INumSerie
    {
        public ConSerie(string serie)
        {
            NumeroSerie = serie;
        }
        public string NumeroSerie { get; }
    }
}