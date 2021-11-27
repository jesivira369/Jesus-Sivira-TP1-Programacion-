using ClassLibrary.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.Model.Tads
{
    public class Cola 
    {

        public Nodo Primero { get; set; } // Inicio queue
        public Nodo Ultimo { get; set; } // Fin queue

        public Cola()
        {
           
            Primero = Ultimo = null;
        }

        /// <param name="factura"></param>
        public void Enqueue(Factura factura)
        {
            Nodo nodo = new Nodo(factura);

            // Si la cola esta vacia guardamos en Primero
            if ( Primero == null)
            {
                Primero = Ultimo = nodo;
                nodo.Siguiente = null;
            } else

            // si la cola ya tiene un primer valor guardamos en ultimo
            {
                Ultimo.Siguiente = nodo;
                nodo.Siguiente = null;
                Ultimo = nodo;
            }

            MessageBox.Show("Factura Cargada","Carga de Factura",
                            MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// Si el nodo es Null lanza un mensaje de error sino desencola y 
        /// devuelve el objeto desencolado
        /// </summary>
        /// <returns></returns>
        public Factura Dequeue() 
        {
            Factura factura = null;
            
            if (Primero == null) MessageBox.Show("Lista Vacia","Estado de las facturas",
                                                 MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
            {
                factura = Primero.Factura;
                Primero = Primero.Siguiente;
            }            
            return factura; // devolvemos el objeto factura

        }

        public Factura Peek()
        {
             return Primero.Factura;
        }

        public bool Vacia()
        {
            return Primero == null;
        }
        
    }
}
