using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary.Model.Tools
{
    public static class ValidacionBox
    {
        /// <summary>
        /// valida solo números, un solo punto decimal y el signo 
        /// negativo solo al inicio
        /// </summary>
        /// <param name="form"></param>
        /// <param name="textbox"></param>
        /// <param name="e"></param>
        public static void decimales(this Form form, ref TextBox textbox, KeyPressEventArgs e)
        {
            string num = textbox.Text;
            int tamano = num.Length;
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                // signo negativo solo puede tener 1 al inicio
                if (e.KeyChar == '-')
                {
                    if (num.Contains("-") || (tamano != 0))
                    {
                        e.Handled = true;
                    }
                    else e.Handled = false;
                }
                // Los numeros solo pueden tener 1 decimal
                if (e.KeyChar == '.')
                {
                    if (num.Contains("."))
                    {
                        e.Handled = true;
                    }
                    else e.Handled = false;
                }
            }
        }


        /// <summary>
        /// Permite solo el ingreso de numeros y controles
        /// </summary>
        /// <param name="form"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void soloNumeros(this Form form, object sender, KeyPressEventArgs e)
        {
            // Verifica el ingreso de un numero
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else e.Handled = false;
        }
    }
}
