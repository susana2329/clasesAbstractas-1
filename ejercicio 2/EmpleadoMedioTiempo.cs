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
El empleado de medio tiempo calcula su sueldo según su sueldo base + un bono extra 
    si supero las 20 horas semanales.
*/
    internal class EmpleadoMedioTiempo : Empleado
    {
        public int horasSemanales;
        public float bonoExtra;

        public EmpleadoMedioTiempo(string nom, float sueldo, int horas, float bono): base(nom, sueldo)
        {
            this.horasSemanales = horas;
            this.bonoExtra = bono;
        }
        public override void CalcularSueldo()
        {
            if (horasSemanales > 20)
            {
                Console.WriteLine($"El sueldo final del empleado de medio tiempo es de: {SueldoBase +this.bonoExtra}");
            }
            else
            {
                Console.WriteLine($"El sueldo final del empleado de medio tiempo es de: {SueldoBase}");
            }
        }
    }
}
