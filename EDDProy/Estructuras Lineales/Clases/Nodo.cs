using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales
{
    public class Nodo
    {
        public object Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(object dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    public class NodoDoble : Nodo
    {
        public NodoDoble Anterior { get; set; }

        public NodoDoble(object dato) : base(dato)
        {
            Anterior = null;
        }
    }
}
