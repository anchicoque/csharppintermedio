using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAAC2
{
    class Coche : Vehiculo
    {
        public string Traccion { get; set; }

        public Coche(string marca, string modelo, string traccion) : base(marca, modelo)
        {
            Traccion = traccion;
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancar coche");
        }
    }
}
