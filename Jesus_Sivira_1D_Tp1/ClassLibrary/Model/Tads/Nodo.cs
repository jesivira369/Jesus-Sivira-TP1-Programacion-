using ClassLibrary.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model.Tads
{
    public class Nodo
    {
        public Factura Factura { get; set; }

        public Nodo Siguiente { get; set; }


        
        public Nodo ( Factura factura)
        {
            Factura = factura;
        }

        public Nodo ( Factura factura, Nodo siguiente ) : this(factura)
        {
            Siguiente = siguiente;
        }
    }
}
