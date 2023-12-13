using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Enum
{
    using System;

    namespace ProyectoPromociones.Enum
    {
        public enum EUser
        {
            Administrador,
            Cajero,
            JefeCajas
        }
        public class EUserProgram
        {
            
            public static EUser BuscarUserRol(string nombre)
            {
                EUser eUser = EUser.Cajero;
                switch (nombre)
                {
                    case "JefeCajas":
                        eUser = EUser.JefeCajas;
                        break;
                    case "Cajero":
                        eUser = EUser.Cajero;
                        break;
                    case "Administrador":
                        eUser = EUser.Administrador;
                        break;
                }
                return eUser;
            }
        }
        }


}
