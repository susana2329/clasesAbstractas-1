using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1
{
    internal class Circulo : Figura
    {
        public double Radio;

        public Circulo (double radio)
        {
            Radio = radio;
        }

        public override void CalcularArea()
        {
            Console.WriteLine($"El area del circulo es: {Math.PI * (Radio * Radio)}");
        }
    }
}
