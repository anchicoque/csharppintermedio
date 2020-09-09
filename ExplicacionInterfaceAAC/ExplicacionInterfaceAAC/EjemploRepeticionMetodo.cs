using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionInterfaceAAC
{
    public interface interfaz1
    {
        void MetodoInterfaz1();
    }
    public interface interfaz2
    {
        void MetodoInterfaz2();
    }
    class EjemploRepeticionMetodo : interfaz1, interfaz2
    {
        public void MetodoInterfaz1()
        {
            Console.WriteLine("desde MetodoRepetido1");
        }

        public void MetodoInterfaz2()
        {
            Console.WriteLine("desde MetodoRepetido2");
        }
    }
}
