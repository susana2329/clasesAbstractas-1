using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesAbstractas_1.ejercicios_interfaces.ejercicio3.logica
{
    internal interface IUsuario
    {
        public void Get(int id);
        public void Post(string nuevo);
        public void Put(int id, string cambio);
        public void Delete(int id);
    }
}
