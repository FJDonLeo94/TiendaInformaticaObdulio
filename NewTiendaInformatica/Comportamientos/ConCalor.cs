using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTiendaInformatica.Comportamientos
{
    public class ConCalor : IGrados
    {
        public ConCalor(int calor)
        {
            Calor = calor;
        }
        public int Calor { get; }
    }
}
