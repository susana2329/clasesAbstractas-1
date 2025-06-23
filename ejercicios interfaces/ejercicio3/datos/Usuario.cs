using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicios_interfaces.ejercicio3.datos
{
    /*
    1)	Estamos desarrollando una Api Rest y debemos asegurarnos de que cada 
    clase que creemos (las cuales representan una tabla de nuestra base de datos)
    tenga las posibilidades de que se puedan realizar peticiones GET(int id) para 
    obtener información, POST(string nuevo) para crear nuevos registros, 
    PUT(int id, string cambio) para actualizar o crear y DELETE(int id) para eliminar.
    */
    internal class Usuario
    {
        public int id;
        public string nombre;
        public string apellido;
        public string mail;
        public int edad;

        public Usuario()
        { 
        }
    }
}
