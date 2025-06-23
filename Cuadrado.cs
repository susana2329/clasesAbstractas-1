using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1
{
    
    internal class Cuadrado : Figura
    {
        public double Lado;

        public Cuadrado(double lado)
        {
            this.Lado = lado;
        }
        public override void CalcularArea()
        {
            Console.WriteLine($"El area del cuadrado es:{Lado*Lado} ");
        }
    }
}
