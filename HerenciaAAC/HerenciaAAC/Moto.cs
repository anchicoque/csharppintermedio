using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAAC
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }

        public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
        {            
            Cilindrada = cilindrada;
            Console.WriteLine("desde coche Cilindrada: " + Cilindrada);
        }

        public new void Arrancar()
        {
            Console.WriteLine("Arrancar moto");
        }
    }
}
