using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploStaticAAC
{
    class Program
    {
        public static int ResultadoSuma;
        static void Main(string[] args)
        {
            Console.WriteLine("Entra al main");

            //ResultadoSuma = Calculadora.Suma(1, 3);
            //Console.WriteLine(ResultadoSuma);
            Console.WriteLine(Calculadora.Suma(1, 3));
            Console.WriteLine("Mi : "+Calculadora.PI);

            Console.WriteLine("Enter para salir");
            Console.ReadLine();//Enter para continuar;
        }
    }
}
