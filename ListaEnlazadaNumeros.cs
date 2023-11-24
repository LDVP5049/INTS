using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTS
{
    class ListaEnlazadaNumeros
    {
        private Nodo primero;

        public ListaEnlazadaNumeros()
        {
            primero = null;
        }

        public void AgregarNumero(Numeros datosNumero)
        {
            Nodo nuevoNodo = new Nodo(datosNumero);
            nuevoNodo.Siguiente = primero;
            primero = nuevoNodo;
        }

        public void ImprimirLista()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine($"Numero {actual.DatoNumero.Numero}");
                actual = actual.Siguiente;
            }
        }

    }
}
