using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstrataAAC
{
    class Program
    {
        static void Main(string[] args)
        {
            Acutangulo acutangulo = new Acutangulo();
            Escaleno escaleno = new Escaleno();

            acutangulo.Area();
            escaleno.Area();

            Console.ReadLine();
        }
    }
}
