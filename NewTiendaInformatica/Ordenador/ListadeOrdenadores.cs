using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Ordenador.Builder;

namespace NewTiendaInformatica.Ordenador
{
    public class ListadeOrdenadores
    {
        BuilderOrdenador builderOrdenador = new BuilderOrdenador();

        public Ordenador? CrearOrdenadorMaria()
        {
            var ordenadorMaria = builderOrdenador.ConstruirOrdenador(
                EnumComponente.ProcesadorInteli7_789_XCS,
                EnumComponente.BancoDeMemoriaSDRAM_879FH,
                EnumComponente.DiscoDuroSanDisk_789_XX
                
                
            );

            if (ordenadorMaria != null)
            {
                var caracteristicasMaria = builderOrdenador.CalcularCaracteristicas(ordenadorMaria);
                int calorTotalMaria = caracteristicasMaria.CalorTotal;
                int coresTotalMaria = caracteristicasMaria.CoreTotal;
                decimal precioTotalMaria = caracteristicasMaria.PrecioTotal;
                long megasTotalMaria = caracteristicasMaria.MegaTotal;
            }

            return ordenadorMaria;
        }

        public Ordenador? CrearOrdenadorAndres()
        {
            var ordenadorAndres = builderOrdenador.ConstruirOrdenador(
                EnumComponente.ProcesadorRyzenAMD_797X3,
                EnumComponente.BancoDeMemoriaSDRAM_879FH_T,
                EnumComponente.DiscoDuroSanDisk_789_XX_3
            );

            if (ordenadorAndres != null)
            {
                builderOrdenador.CalcularCaracteristicas(ordenadorAndres);
                var caracteristicasAndres = builderOrdenador.CalcularCaracteristicas(ordenadorAndres);
                int calorTotalAndres = caracteristicasAndres.CalorTotal;
                int coresTotalAndres = caracteristicasAndres.CoreTotal;
                decimal precioTotalAndres = caracteristicasAndres.PrecioTotal;
                long megasTotalAndres = caracteristicasAndres.MegaTotal;

            }

            return ordenadorAndres;
        }

        public  Ordenador? CrearOrdenadorTiburcioII()
        {
            var ordenadorTiburcioII = builderOrdenador.ConstruirOrdenador(
                EnumComponente.ProcesadorInteli7_789_XCS,
                EnumComponente.BancoDeMemoriaSDRAM_879FH,
                EnumComponente.DiscoDuroSanDisk_789_XX,
                EnumComponente.DiscoExternoSam_1789_XCS,
                EnumComponente.DiscoMecanicoPatatin_788fg
            );

            if (ordenadorTiburcioII != null)
            {
                var caracteristicasTiburcioII = builderOrdenador.CalcularCaracteristicas(ordenadorTiburcioII);
                int calorTotalTiburcioII = caracteristicasTiburcioII.CalorTotal;
                int coresTotalTiburcioII = caracteristicasTiburcioII.CoreTotal;
                decimal precioTotalTiburcioII = caracteristicasTiburcioII.PrecioTotal;
                long megasTotalTiburcioII = caracteristicasTiburcioII.MegaTotal;
            }

            return ordenadorTiburcioII;
        }

        public  Ordenador? CrearOrdenadorAndresCF()
        {
            var ordenadorAndresCF = builderOrdenador.ConstruirOrdenador(
                EnumComponente.ProcesadorRyzenAMD_797X3,
                EnumComponente.BancoDeMemoriaSDRAM_879FH_T,
                EnumComponente.DiscoDuroSanDisk_789_XX_3,
                EnumComponente.DiscoMecanicoPatatin_788fg
            );

            if (ordenadorAndresCF != null)
            {
                builderOrdenador.CalcularCaracteristicas(ordenadorAndresCF);
                var caracteristicasAndresCF = builderOrdenador.CalcularCaracteristicas(ordenadorAndresCF);
                int calorTotalAndresCF = caracteristicasAndresCF.CalorTotal;
                int coresTotalAndresCF = caracteristicasAndresCF.CoreTotal;
                decimal precioTotalAndresCF = caracteristicasAndresCF.PrecioTotal;
                long megasTotalAndresCF = caracteristicasAndresCF.MegaTotal;

            }

            return ordenadorAndresCF;
        }
    }
}
