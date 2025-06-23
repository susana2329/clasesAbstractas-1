namespace clasesAbstractas_1
{
    internal class Program
    {

        /*1) Crear una clase abstracta Figura con un método 
         * abstracto CalcularArea(). Crear las clases Cuadrado, Círculo 
         * y Triángulo que hereden de Figura e implementen el método abstracto 
         * según su operación para calcular el área.*/
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
        }
        public abstract class Figura
        {
            


        }
    }
}
