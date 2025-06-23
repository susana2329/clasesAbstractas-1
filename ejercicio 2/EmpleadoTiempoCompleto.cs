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
*/
    internal class EmpleadoTiempoCompleto : Empleado
    {
        public bool PresentesimoCompleto;
        public float BonoPresentismo;
        public EmpleadoTiempoCompleto(string nom, float sueldo, bool presentesimoCompleto, float bonoPresentismo) : base(nom, sueldo)
        {
            this.PresentesimoCompleto = presentesimoCompleto;
            this.BonoPresentismo = bonoPresentismo;
        }

        public override void CalcularSueldo()
        {
            if (PresentesimoCompleto==true)
            {
                Console.WriteLine($"El sueldo final del empleado de tiempo completo es de: {SueldoBase +this.BonoPresentismo}");
            }
            else
            {
                Console.WriteLine($"El sueldo final del empleado de medio tiempo es de: {SueldoBase}");
            }
        }
    }
}
