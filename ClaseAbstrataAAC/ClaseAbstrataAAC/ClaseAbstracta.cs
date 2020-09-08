using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstrataAAC
{    
    public abstract class TrianguloBase
    {
        public abstract void Perimetro();
        public abstract void Area();       
    }

    public class Escaleno : TrianguloBase
    {
        public override void Area()
        {
            Console.WriteLine("El area es Escaleno");
        }

        public override void Perimetro()
        {
            Console.WriteLine("El perimetros es Escaleno");
        }



    }
    public class Acutangulo : TrianguloBase
    {
        public override void Area()
        {
            Console.WriteLine("El area es Acutangulo");
        }

        public override void Perimetro()
        {
            Console.WriteLine("El perimetros es Acutangulo");
        }
        
    }
}
