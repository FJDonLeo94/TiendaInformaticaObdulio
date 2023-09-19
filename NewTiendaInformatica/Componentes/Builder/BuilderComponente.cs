using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTiendaInformatica.Componentes.Validator;
using NewTiendaInformatica.Comportamientos;

namespace NewTiendaInformatica.Componentes.Builder
{
    public class BuilderComponente : IBuilderComponente
    {
        public Componente? DameComponente(EnumComponente tipo)
        {
            return tipo switch
            {
                EnumComponente.ProcesadorInteli7_789_XCS => DameComponente("789_XCS", "Procesador Intel i7", 10, 0, 9,
                    134, EnumTipoComponente.Procesador),
                EnumComponente.ProcesadorInteli7_789_XCD => DameComponente("789_XCD", "Procesador Intel i7", 12, 0, 10,
                    138, EnumTipoComponente.Procesador),
                EnumComponente.ProcesadorInteli7_789_XCT => DameComponente("789_XCT", "Procesador Intel i7", 22, 0, 11,
                    138, EnumTipoComponente.Procesador),
                EnumComponente.BancoDeMemoriaSDRAM_879FH => DameComponente("879FH", "Banco de memoria SDRAM", 10, 512,
                    0, 100, EnumTipoComponente.MemoriaRAM),
                EnumComponente.BancoDeMemoriaSDRAM_879FH_L => DameComponente("879FH_L", "Banco de memoria SDRAM", 15,
                    1024, 0, 125, EnumTipoComponente.MemoriaRAM),
                EnumComponente.BancoDeMemoriaSDRAM_879FH_T => DameComponente("879FH_T", "Banco de memoria SDRAM", 24,
                    2028, 0, 150, EnumTipoComponente.MemoriaRAM),
                EnumComponente.DiscoDuroSanDisk_789_XX => DameComponente("789_XX", "Disco Duro Scan Disk", 10, 500000,
                    0, 50, EnumTipoComponente.Almacenamiento),
                EnumComponente.DiscoDuroSanDisk_789_XX_2 => DameComponente("789_XX_2", "Disco Duro Scan Disk", 29,
                    1000000, 0, 90, EnumTipoComponente.Almacenamiento),
                EnumComponente.DiscoDuroSanDisk_789_XX_3 => DameComponente("789_XX_3", "Disco Duro Scan Disk", 39,
                    2000000, 0, 128, EnumTipoComponente.Almacenamiento),
                EnumComponente.ProcesadorRyzenAMD_797X => DameComponente("797-X", "Procesador Ryzen AMD", 30,
                    0, 10, 78, EnumTipoComponente.Procesador),
                EnumComponente.ProcesadorRyzenAMD_797X2 => DameComponente("797-X-2", "Procesador Ryzen AMD", 30,
                    0, 29, 178, EnumTipoComponente.Procesador),
                EnumComponente.ProcesadorRyzenAMD_797X3 => DameComponente("797-X-3", "Procesador Ryzen AMD", 60,
                    0, 34, 278, EnumTipoComponente.Procesador),
                EnumComponente.DiscoMecanicoPatatin_788fg => DameComponente("788-fg", "Disco Mecanico Patatin", 35,
                    250, 0, 37, EnumTipoComponente.Almacenamiento),
                EnumComponente.DiscoMecanicoPatatin_788fg2 => DameComponente("788-fg-2", "Disco Mecanico Patatin", 35,
                    250, 0, 67, EnumTipoComponente.Almacenamiento),
                EnumComponente.DiscoMecanicoPatatin_788fg3 => DameComponente("788-fg-3", "Disco Mecanico Patatin", 35,
                    250, 0, 97, EnumTipoComponente.Almacenamiento),
                EnumComponente.DiscoExternoSam_1789_XCS => DameComponente("1789-XCS", "Disco Externo Sam", 10,
                    9000000, 0, 134, EnumTipoComponente.Almacenamiento),
                EnumComponente.DiscoExternoSam_1789_XCD => DameComponente("1789-XCD", "Disco Externo Sam", 12,
                    10000000, 0, 138, EnumTipoComponente.Almacenamiento),
                EnumComponente.DiscoExternoSam_1789_XCT => DameComponente("1789-XCT", "Disco Externo Sam", 22,
                    11000000, 0, 140, EnumTipoComponente.Almacenamiento),
                _ => null
            };
        }

        public Componente? DameComponente(string serie, string descripcion, int calor, long megas, int cores, decimal coste,
            EnumTipoComponente tipo)
        {
            INumSerie seriebuilder;
            if (serie != "")
            {
                seriebuilder = new ConSerie(serie);
            }
            else
            {
                seriebuilder = new SinSerie();
            }

            IMegaBytes megasbuilder;
            if (megas != 0)
            {
                megasbuilder = new ConMegas(megas);
            }
            else
            {
                megasbuilder = new SinMegas();
            }

            ICores coresbuilder;
            if (cores != 0)
            {
                coresbuilder = new ConCores(cores);
            }
            else
            {
                coresbuilder = new SinCores();
            }

            IGrados gradosbuilder;
            if (calor != 0)
            {
                gradosbuilder = new ConCalor(calor);
            }
            else
            {
                gradosbuilder = new SinCalor();
            }

            IPrecio preciobuilder;
            if (coste != 0)
            {
                preciobuilder = new ConPrecio(coste);
            }
            else
            {
                preciobuilder = new SinPrecio();
            }

            IDescripcion descripcionbuilder;
            if (descripcion != "")
            {
                descripcionbuilder = new ConDescripcion(descripcion);
            }
            else
            {
                descripcionbuilder = new SinDescripcion();
            }

            Componente miComponente = new(serie, calor, cores, megas, descripcion, coste, tipo);
            var validation = new ValidatorComponenteAttribute();
            if (validation.IsValid(miComponente))
                return miComponente;
            else
                return null;
        }
    }
}
