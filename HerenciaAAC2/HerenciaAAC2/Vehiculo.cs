using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAAC2
{
    class Vehiculo
    {
        private decimal _velocidadActual { get; set; }
        public decimal VelocidadActual
        {
            get
            {
                return _velocidadActual + 2;
            }
            set
            {
                _velocidadActual = value;
            }
        }
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void Arrancar()
        {
            Console.Write("Arrancar vehiculo");
        }
    }
}
