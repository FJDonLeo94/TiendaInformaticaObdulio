namespace NewTiendaInformatica.Comportamientos
{
    public class ConPrecio : IPrecio
    {
        public ConPrecio(decimal coste)
        {
            Coste = coste;
        }
        public decimal Coste { get; }
    }
}