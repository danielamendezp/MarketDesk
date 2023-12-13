using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Utilities
{
    public class StackRuta
    {
        private static readonly Stack<string> oPila = new Stack<string>();

        /**
         * Retorna si la pila está vacía
         * @return True si la pila está vacía
         */
        public static bool PilaVacia()
        {
            return oPila.Count == 0;
        }

        /**
         * Extrae el último elemento de la pila
         * Si la pila está vacía, retorna vacío
         * @return Último elemento de la pila
         */
        public static string SacarUltimoElemento()
        {
            string resultado = null;

            if (oPila.Count > 0)
            {
                resultado = oPila.Pop();
            }
            return resultado;
        }

        /**
         * Agrega un valor a la pila
         * @param pValor Valor a agregar
         */
        public static void AgregarElemento(string user)
        {
            oPila.Push(user);
        }

        /**
         * Muestra el último elemento de la pila sin sacarlo
         * @return Último elemento de la pila
         */
        public static string VerUltimoElemento()
        {
            string resultado = null;

            if (oPila.Count > 0)
            {
                resultado = oPila.Peek();
            }
            return resultado;
        }
    }

}
