using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1
{
    internal class Triangulo : Figura
    {
        private float Base;
        private float Altura;

        public Triangulo(float bas,float altura)
        {
            this.Base = bas;
            this.Altura = altura;
        }
        public override void CalcularArea()
        {
            Console.WriteLine($"El area del circulo es: {(this.Base*this.Altura)/2}");
        }
    }
}
