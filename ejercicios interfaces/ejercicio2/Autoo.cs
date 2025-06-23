using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicios_interfaces.ejercicio2
{
    /**1)Crear una interfaz IVehiculo con el método Conducir().
    Implementar las clases Auto, Moto y Bicicleta. Adaptar el método
    conducir para cada clase.
    **/
    internal class Autoo : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine("Conduciendo un auto");
        }
    }
}
