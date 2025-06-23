using clasesAbstractas_1.ejercicios_interfaces.ejercicio3.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicios_interfaces.ejercicio3.logica
{
    internal class LogicaUsuario : IUsuario
    {
        /*
   1)	Estamos desarrollando una Api Rest y debemos asegurarnos de que cada 
   clase que creemos (las cuales representan una tabla de nuestra base de datos)
   tenga las posibilidades de que se puedan realizar peticiones GET(int id) para 
   obtener información, POST(string nuevo) para crear nuevos registros, 
   PUT(int id, string cambio) para actualizar o crear y DELETE(int id) para eliminar.
   */
        public void Get(int id)
        {
            if (id != id)
            {
                Console.WriteLine("No se encontro el registro.");
            }
            else
            {
                Console.WriteLine($"Ha consultado el registro del usuario con id #{id}");
            }
        }
        public void Post(string nuevo)
        {
            Console.WriteLine("se agrego  el registro.");
        }
        public void Put(int id, string cambio)
        {
            Console.WriteLine($"Se cambio el id {id} , {cambio}");
        }
        public void Delete(int id)
        {
            Console.WriteLine("borrando el usuario " + id);
        }
        public LogicaUsuario() { }

    }
}
