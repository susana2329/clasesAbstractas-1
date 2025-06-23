using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicios_interfaces.ejercicio2
{
    internal class Motoo : IVehiculo
    {
        public void Conducir() 
        {
            Console.WriteLine("Conduciendo una moto ");
        }
    }
}
