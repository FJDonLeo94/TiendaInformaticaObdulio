using NewTiendaInformatica;
using NewTiendaInformatica.Componentes.Validator;
using NewTiendaInformatica.Componentes;
using NewTiendaInformatica.Comportamientos;

namespace NewTI.Test.Componentes.Validator
{
    [TestClass]
    public class UnitTestValidatorComponentes
    {
        private ValidatorComponenteAttribute _validator;
        private Componente _validComponente;
        private Componente _invalidComponente;

        [TestInitialize]
        public void Initialize()
        {
            _validator = new ValidatorComponenteAttribute();
            _validComponente = new Componente("1234", 10, 4, 8192, "Componente de prueba", 23,
                EnumTipoComponente.MemoriaRAM);
            _invalidComponente = new Componente("", -1, -1, -1, "", -1, EnumTipoComponente.MemoriaRAM);
        }

        [TestMethod]
        public void TestValidComponente()
        {
            var result = _validator.IsValid(_validComponente);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestComponenteInvalid()
        {

            var result = _validator.IsValid(_invalidComponente);
            Assert.IsFalse(result);
        }

    }
}
