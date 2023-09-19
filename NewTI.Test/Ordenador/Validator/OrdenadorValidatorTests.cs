using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewTiendaInformatica.Ordenador.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Ordenador.Builder;

namespace NewTiendaInformatica.Ordenador.Validator.Tests
{
    [TestClass]
    public class OrdenadorValidatorTest
    {
        private BuilderOrdenador _builder;
        private Ordenador _ordenadorValido;
        private Ordenador _ordenadorInvalido;
        private OrdenadorValidator _validador;

        [TestInitialize]
        public void Setup()
        {
            _builder = new BuilderOrdenador();
            _validador = new OrdenadorValidator();

            // Ordenador válido con todos los componentes necesarios
            _ordenadorValido = _builder.ConstruirOrdenador(EnumComponente.BancoDeMemoriaSDRAM_879FH,
                EnumComponente.DiscoDuroSanDisk_789_XX,
                EnumComponente.ProcesadorInteli7_789_XCD);
            // Ordenador inválido (sin memoria RAM)
            _ordenadorInvalido = _builder.ConstruirOrdenador(EnumComponente.DiscoDuroSanDisk_789_XX,
                EnumComponente.ProcesadorInteli7_789_XCD);
        }

        [TestMethod]
        public void OrdenadorValido_PasaLaValidacion()
        {
            bool result = _validador.IsValid(_ordenadorValido);
            Assert.IsTrue(result, "El ordenador válido no pasó la validación");
        }

        [TestMethod]
        public void OrdenadorInvalido_NoPasaLaValidacion()
        {
            bool result = _validador.IsValid(_ordenadorInvalido);
            Assert.IsFalse(result, "El ordenador inválido pasó la validación");
        }
    }
}