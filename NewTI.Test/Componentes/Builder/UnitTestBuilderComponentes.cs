using NewTiendaInformatica;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Componentes.Builder;
using NewTiendaInformatica.Comportamientos;

namespace NewTI.Test.Componentes.Builder
{
    [TestClass]
    public class UnitTestBuilderComponentes
    {
        private BuilderComponente _builder;
        private Componente componenteSDRAM_879FH;
        private Componente componenteSDRAM_879FH_L;
        private Componente componenteSDRAM_879FH_T;
        private Componente componenteSanDisk_789_XX;
        private Componente componenteSanDisk_789_XX_2;
        private Componente componenteSanDisk_789_XX_3;
        private Componente componentePatatin_788fg;
        private Componente componentePatatin_788fg2;
        private Componente componentePatatin_788fg3;
        private Componente componenteInteli7_789_XCD;
        private Componente componenteInteli7_789_XCS;
        private Componente componenteInteli7_789_XCT;
        private Componente componenteRyzenAMD_797X;
        private Componente componenteRyzenAMD_797X2;
        private Componente componenteRyzenAMD_797X3;



        [TestInitialize]
        public void Initialize()
        {
            _builder = new BuilderComponente();
             componenteSDRAM_879FH = _builder.DameComponente(EnumComponente.BancoDeMemoriaSDRAM_879FH);
             componenteSDRAM_879FH_L = _builder.DameComponente((EnumComponente.BancoDeMemoriaSDRAM_879FH_L));
             componenteSDRAM_879FH_T = _builder.DameComponente((EnumComponente.BancoDeMemoriaSDRAM_879FH_T));
             componenteSanDisk_789_XX = _builder.DameComponente((EnumComponente.DiscoDuroSanDisk_789_XX));
             componenteSanDisk_789_XX_2 = _builder.DameComponente((EnumComponente.DiscoDuroSanDisk_789_XX_2));
             componenteSanDisk_789_XX_3 = _builder.DameComponente((EnumComponente.DiscoDuroSanDisk_789_XX_3));
             componentePatatin_788fg = _builder.DameComponente((EnumComponente.DiscoMecanicoPatatin_788fg));
             componentePatatin_788fg2 = _builder.DameComponente((EnumComponente.DiscoMecanicoPatatin_788fg2));
             componentePatatin_788fg3 = _builder.DameComponente((EnumComponente.DiscoMecanicoPatatin_788fg3));
             componenteInteli7_789_XCD = _builder.DameComponente((EnumComponente.ProcesadorInteli7_789_XCD));
             componenteInteli7_789_XCS = _builder.DameComponente((EnumComponente.ProcesadorInteli7_789_XCS));
             componenteInteli7_789_XCT = _builder.DameComponente((EnumComponente.ProcesadorInteli7_789_XCT));
             componenteRyzenAMD_797X = _builder.DameComponente((EnumComponente.ProcesadorRyzenAMD_797X));
             componenteRyzenAMD_797X2 = _builder.DameComponente((EnumComponente.ProcesadorRyzenAMD_797X2));
             componenteRyzenAMD_797X3 = _builder.DameComponente((EnumComponente.ProcesadorRyzenAMD_797X3));

           


        }

       
        [TestMethod]
        public void TestSDRAM_879FH()
        {
            Assert.IsNotNull(componenteSDRAM_879FH);
            Assert.AreEqual("879FH", componenteSDRAM_879FH.NumeroSerie);
            Assert.AreEqual(10, componenteSDRAM_879FH.Calor);
            Assert.AreEqual(0, componenteSDRAM_879FH.Cores);
            Assert.AreEqual(512, componenteSDRAM_879FH.Megas);
            Assert.AreEqual("Banco de memoria SDRAM", componenteSDRAM_879FH.Descripcion);
            Assert.AreEqual(100, componenteSDRAM_879FH.Coste);
            Assert.AreEqual(EnumTipoComponente.MemoriaRAM, componenteSDRAM_879FH.TipoComponente);


        }
        [TestMethod]
        public void TestSDRAM_879FH_L()
        {
            Assert.IsNotNull(componenteSDRAM_879FH_L);
            Assert.AreEqual("879FH_L", componenteSDRAM_879FH_L.NumeroSerie);
            Assert.AreEqual(15, componenteSDRAM_879FH_L.Calor);
            Assert.AreEqual(0, componenteSDRAM_879FH_L.Cores);
            Assert.AreEqual(1024, componenteSDRAM_879FH_L.Megas);
            Assert.AreEqual("Banco de memoria SDRAM", componenteSDRAM_879FH_L.Descripcion);
            Assert.AreEqual(125, componenteSDRAM_879FH_L.Coste);
            Assert.AreEqual(EnumTipoComponente.MemoriaRAM, componenteSDRAM_879FH_L.TipoComponente);


        }
        [TestMethod]
        public void TestSDRAM_879FH_T()
        {
            Assert.IsNotNull(componenteSDRAM_879FH_T);
            Assert.AreEqual("879FH_T", componenteSDRAM_879FH_T.NumeroSerie);
            Assert.AreEqual(24, componenteSDRAM_879FH_T.Calor);
            Assert.AreEqual(0, componenteSDRAM_879FH_T.Cores);
            Assert.AreEqual(2028, componenteSDRAM_879FH_T.Megas);
            Assert.AreEqual("Banco de memoria SDRAM", componenteSDRAM_879FH_T.Descripcion);
            Assert.AreEqual(150, componenteSDRAM_879FH_T.Coste);
            Assert.AreEqual(EnumTipoComponente.MemoriaRAM, componenteSDRAM_879FH_T.TipoComponente);


        }
        [TestMethod]
        public void TestSanDisk_789_XX()
        {
            Assert.IsNotNull(componenteSanDisk_789_XX);
            Assert.AreEqual("789_XX", componenteSanDisk_789_XX.NumeroSerie);
            Assert.AreEqual(10, componenteSanDisk_789_XX.Calor);
            Assert.AreEqual(0, componenteSanDisk_789_XX.Cores);
            Assert.AreEqual(500000, componenteSanDisk_789_XX.Megas);
            Assert.AreEqual("Disco Duro Scan Disk", componenteSanDisk_789_XX.Descripcion);
            Assert.AreEqual(50, componenteSanDisk_789_XX.Coste);
            Assert.AreEqual(EnumTipoComponente.Almacenamiento, componenteSanDisk_789_XX.TipoComponente);


        }
        [TestMethod]
        public void TestSanDisk_789_XX_2()
        {
            Assert.IsNotNull(componenteSanDisk_789_XX_2);
            Assert.AreEqual("789_XX_2", componenteSanDisk_789_XX_2.NumeroSerie);
            Assert.AreEqual(29, componenteSanDisk_789_XX_2.Calor);
            Assert.AreEqual(0, componenteSanDisk_789_XX_2.Cores);
            Assert.AreEqual(1000000, componenteSanDisk_789_XX_2.Megas);
            Assert.AreEqual("Disco Duro Scan Disk", componenteSanDisk_789_XX_2.Descripcion);
            Assert.AreEqual(90, componenteSanDisk_789_XX_2.Coste);
            Assert.AreEqual(EnumTipoComponente.Almacenamiento, componenteSanDisk_789_XX_2.TipoComponente);


        }
        [TestMethod]
        public void TestSanDisk_789_XX_3()
        {
            Assert.IsNotNull(componenteSanDisk_789_XX_3);
            Assert.AreEqual("789_XX_3", componenteSanDisk_789_XX_3.NumeroSerie);
            Assert.AreEqual(39, componenteSanDisk_789_XX_3.Calor);
            Assert.AreEqual(0, componenteSanDisk_789_XX_3.Cores);
            Assert.AreEqual(2000000, componenteSanDisk_789_XX_3.Megas);
            Assert.AreEqual("Disco Duro Scan Disk", componenteSanDisk_789_XX_3.Descripcion);
            Assert.AreEqual(128, componenteSanDisk_789_XX_3.Coste);
            Assert.AreEqual(EnumTipoComponente.Almacenamiento, componenteSanDisk_789_XX_3.TipoComponente);


        }
        [TestMethod]
        public void TestPatatin_788fg()
        {
            Assert.IsNotNull(componentePatatin_788fg);
            Assert.AreEqual("788-fg", componentePatatin_788fg.NumeroSerie);
            Assert.AreEqual(35, componentePatatin_788fg.Calor);
            Assert.AreEqual(0, componentePatatin_788fg.Cores);
            Assert.AreEqual(250, componentePatatin_788fg.Megas);
            Assert.AreEqual("Disco Mecanico Patatin", componentePatatin_788fg.Descripcion);
            Assert.AreEqual(37, componentePatatin_788fg.Coste);
            Assert.AreEqual(EnumTipoComponente.Almacenamiento, componentePatatin_788fg.TipoComponente);


        }
        [TestMethod]
        public void TestPatatin_788fg2()
        {
            Assert.IsNotNull(componentePatatin_788fg2);
            Assert.AreEqual("788-fg-2", componentePatatin_788fg2.NumeroSerie);
            Assert.AreEqual(35, componentePatatin_788fg2.Calor);
            Assert.AreEqual(0, componentePatatin_788fg2.Cores);
            Assert.AreEqual(250, componentePatatin_788fg2.Megas);
            Assert.AreEqual("Disco Mecanico Patatin", componentePatatin_788fg2.Descripcion);
            Assert.AreEqual(67, componentePatatin_788fg2.Coste);
            Assert.AreEqual(EnumTipoComponente.Almacenamiento, componentePatatin_788fg2.TipoComponente);


        }
        [TestMethod]
        public void TestPatatin_788fg3()
        {
            Assert.IsNotNull(componentePatatin_788fg3);
            Assert.AreEqual("788-fg-3", componentePatatin_788fg3.NumeroSerie);
            Assert.AreEqual(35, componentePatatin_788fg3.Calor);
            Assert.AreEqual(0, componentePatatin_788fg3.Cores);
            Assert.AreEqual(250, componentePatatin_788fg3.Megas);
            Assert.AreEqual("Disco Mecanico Patatin", componentePatatin_788fg3.Descripcion);
            Assert.AreEqual(97, componentePatatin_788fg3.Coste);
            Assert.AreEqual(EnumTipoComponente.Almacenamiento, componentePatatin_788fg3.TipoComponente);


        }
        [TestMethod]
        public void TestInteli7_789_XCD()
        {
            Assert.IsNotNull(componenteInteli7_789_XCD);
            Assert.AreEqual("789_XCD", componenteInteli7_789_XCD.NumeroSerie);
            Assert.AreEqual(12, componenteInteli7_789_XCD.Calor);
            Assert.AreEqual(10, componenteInteli7_789_XCD.Cores);
            Assert.AreEqual(0, componenteInteli7_789_XCD.Megas);
            Assert.AreEqual("Procesador Intel i7", componenteInteli7_789_XCD.Descripcion);
            Assert.AreEqual(138, componenteInteli7_789_XCD.Coste);
            Assert.AreEqual(EnumTipoComponente.Procesador, componenteInteli7_789_XCD.TipoComponente);


        }
        [TestMethod]
        public void TestInteli7_789_XCS()
        {
            Assert.IsNotNull(componenteInteli7_789_XCS);
            Assert.AreEqual("789_XCS", componenteInteli7_789_XCS.NumeroSerie);
            Assert.AreEqual(10, componenteInteli7_789_XCS.Calor);
            Assert.AreEqual(9, componenteInteli7_789_XCS.Cores);
            Assert.AreEqual(0, componenteInteli7_789_XCS.Megas);
            Assert.AreEqual("Procesador Intel i7", componenteInteli7_789_XCS.Descripcion);
            Assert.AreEqual(134, componenteInteli7_789_XCS.Coste);
            Assert.AreEqual(EnumTipoComponente.Procesador, componenteInteli7_789_XCS.TipoComponente);


        }
        [TestMethod]
        public void TestInteli7_789_XCT()
        {
            Assert.IsNotNull(componenteInteli7_789_XCT);
            Assert.AreEqual("789_XCT", componenteInteli7_789_XCT.NumeroSerie);
            Assert.AreEqual(22, componenteInteli7_789_XCT.Calor);
            Assert.AreEqual(11, componenteInteli7_789_XCT.Cores);
            Assert.AreEqual(0, componenteInteli7_789_XCT.Megas);
            Assert.AreEqual("Procesador Intel i7", componenteInteli7_789_XCT.Descripcion);
            Assert.AreEqual(138, componenteInteli7_789_XCT.Coste);
            Assert.AreEqual(EnumTipoComponente.Procesador, componenteInteli7_789_XCT.TipoComponente);


        }
        [TestMethod]
        public void TestRyzenAMD_797X()
        {
            Assert.IsNotNull(componenteRyzenAMD_797X);
            Assert.AreEqual("797-X", componenteRyzenAMD_797X.NumeroSerie);
            Assert.AreEqual(30, componenteRyzenAMD_797X.Calor);
            Assert.AreEqual(10, componenteRyzenAMD_797X.Cores);
            Assert.AreEqual(0, componenteRyzenAMD_797X.Megas);
            Assert.AreEqual("Procesador Ryzen AMD", componenteRyzenAMD_797X.Descripcion);
            Assert.AreEqual(78, componenteRyzenAMD_797X.Coste);
            Assert.AreEqual(EnumTipoComponente.Procesador, componenteRyzenAMD_797X.TipoComponente);


        }
        [TestMethod]
        public void TestRyzenAMD_797X2()
        {
            Assert.IsNotNull(componenteRyzenAMD_797X2);
            Assert.AreEqual("797-X-2", componenteRyzenAMD_797X2.NumeroSerie);
            Assert.AreEqual(30, componenteRyzenAMD_797X2.Calor);
            Assert.AreEqual(29, componenteRyzenAMD_797X2.Cores);
            Assert.AreEqual(0, componenteRyzenAMD_797X2.Megas);
            Assert.AreEqual("Procesador Ryzen AMD", componenteRyzenAMD_797X2.Descripcion);
            Assert.AreEqual(178, componenteRyzenAMD_797X2.Coste);
            Assert.AreEqual(EnumTipoComponente.Procesador, componenteRyzenAMD_797X2.TipoComponente);


        }
        [TestMethod]
        public void TestRyzenAMD_797X3()
        {
            Assert.IsNotNull(componenteRyzenAMD_797X3);
            Assert.AreEqual("797-X-3", componenteRyzenAMD_797X3.NumeroSerie);
            Assert.AreEqual(60, componenteRyzenAMD_797X3.Calor);
            Assert.AreEqual(34, componenteRyzenAMD_797X3.Cores);
            Assert.AreEqual(0, componenteRyzenAMD_797X3.Megas);
            Assert.AreEqual("Procesador Ryzen AMD", componenteRyzenAMD_797X3.Descripcion);
            Assert.AreEqual(278, componenteRyzenAMD_797X3.Coste);
            Assert.AreEqual(EnumTipoComponente.Procesador, componenteRyzenAMD_797X3.TipoComponente);


        }


    }
}