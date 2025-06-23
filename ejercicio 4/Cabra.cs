using clasesAbstractas_1.ejercicio_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicio_4
{
    internal class Cabra : Animal
    {
        public int Pezunia;

        public Cabra(string nom, int edad,int pezunia): base (nom,edad)
        {
            this.Pezunia = pezunia;
        }
        public override void HacerSonido()
        {
            Console.WriteLine($"La cabra de nombre: {Nombre} edad: {Edad},y cantidad de pezuñas {this.Pezunia} hace meee");
        }
    }
}
