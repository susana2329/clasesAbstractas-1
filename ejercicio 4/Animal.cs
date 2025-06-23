using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicio_4
{

    /*4)Nos encontramos trabajando en el  Museo Argentino de Ciencias Naturales 
     * "Bernardino Rivadavia" y nos solicitaron un desarrollo para almacenar el 
     * sonido de diversos animales.
    Ayuda: Deberíamos tener en el Main un arreglo de animales y ejecutar un método que 
    tengan todos en común para escuchar los diversos sonidos catalogados por los científicos.
*/
    internal abstract class Animal
    {
        public string Nombre;
        public int Edad;

        public Animal(string nom, int edad)
        {
            this.Nombre = nom;
            this.Edad = edad;
        }
        public abstract void HacerSonido();
    }
}
