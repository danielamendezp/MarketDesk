using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Utilities
{
    public class Stack
    {
        private static readonly Stack<object> oPila = new Stack<object>();

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
        public static Usser SacarUltimoElemento()
        {
            Usser resultado = null;

            if (oPila.Count > 0)
            {
                resultado = (Usser)oPila.Pop();
            }
            return resultado;
        }

        /**
         * Agrega un valor a la pila
         * @param pValor Valor a agregar
         */
        public static void AgregarElemento(Usser user)
        {
            oPila.Push(user);
        }

        /**
         * Muestra el último elemento de la pila sin sacarlo
         * @return Último elemento de la pila
         */
        public static Usser VerUltimoElemento()
        {
            Usser resultado = null;

            if (oPila.Count > 0)
            {
                resultado = (Usser)oPila.Peek();
            }
            return resultado;
        }
    }

}
