using clasesAbstractas_1.ejercicio_2;
using clasesAbstractas_1.ejercicio_3;
using clasesAbstractas_1.ejercicio_4;
using clasesAbstractas_1.ejercicios_interfaces.ejercicio1;
using clasesAbstractas_1.ejercicios_interfaces.ejercicio2;

namespace clasesAbstractas_1
{
    internal class Program
    {

    
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            /*EJERCICIO 1*/

            Circulo c1 = new Circulo(4.4);
            c1.CalcularArea();
            Cuadrado cc1 = new Cuadrado(2);
            cc1.CalcularArea();
            Triangulo t1 = new Triangulo(23, 1);
            t1.CalcularArea();
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            /*EJERCICIO 2*/
            EmpleadoMedioTiempo em1 = new EmpleadoMedioTiempo("sergio", 9876522, 30, 35000);
            em1.CalcularSueldo();
            EmpleadoTiempoCompleto em2 = new EmpleadoTiempoCompleto("lucas", 3234555, true, 29000);
            em2.CalcularSueldo();
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            /*EJERCICIO 3*/
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
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            /*EJERCICIO 4*/
            Animal[] ani = new Animal[3];
            ani[0] = new Cabra("teresa", 2, 4);
            ani[1] = new Gato("michi", 3, "siames");
            ani[2] = new Serpiente("snake", 1, "rojo");
            foreach(Animal a in ani)
            {
                a.HacerSonido();
                Console.WriteLine("");

            }
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            //ACA EMPIEZAN LOS EJERCICIOS DE INTERFACES
            /*EJERCICIO 1*/
            IExportable[] exportadores = new IExportable[3];
            exportadores[0] = new ExportarPDF();
            exportadores[1] = new ExportarExcel();
            exportadores[2] = new ExportarCSV();
            foreach (IExportable exportador in exportadores)
            {
                exportador.Exportar("contenido");
            }
            //------------------------------------------------------------------------
            //------------------------------------------------------------------------
            /*EJERCICIO 2*/
            IVehiculo[] v1 = new IVehiculo[3];
            v1[0] = new Autoo();
            v1[1] = new Motoo();
            v1[2] = new Bicicleta();
            foreach (IVehiculo vv in v1)
            {
                vv.Conducir();
                Console.WriteLine(""); 
            }
        }

    }
}
