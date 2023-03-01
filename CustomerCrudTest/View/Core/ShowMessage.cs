using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCrudTest.View.Core
{
    public static class ShowMessage
    {
        public static void ok()
        {
            MessageBox.Show("Operación completada exitosamente","Crud de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void warning(string requiredFields)
        {
            MessageBox.Show($"Los siguientes campos : {requiredFields} son obligatorios, favor completarlos", "Crud de clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void warning(Boolean setManual,string msj)
        {
            MessageBox.Show($"{msj}", "Crud de clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void warning()
        {
            MessageBox.Show($"Primero has doble clic para seleccionar el registro que deseas eliminar", "Crud de clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult question()
        {
            DialogResult result = MessageBox.Show("¿Realmente deseas eliminar el registro?", "Crud de clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            return result;
        }
        public static void error(string exeption)
        {
            MessageBox.Show($"Ocurrio la siguiente situacion {exeption}", "Crud de clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
