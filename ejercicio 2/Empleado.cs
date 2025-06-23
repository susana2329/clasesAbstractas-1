using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicio_2
{
    /*2)	Crear una clase abstracta Empleado con los atributos Nombre, SueldoBase,
     * y un método abstracto CalcularSueldo(). Se debe crear las clases hijas 
     * EmpleadoTiempoCompleto y EmpleadoMedioTiempo.
El empleado de tiempo completo calcula su sueldo según su sueldo base + bono de presentismo.
El empleado de medio tiempo calcula su sueldo según su sueldo base + un bono extra 
    si supero las 20 horas semanales.
*/
    internal abstract class Empleado
    {
        public string Nombre;
        public float SueldoBase;

        public Empleado(string nom,float sueldo)
        {
            this.Nombre = nom;
            this.SueldoBase = sueldo;
        }

        public abstract void CalcularSueldo();

    }
}
