using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAAC
{
    class TrianguloRectangulo : IPieza
    {
        public decimal LadoA { get; set; }
        public decimal LadoB { get; set; }
        public decimal Hipotenusa { get; set; }

        public TrianguloRectangulo(decimal ladoA, decimal ladob)
        {
            LadoA = ladoA;
            LadoB = ladob;
            Hipotenusa = CalculateHipotenusa(ladoA, ladob);
        }

        private decimal CalculateHipotenusa(decimal ladoa, decimal ladob)
        {
            return Convert.ToDecimal(Math.Sqrt((double)(ladoa * ladoa + ladob * ladob)));
        }

        public decimal Area()
        {
            return LadoA * LadoB / 2;
        }

        public decimal Perimetro()
        {
            return LadoA + LadoB + Hipotenusa;
        }
    }
}
