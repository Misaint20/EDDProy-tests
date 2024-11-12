using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales
{
    public class Pila
    {
        private Nodo top;
        public string strPila { get; set; }

        public Pila()
        {
            top = null;
            strPila = string.Empty;
        }

        public void Push(object dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (EstaVacia())
            {
                top = nuevo;
            }
            else
            {
                nuevo.Siguiente = top;
                top = nuevo;
            }
        }

        public object Pop()
        {
            if (EstaVacia()) return null;

            object dato = top.Dato;
            top = top.Siguiente;
            return dato;
        }

        public bool EstaVacia() => top == null;

        public string ToDot()
        {
            StringBuilder sb = new StringBuilder();
            Nodo actual = top;
            while (actual != null)
            {
                if (actual.Siguiente != null)
                {
                    sb.AppendFormat("{0}->{1};{2}",
                        actual.Dato.ToString(),
                        actual.Siguiente.Dato.ToString(),
                        Environment.NewLine);
                }
                actual = actual.Siguiente;
            }
            return sb.ToString();
        }
    }
}
