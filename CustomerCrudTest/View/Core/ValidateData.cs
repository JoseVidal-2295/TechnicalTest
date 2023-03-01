using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCrudTest.View.Core
{
    public static class ValidateData
    {
        //Metodo para controlar que el usuario solo digite numeros enteros o decimal
        public static Boolean decimalNumber(object sender, KeyPressEventArgs e)
        {
            Boolean result = false;
            // Verifica si la tecla presionada es un número, la tecla de retroceso o el punto decimal.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                result = true; // Cancela la entrada de datos en el control TextBox.
            }

            // Verifica si se ha ingresado más de un punto decimal.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                result = true; 
            }

            return result;
        }

        //Metodo para controlar que el usuario solo digite numeros enteros
        public static Boolean integerNumber(object sender, KeyPressEventArgs e)
        {
            Boolean result = false;

            // Verifica si la tecla presionada es un número o si es la tecla de retroceso.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                result = true; 
            }

            return result;
        }
    }
}
