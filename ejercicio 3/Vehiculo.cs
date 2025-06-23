using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicio_3
{
    /*3)	Crear la clase abstracta Vehiculo con método abstracto Arrancar() y 
     * un método no abstracto que sea acelerar(). Crear las clases hijas Auto, Moto y Camion 
     * que implementen Arrancar().
    En el Main, crear un arreglo de Vehículos y que ejecuten el método arrancar y acelerar.

    Código de ejemplo del main:
        Vehiculo[] vehiculos = new Vehiculo[3];
        vehiculos[0] = new Auto();
        vehiculos[1] = new Moto();
        vehiculos[2] = new Camion();
        foreach (Vehiculo v in vehiculos)
        {
            v.MostrarTipo();
            v.Arrancar();
            Console.WriteLine();
        }
*/
    internal abstract class Vehiculo
    {
        public abstract void Arrancar();
        public virtual void Acelerar()
        {
        }
        public virtual void MostrarTipo()
        {

        }
    
}
}
