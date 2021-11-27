using ClassLibrary.Model.Data;
using ClassLibrary.Model.Tads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.Model.Tools
{
    public static class listar
    {
     // Limpia la lista
        /// <param name="ingreso"></param>
        /// <param name="nodo"></param>
        /// <param name="lista"></param>
        public static void mostrarCola(int ingreso, Nodo nodo, ListBox lista)
        {
            lista.Items.Clear();
            mostrarNodoPantalla(ingreso,nodo,lista);
        }

        // Mostar nodos
        /// <param name="ingreso"></param>
        /// <param name="nodo"></param>
        /// <param name="lista"></param>
        public static void mostrarNodoPantalla(int ingreso, Nodo nodo, ListBox lista)
        {            
            if (nodo != null)
            {
                ingreso++;
                Factura factura = new Factura();
                factura = nodo.Factura;
                lista.Items.Add(ingreso + ") " +
                                "Codigo : " + factura.codigo +
                                "  -  Descripcion : " + factura.descripcion +
                                "  -  Valor : $" + factura.precio);

                if (nodo.Siguiente != null)
                {
                    // Mientras el nodo siguiente no sea null se llama asi mismo
                    mostrarNodoPantalla(ingreso,nodo.Siguiente,lista);
                }
            }
        }
    }
}
