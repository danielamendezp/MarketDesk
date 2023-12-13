using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Util
{
    public class CustomException : Exception
    {
        public CustomException()
        {

        }

        public CustomException(string pParametro)
            : base(pParametro)
        {

        }

    }
}
