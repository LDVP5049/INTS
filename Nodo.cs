using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace INTS
{
    class Nodo
    {
        public Numeros DatoNumero { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Numeros datosNumeros) 
        {
            DatoNumero = datosNumeros;
            Siguiente = null;
        }

    }
}
