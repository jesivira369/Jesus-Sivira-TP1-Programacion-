using ClassLibrary.Model.Data;
using ClassLibrary.Model.Tads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jesus_Sivira_1D_Tp1
{
    /// <summary>
    /// Interfaz utilizada para utilizar las funciones entre los dos formularios
    /// </summary>
    public interface IContract
    {
        // Guarda un objeto en la factura
        void Guardar(string codigo, string descripcion, string precio);

        // Funcion de buscar en la queue
        void Buscar(string codigo);
    }
}
