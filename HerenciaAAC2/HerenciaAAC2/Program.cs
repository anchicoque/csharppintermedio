﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAAC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("opel", "vectra", "2 ruedas");
            Moto moto1 = new Moto("kawasaki", "ninja", 1000);

            Console.WriteLine(coche1.Marca);
            Console.WriteLine(moto1.Marca);

            moto1.Arrancar();
            coche1.Arrancar();

            Console.ReadKey();
        }
    }
}
