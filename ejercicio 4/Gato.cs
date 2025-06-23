using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicio_4
{
    internal class Gato : Animal
    {
        public string Raza;
        public Gato(string nom, int edad, string raza) : base(nom, edad)
        {
            this.Raza = raza;
        }
        public override void HacerSonido()
        {
            Console.WriteLine($"El Gato de nombre: {Nombre} edad: {Edad},y de raza{this.Raza} hace miauu");
        }
    }
}
