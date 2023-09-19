// See https://aka.ms/new-console-template for more information
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Ordenador.Builder;
using NewTiendaInformatica.Pedidos;

class Program
{
    static void Main(string[] args)
    {
        BuilderOrdenador builderOrdenador = new BuilderOrdenador();

        var ordenador = builderOrdenador.ConstruirOrdenador(EnumComponente.BancoDeMemoriaSDRAM_879FH,
            EnumComponente.DiscoDuroSanDisk_789_XX,
            EnumComponente.ProcesadorInteli7_789_XCD);

        if (ordenador != null)
        {
            builderOrdenador.CalcularCaracteristicas(ordenador);
            var caracteristicaspc = builderOrdenador.CalcularCaracteristicas(ordenador);

            int calorTotal = caracteristicaspc.CalorTotal;
            int coresTotal = caracteristicaspc.CoreTotal;
            decimal precioTotal = caracteristicaspc.PrecioTotal;
            long megasTotal = caracteristicaspc.MegaTotal;

            Console.WriteLine($"Calor del ordenador :{calorTotal}.   Cores del ordenador:{coresTotal}.  Precio del ordenador:{precioTotal}  " +
                              $"Megas del ordenador:{megasTotal} ");
        }
        else
        {
            Console.WriteLine("No se pudo construir el ordenador. Asegúrate de que tiene al menos un componente de cada tipo: RAM, procesador y almacenamiento.");
        }
        Console.ReadKey();

    }
}

