using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicio_4
{
    internal class Serpiente : Animal
    {
        public string  Color;
        public Serpiente(string nom, int edad, string color) : base(nom, edad)
        {
            this.Color = color;
        }
        public override void HacerSonido()
        {
            Console.WriteLine($"La serpiente de nombre {Nombre}, edad {Edad}, que es de color {this.Color} hace: sssssss");
        }
    }
}
